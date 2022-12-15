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
            throw new NotImplementedException();
        }

        public List<BreadDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public BreadDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public BreadDTO Save(BreadDTO breadDTO)
        {
            throw new NotImplementedException();
        }

        public BreadDTO Update(int id, BreadDTO breadDTO)
        {
            throw new NotImplementedException();
        }
    }
}
