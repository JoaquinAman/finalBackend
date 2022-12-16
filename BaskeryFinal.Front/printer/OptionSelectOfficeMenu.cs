using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaskeryFinal.Front.printer
{
    public class OptionSelectOfficeMenu : IOption
    {
        public int MyId { get; set; } = 1;

        public void Execute(int bakeryId)
        {
            Console.WriteLine("----");
            Console.WriteLine("Bakery Fresh Bread");
            Console.WriteLine("------------------");
            Console.WriteLine("Select the office to make an order:");
            Console.WriteLine("1. Main Office");
            Console.WriteLine("2. Secondary Office");
            Console.WriteLine("3. Close App");


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
                selectedOption = 4;
            }
            if (selectedOption == 1)
            {
                selectedOption = 2;
                bakeryId = 1;
            }
            if (selectedOption == 2)
            {
                selectedOption = 2;
                bakeryId = 2;
            }
            printer.PrintCommand(bakeryId, selectedOption);
        }
    }
}
