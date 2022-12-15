using BakeryFinal.Model.Domain;
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
            _bakeryOfficeRepository.Delete(id);
        }

        public List<BakeryOffice> GetAll()
        {
            return _bakeryOfficeRepository.GetAll();
        }

        public BakeryOffice GetById(int id)
        {
            return _bakeryOfficeRepository.GetById(id);
        }

        public BakeryOfficeDTO Save(BakeryOfficeDTO bakeryOfficeDTO)
        {
            return _bakeryOfficeRepository.Save(bakeryOfficeDTO);
        }
    }
}
