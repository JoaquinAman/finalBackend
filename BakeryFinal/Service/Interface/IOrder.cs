using BakeryFinal.Model.DTO;

namespace BakeryFinal.Service.Interface
{
    public interface IOrder
    {
        OrderDTO Save(OrderDTO orderDTO);
        OrderDTO Update(int id, OrderDTO orderDTO);
        OrderDTO GetById(int id);
        List<OrderDTO> GetAll();
        void Delete(int id);
    }
}
