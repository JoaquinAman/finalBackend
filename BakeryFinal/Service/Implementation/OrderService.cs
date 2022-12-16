using BakeryFinal.Model.Domain;
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
            _orderRepository.Delete(id);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public List<Order> PrepareAllOrdersByBakeryOffice(int bakeryOfficeId)
        {
            return _orderRepository.PrepareAllOrdersByBakeryOffice(bakeryOfficeId);
        }

        public OrderDTO Save(OrderDTO orderDTO)
        {
            return _orderRepository.Save(orderDTO);
        }
    }
}
