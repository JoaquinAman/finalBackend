using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;
using BakeryFinal.Repository.OrderRepository;
using BakeryFinal.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BakeryFinal.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : ControllerBase
    {

        private readonly IOrder _order;
        public OrderController(IOrder order)
        {
            _order = order;
        }
        [HttpPost]
        public IActionResult SaveOrder(OrderDTO addOrder)
        {
            var order = _order.Save(addOrder);
            return Ok(order);
        }
        [HttpGet]
        [Route("id")]
        public Order GetOrderById(int id)
        {
            
            return _order.GetById(id);

        }
        [HttpPut]
        [Route("orders/bakeryId")]
        public List<Order> GetOrdersByBakeryId(int bakeryId)
        {
            return _order.PrepareAllOrdersByBakeryOffice(bakeryId);

        }
        [HttpGet]
        public List<Order> GetAll()
        {
            return _order.GetAll();
        }
        [HttpDelete]
        public void DeleteById(int id)
        {
            _order.Delete(id);
        }
    }
}
