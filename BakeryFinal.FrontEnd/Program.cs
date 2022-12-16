using BakeryFinal.Model.Domain;

namespace BakeryFinal.FrontEnd
{
    public class Program
    {

        static async Task Main(string[] args)
        {

            var offices = await API.GetList<BakeryOffice>("https://localhost:7052/bakeryOffice");
            foreach (var office in offices)
            {
                Console.WriteLine(office.Id);
                Console.WriteLine(office.Name);
            }
        }
    }
}