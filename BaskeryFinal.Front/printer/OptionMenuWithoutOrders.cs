using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaskeryFinal.Front.printer
{
    public class OptionMenuWithoutOrders : IOption
    {
        public int MyId { get; set; } = 2;

        public void Execute(int bakeryId)
        {
            Console.WriteLine("----");
            Console.WriteLine("1. Add Order");
            Console.WriteLine("2. Go back to the main menu");

            var selectedOption = 0;
            do
            {
                selectedOption = Int32.Parse(Console.ReadLine());
                Console.WriteLine(selectedOption + " " + MyId);
            }
            while (selectedOption > 2 || selectedOption < 1);

            Printer printer = new Printer();
            if (selectedOption == 1)
            {
                selectedOption = 5;
            }
            if (selectedOption == 2)
            {
                selectedOption = 1;
            }

            printer.PrintCommand(bakeryId, selectedOption);
        }
    }
}
