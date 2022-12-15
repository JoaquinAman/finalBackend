using BakeryFinal.Model.DTO;
using BakeryFinal.Repository.OrderRepository;
using BakeryFinal.Service.Interface;

namespace BakeryFinal.Service.Implementation
{
    public class OrderService : IOrder
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDTO Save(OrderDTO orderDTO)
        {
            throw new NotImplementedException();
        }

        public OrderDTO Update(int id, OrderDTO orderDTO)
        {
            throw new NotImplementedException();
        }
    }
}
