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

        public void Execute(int bakeryId)
        {
            Console.WriteLine("----");
            Console.WriteLine("1. Adding Order");

            Printer printer = new Printer();

            printer.PrintCommand(bakeryId, 3);
        }
    }
}
