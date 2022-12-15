using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;
using BakeryFinal.Repository.BreadRepository;
using BakeryFinal.Repository.OrderRepository;
using BakeryFinal.Service.Interface;

namespace BakeryFinal.Service.Implementation
{
    public class BreadService : IBread
    {
        private readonly IBreadRepository _breadRepository;

        public BreadService(IBreadRepository breadRepository)
        {
            _breadRepository = breadRepository;
        }
        public void Delete(int id)
        {
            _breadRepository.Delete(id);
        }

        public List<Bread> GetAll()
        {
            return _breadRepository.GetAll();
        }

        public Bread GetById(int id)
        {
            return _breadRepository.GetById(id);
        }

        public BreadDTO Save(BreadDTO breadDTO)
        {
            return _breadRepository.Save(breadDTO);
        }
    }
}
