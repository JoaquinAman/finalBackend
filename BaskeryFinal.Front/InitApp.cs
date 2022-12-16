using BakeryFinal.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskeryFinal.Front
{
    public class InitApp
    {
        public async Task Init()
        {
            Console.WriteLine("2");                              
            var offices = await BakeryApi.GetList<BakeryOffice>("https://localhost:7052/bakeryOffice");
            foreach (var office in offices)
            {
                Console.WriteLine(office.Name);
            }
        }
    }
}
