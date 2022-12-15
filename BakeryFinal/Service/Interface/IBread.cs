using BakeryFinal.Model.DTO;

namespace BakeryFinal.Service.Interface
{
    public interface IBread
    {
        BreadDTO Save(BreadDTO breadDTO);
        BreadDTO Update(int id, BreadDTO breadDTO);
        BreadDTO GetById(int id);
        List<BreadDTO> GetAll();
        void Delete(int id);
    }
}
