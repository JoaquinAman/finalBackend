using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.BreadRepository
{
    public interface IBreadRepository
    {
        BreadDTO Save(BreadDTO data);
        Bread GetById(int id);
        List<Bread> GetAll();
        void Delete(int id);
        List<Bread> GetAllBreadsByBakeryOffice(int id);
    }
}
