using BakeryFinal.Data;
using BakeryFinal.Exceptions;
using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;
using Microsoft.EntityFrameworkCore;

namespace BakeryFinal.Repository.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDBContext _context;
        public OrderRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var itemToRemove = _context.Order.SingleOrDefault(x => x.Id == id);
            _context.Order.Remove(itemToRemove);
            _context.SaveChanges();
        }

        public List<Order> PrepareAllOrdersByBakeryOffice(int bakeryOfficeId)
        {
            List<Order> orders = _context.Order.Where(x => x.BakeryOfficeId == bakeryOfficeId).ToList();
            foreach(var order in orders)
            {
                order.Status = "done";
            }
            _context.SaveChanges();
            return orders;
        }

        public List<Order> GetAll()
        {
            return _context.Order.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Order.SingleOrDefault(x => x.Id == id);
        }

        public int GetTotalQuantityInOrder(OrderDTO data)
        {
            var breadOrderCollection = data.BreadOrder;
            int totalQuantity = 0;
            foreach(var breadOrder in breadOrderCollection)
            {
                totalQuantity += breadOrder.Quantity;
            }
            return totalQuantity;
        }

        public OrderDTO Save(OrderDTO data)
        {
            var currentBakeryOffice = _context.BakeryOffice.SingleOrDefault(x => x.Id == data.BakeryOfficeId);
            var currentBreadTotal = currentBakeryOffice.Accumulated;
            var newQuantityDesired = GetTotalQuantityInOrder(data);
            if (currentBakeryOffice.MaxCapacity < (currentBreadTotal + newQuantityDesired))
            {
                //throw new BakeryOfficeMaxOutCapacityException();
                var surplus = -1*(currentBakeryOffice.MaxCapacity - currentBreadTotal + newQuantityDesired);
                return new OrderDTO()
                {
                    Status = "Can not create order because an surplus in in desired quantity of: " + surplus + ".", 
                };
            }


            var order = new Order()
            {
                BakeryOfficeId = data.BakeryOfficeId,
                Status = data.Status,
                TotalPrice = data.TotalPrice,
            };

            _context.Order.Add(order);
            _context.SaveChanges();
            SaveBreadOrder(data.BakeryOfficeId, order.Id, data.BreadOrder);
            return data;
        }


        private void SaveBreadOrder(int bakeryOfficeId, int orderDbId, IEnumerable<BreadOrderDTO> orderDto)
        {
            int accumulator = 0;
            foreach (var breadOrder in orderDto)
            {
                var breadOrderDb = new BreadOrder()
                {
                    IdOrder = orderDbId,
                    IdBread = breadOrder.IdBread,
                    Quantity = breadOrder.Quantity

                };
                accumulator += breadOrder.Quantity;
                _context.BreadOrder.Add(breadOrderDb);
                _context.SaveChanges();
            }

            var currentBakeryOffice = _context.BakeryOffice.SingleOrDefault(x => x.Id == bakeryOfficeId);
            currentBakeryOffice.Accumulated = accumulator;
        }
    }
}
