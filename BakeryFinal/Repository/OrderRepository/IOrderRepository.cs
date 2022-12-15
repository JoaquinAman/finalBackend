using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.OrderRepository
{
    public interface IOrderRepository
    {
        OrderDTO Save(OrderDTO data);
    }
}
