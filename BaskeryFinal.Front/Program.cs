using BakeryFinal.Model.Domain;
using BaskeryFinal.Front.printer;
using System.Reflection;

namespace BaskeryFinal.Front
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Printer printer = new();
            await printer.PrintCommand(1, 1);
            //Console.ReadLine();
            //InitApp initApp = new InitApp();
            //Console.WriteLine("hola");
            //initApp.Init();
        }
        //static async Task Main(string[] args)
        //{

        //    var offices = await BakeryApi.GetList<BakeryOffice>("https://localhost:7052/bakeryOffice");
        //    foreach (var office in offices)
        //    {
        //        Console.WriteLine(office.Name);
        //    }
        //    Console.ReadLine();
        //}
    }
}