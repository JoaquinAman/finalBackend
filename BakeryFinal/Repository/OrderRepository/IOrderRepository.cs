using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.OrderRepository
{
    public interface IOrderRepository
    {
        OrderDTO Save(OrderDTO data);
        Order GetById(int id);
        List<Order> GetAll();
        void Delete(int id);
        List<Order> PrepareAllOrdersByBakeryOffice(int bakeryOfficeId);
    }
}
