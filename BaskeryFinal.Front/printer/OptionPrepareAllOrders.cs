using BakeryFinal.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaskeryFinal.Front.printer
{
    public class OptionPrepareAllOrders : IOption
    {
        public int MyId { get; set; } = 6;

        public async Task Execute(int bakeryId)
        {
            //Preparar ordenes                              
            string path = "https://localhost:7052/order/orders/bakeryId?bakeryId=1";

            await BakeryApi.PrepareAllOrders(bakeryId, path);
            //foreach (var office in offices)
            //{
            //    Console.WriteLine(office.Name);
            //}

            Console.WriteLine("----");
            Console.WriteLine("1. Preparing all the orders");

            Printer printer = new Printer();

            await printer.PrintCommand(bakeryId, 2);
        }
    }
}
