using BakeryFinal.Data;
using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDBContext _dBContext;
        public OrderRepository(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public OrderDTO Save(OrderDTO data)
        {
            var order = new Order()
            {
                BakeryOfficeId = data.BakeryOfficeId,
                Status = data.Status,
                TotalPrice = data.TotalPrice,
            };

            _dBContext.Order.Add(order);
            _dBContext.SaveChanges();
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
                _dBContext.BreadOrder.Add(breadOrderDb);
                _dBContext.SaveChanges();
            }
        }
    }
}
