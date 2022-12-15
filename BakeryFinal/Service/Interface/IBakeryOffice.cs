using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Service.Interface
{
    public interface IBakeryOffice
    {
        BakeryOfficeDTO Save(BakeryOfficeDTO bakeryOfficeDTO);
        BakeryOffice GetById(int id);
        List<BakeryOffice> GetAll();
        void Delete(int id);
    }
}
