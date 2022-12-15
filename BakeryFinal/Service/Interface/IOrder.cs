using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Service.Interface
{
    public interface IOrder
    {
        OrderDTO Save(OrderDTO orderDTO);
        Order GetById(int id);
        List<Order> GetAll();
        void Delete(int id);
    }
}
