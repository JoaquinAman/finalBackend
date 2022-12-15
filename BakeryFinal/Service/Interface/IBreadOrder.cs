using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Service.Interface
{
    public interface IBreadOrder
    {
        BreadOrder GetById(int id);
        List<BreadOrder> GetAll();
        void Delete(int id);
    }
}
