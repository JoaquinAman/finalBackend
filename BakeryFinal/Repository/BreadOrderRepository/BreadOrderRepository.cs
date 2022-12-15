using BakeryFinal.Data;
using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.BreadOrderRepository
{
    public class BreadOrderRepository : IBreadOrderRepository
    {
        private readonly ApplicationDBContext _context;
        public BreadOrderRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var itemToRemove = _context.BreadOrder.SingleOrDefault(x => x.Id == id);
            _context.BreadOrder.Remove(itemToRemove);
            _context.SaveChanges();
        }

        public List<BreadOrder> GetAll()
        {
            return _context.BreadOrder.ToList();
        }

        public BreadOrder GetById(int id)
        {
            return _context.BreadOrder.SingleOrDefault(x => x.Id == id);
        }       
    }
}
