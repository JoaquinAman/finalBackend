using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.BreadOrderRepository
{
    public interface IBreadOrderRepository
    {
        BreadOrder GetById(int id);
        List<BreadOrder> GetAll();
        void Delete(int id);
    }
}
