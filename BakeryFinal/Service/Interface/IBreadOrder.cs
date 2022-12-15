using BakeryFinal.Model.DTO;

namespace BakeryFinal.Service.Interface
{
    public interface IBreadOrder
    {
        BreadOrderDTO Save(BreadOrderDTO breadOrderDTO);
        BreadOrderDTO Update(int id, BreadOrderDTO breadOrderDTO);
        BreadOrderDTO GetById(int id);
        List<BreadOrderDTO> GetAll();
        void Delete(int id);
    }
}
