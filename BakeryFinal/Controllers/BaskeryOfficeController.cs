﻿using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;
using BakeryFinal.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BakeryFinal.Controllers
{
    [ApiController]
    [Route("bakeryOffice")]
    public class BaskeryOfficeController : ControllerBase
    {
        private readonly IBakeryOffice _bakeryOffice;
        public BaskeryOfficeController(IBakeryOffice bakeryOffice)
        {
            _bakeryOffice = bakeryOffice;
        }

        //BakeryOfficeDTO Save(BakeryOfficeDTO bakeryOfficeDTO);
        //BakeryOffice GetById(int id);
        //List<BakeryOffice> GetAll();
        //void Delete(int id);

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
