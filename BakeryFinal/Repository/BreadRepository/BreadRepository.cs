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

        public List<Bread> GetAllBreadsByBakeryOffice(int id)
        {
            var bakeryOffice = _context.Bread.Where(x => x.Bakery.Id == id).ToList();
            List<Bread> breads = new List<Bread>();
            foreach(var bread in bakeryOffice)
            {
                breads.Add(bread);
            }
            return breads;
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
            var bread = new Bread()
            {
                Name = data.Name,
                Price = data.Price,
            };
            _context.Add(bread);
            _context.SaveChanges();
            return data;
        }
    }
}
