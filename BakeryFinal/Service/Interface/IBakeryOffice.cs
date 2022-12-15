using BakeryFinal.Model.DTO;

namespace BakeryFinal.Service.Interface
{
    public interface IBakeryOffice
    {
        BakeryOfficeDTO Save(BakeryOfficeDTO bakeryOfficeDTO);
        BakeryOfficeDTO Update(int id, BakeryOfficeDTO bakeryOfficeDTO);
        BakeryOfficeDTO GetById(int id);
        List<BakeryOfficeDTO> GetAll();
        void Delete(int id);
    }
}
