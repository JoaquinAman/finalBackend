using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaskeryFinal.Front.printer
{
    public class OptionMenuWithOrders : IOption
    {
        public int MyId { get; set; } = 3;

        public async Task Execute(int bakeryId)
        {
            Console.WriteLine("----");
            Console.WriteLine("1. Add Order");
            Console.WriteLine("2. Prepare all the orders");
            Console.WriteLine("3. Go back to the main menu");

            var selectedOption = 0;
            do
            {
                Console.WriteLine("Number between 1 and 3:");
                selectedOption = Int32.Parse(Console.ReadLine());
            }
            while (selectedOption > 3 || selectedOption < 1);

            Printer printer = new Printer();
            if (selectedOption == 3)
            {
                selectedOption = 1;
            }
            if (selectedOption == 1)
            {
                selectedOption = 5;
            }
            if (selectedOption == 2)
            {
                selectedOption = 6;
            }
            await printer.PrintCommand(bakeryId, selectedOption);
        }
    }
}
