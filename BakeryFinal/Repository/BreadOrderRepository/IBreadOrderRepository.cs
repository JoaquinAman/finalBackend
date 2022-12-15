using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.BreadOrderRepository
{
    public interface IBreadOrderRepository
    {
        BreadOrderDTO Save(BreadOrderDTO data);
    }
}
