using BakeryFinal.Model.Domain;
using BakeryFinal.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaskeryFinal.Front.printer
{
    public class OptionAddOrder : IOption
    {
        public int MyId { get; set; } = 5;

        public async Task Execute(int bakeryId)
        {


            //{
            //    "totalPrice": 0,
            //      "bakeryOfficeId": 0,
            //      "breadOrder": [
            //        {
            //                        "idBread": 0,
            //          "quantity": 0
            //        }
            //      ],
            //      "status": "string"
            //}
            
            List<BreadOrderDTO> listBreadOrder = new();
            listBreadOrder.Add(new BreadOrderDTO()
            {
                IdBread = 1,
                Quantity = 1
            });
            OrderDTO orderDTO = new()
            {
                TotalPrice= 2,
                BakeryOfficeId= bakeryId,
                Status= "preparing",
                BreadOrder = listBreadOrder,

            };
            //Add Ordenes
            var offices = await BakeryApi.Create("https://localhost:7052/order", orderDTO);
            
            //foreach (var office in offices)
            //{
            //    Console.WriteLine(office.Name);
            //}

            Console.WriteLine("----");
            Console.WriteLine("1. Adding Order");

            Printer printer = new Printer();

            await printer.PrintCommand(bakeryId, 3);
        }
    }
}
