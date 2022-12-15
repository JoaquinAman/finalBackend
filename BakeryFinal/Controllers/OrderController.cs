using BakeryFinal.Model.DTO;
using BakeryFinal.Repository.OrderRepository;
using Microsoft.AspNetCore.Mvc;

namespace BakeryFinal.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _crudRepository;
        public OrderController(IOrderRepository crudRepository)
        {
            _crudRepository = crudRepository;
        }
        [HttpPost]
        public IActionResult SaveOrder(OrderDTO addOrder)
        {
            var order = _crudRepository.Save(addOrder);
            return Ok(order);
        }
    }
}
