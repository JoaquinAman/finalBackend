using BaskeryFinal.Front.printer;
using System.Reflection;

namespace BaskeryFinal.Front
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Printer printer = new();
            printer.PrintCommand(1, 1);
        }
    }
}