using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskeryFinal.Front.printer
{
    public class OptionCloseApp : IOption
    {
        public int MyId { get; set; } = 4;

        public void Execute(int bakeryId)
        {
            Environment.Exit(0);
        }
    }
}
