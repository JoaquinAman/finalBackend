using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Service.Interface
{
    public interface IBread
    {
        BreadDTO Save(BreadDTO breadDTO);
        Bread GetById(int id);
        List<Bread> GetAll();
        void Delete(int id);
        List<Bread> GetAllBreadsByBakeryOffice(int id);
    }
}
