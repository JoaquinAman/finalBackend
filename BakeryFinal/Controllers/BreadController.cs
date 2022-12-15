using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;
using BakeryFinal.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BakeryFinal.Controllers
{
    [ApiController]
    [Route("bread")]
    public class BreadController : ControllerBase
    {
        private readonly IBread _bread;
        public BreadController(IBread bread)
        {
            _bread = bread;
        }

        [HttpPost]
        public IActionResult SaveBread(BreadDTO addBread)
        {
            var bread = _bread.Save(addBread);
            return Ok(bread);
        }
        [HttpGet]
        [Route("id")]
        public Bread GetBreadById(int id)
        {
            return _bread.GetById(id);

        }
        [HttpGet]
        public List<Bread> GetAll()
        {
            return _bread.GetAll();
        }
        [HttpDelete]
        public void DeleteById(int id)
        {
            _bread.Delete(id);
        }
    }
}
