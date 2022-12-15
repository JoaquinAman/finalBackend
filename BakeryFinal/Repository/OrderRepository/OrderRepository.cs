using BakeryFinal.Data;
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

        public List<Order> GetAll()
        {
            return _context.Order.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Order.SingleOrDefault(x => x.Id == id);
        }

        public OrderDTO Save(OrderDTO data)
        {
            var order = new Order()
            {
                BakeryOfficeId = data.BakeryOfficeId,
                Status = data.Status,
                TotalPrice = data.TotalPrice,
            };

            _context.Order.Add(order);
            _context.SaveChanges();
            SaveBreadOrder(order.Id, data.BreadOrder);
            return data;
        }

     

        private void SaveBreadOrder(int orderDbId, IEnumerable<BreadOrderDTO> orderDto)
        {
            foreach (var breadOrder in orderDto)
            {
                var breadOrderDb = new BreadOrder()
                {
                    IdOrder = orderDbId,
                    IdBread = breadOrder.IdBread,
                    Quantity = breadOrder.Quantity
                };
                _context.BreadOrder.Add(breadOrderDb);
                _context.SaveChanges();
            }
        }
    }
}
