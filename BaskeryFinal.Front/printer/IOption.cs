using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskeryFinal.Front.printer
{
    public interface IOption
    {
        public int MyId { get; set; }
        public void Execute(int bakeryId);
    }
}
