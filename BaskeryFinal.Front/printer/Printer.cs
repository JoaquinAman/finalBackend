using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskeryFinal.Front.printer
{
    public class Printer
    {
         public List<IOption> OptionsList { get; set; } = new List<IOption>();
        public Printer()
        {
            IOption optionSelectOfficeMenu = new OptionSelectOfficeMenu();
            IOption optionMenuWithoutOrders = new OptionMenuWithoutOrders();
            IOption optionMenuWithOrders = new OptionMenuWithOrders();
            IOption optionAddOrder = new OptionAddOrder();
            IOption optionPrepareAllOrders = new OptionPrepareAllOrders();
            IOption optionCloseApp = new OptionCloseApp();
            OptionsList.Add(optionSelectOfficeMenu);
            OptionsList.Add(optionMenuWithoutOrders);
            OptionsList.Add(optionMenuWithOrders);
            OptionsList.Add(optionAddOrder);
            OptionsList.Add(optionPrepareAllOrders);
            OptionsList.Add(optionCloseApp);
        }
        
        public async Task PrintCommand(int bakeryId, int option)
        {
            //Console.WriteLine("recibo la option en printer: " + option);
            foreach (IOption optionInList in OptionsList)
            {
                if (optionInList.MyId == option)
                {
                    await optionInList.Execute(bakeryId);
                }
            }
        }
    }
}
