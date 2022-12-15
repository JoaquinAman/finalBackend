using BakeryFinal.Model.Domain;
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
            _breadOrderRepository.Delete(id);
        }

        public List<BreadOrder> GetAll()
        {
            return _breadOrderRepository.GetAll();
        }

        public BreadOrder GetById(int id)
        {
            return _breadOrderRepository.GetById(id);
        }
    }
}
