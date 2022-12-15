using BakeryFinal.Data;
using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;

namespace BakeryFinal.Repository.BakeryOfficeRepository
{
    public class BakeryOfficeRepository : IBakeryOfficeRepository
    {
        private readonly ApplicationDBContext _context;
        public BakeryOfficeRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var itemToRemove = _context.BakeryOffice.SingleOrDefault(x => x.Id == id);
            _context.BakeryOffice.Remove(itemToRemove);
            _context.SaveChanges();
        }

        public List<BakeryOffice> GetAll()
        {
            return _context.BakeryOffice.ToList();
        }

        public BakeryOffice GetById(int id)
        {
            return _context.BakeryOffice.SingleOrDefault(x => x.Id == id);
        }

        public BakeryOfficeDTO Save(BakeryOfficeDTO data)
        {
            _context.Add(data);
            _context.SaveChanges();
            return data;
        }

    }
}
