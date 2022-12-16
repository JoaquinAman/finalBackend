using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;
using BakeryFinal.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BakeryFinal.Controllers
{
    [ApiController]
    [Route("bakeryOffice")]
    public class BakeryOfficeController : ControllerBase
    {
        private readonly IBakeryOffice _bakeryOffice;
        public BakeryOfficeController(IBakeryOffice bakeryOffice)
        {
            _bakeryOffice = bakeryOffice;
        }

        [HttpPost]
        public IActionResult SaveBakeryOffice(BakeryOfficeDTO addBakeryOffice)
        {
            var bakeryOffice = _bakeryOffice.Save(addBakeryOffice);
            return Ok(bakeryOffice);
        }
        [HttpGet]
        [Route("id")]
        public BakeryOffice GetBakeryOfficeById(int id)
        {
            return _bakeryOffice.GetById(id);

        }
        [HttpGet]
        public List<BakeryOffice> GetAll()
        {
            return _bakeryOffice.GetAll();
        }
        [HttpDelete]
        public void DeleteById(int id)
        {
            _bakeryOffice.Delete(id);
        }
    }
}
