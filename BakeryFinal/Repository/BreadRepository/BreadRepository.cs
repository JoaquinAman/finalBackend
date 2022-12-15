using BakeryFinal.Data;
using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.BreadRepository
{
    public class BreadRepository : IBreadRepository
    {
        private readonly ApplicationDBContext _context;
        public BreadRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var itemToRemove = _context.Bread.SingleOrDefault(x => x.Id == id);
            _context.Bread.Remove(itemToRemove);
            _context.SaveChanges();
        }

        public List<Bread> GetAll()
        {
            return _context.Bread.ToList();
        }

        public Bread GetById(int id)
        {
            return _context.Bread.SingleOrDefault(x => x.Id == id);
        }

        public BreadDTO Save(BreadDTO data)
        {
            _context.Add(data);
            _context.SaveChanges();
            return data;
        }
    }
}
