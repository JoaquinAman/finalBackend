using BakeryFinal.Model.DTO;
using BakeryFinal.Repository.BakeryOfficeRepository;
using BakeryFinal.Repository.OrderRepository;
using BakeryFinal.Service.Interface;

namespace BakeryFinal.Service.Implementation
{
    public class BakeryOfficeService : IBakeryOffice
    {
        private readonly IBakeryOfficeRepository _bakeryOfficeRepository;

        public BakeryOfficeService(IBakeryOfficeRepository bakeryOfficeRepository)
        {
            _bakeryOfficeRepository = bakeryOfficeRepository;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BakeryOfficeDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public BakeryOfficeDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public BakeryOfficeDTO Save(BakeryOfficeDTO bakeryOfficeDTO)
        {
            throw new NotImplementedException();
        }

        public BakeryOfficeDTO Update(int id, BakeryOfficeDTO bakeryOfficeDTO)
        {
            throw new NotImplementedException();
        }
    }
}
