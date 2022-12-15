using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.BakeryOfficeRepository
{
    public interface IBakeryOfficeRepository
    {
        BakeryOfficeDTO Save(BakeryOfficeDTO data);
        BakeryOffice GetById(int id);
        List<BakeryOffice> GetAll();
        void Delete(int id);
    }
}
