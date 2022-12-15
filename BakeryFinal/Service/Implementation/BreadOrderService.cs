using BakeryFinal.Model.DTO;
using BakeryFinal.Repository.BreadOrderRepository;
using BakeryFinal.Repository.OrderRepository;
using BakeryFinal.Service.Interface;

namespace BakeryFinal.Service.Implementation
{
    public class BreadOrderService : IBreadOrder
    {
        private readonly IBreadOrderRepository _breadOrderRepository;

        public BreadOrderService(IBreadOrderRepository breadOrderRepository)
        {
            _breadOrderRepository = breadOrderRepository;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BreadOrderDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public BreadOrderDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public BreadOrderDTO Save(BreadOrderDTO breadOrderDTO)
        {
            throw new NotImplementedException();
        }

        public BreadOrderDTO Update(int id, BreadOrderDTO breadOrderDTO)
        {
            throw new NotImplementedException();
        }
    }
}
