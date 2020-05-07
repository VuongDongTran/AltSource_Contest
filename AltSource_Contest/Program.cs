using AltSource_Contest.Business;
using AltSource_Contest.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltSource_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input data as message.
            InputText inputAction = new InputText();
            var items = inputAction.InputString();

            //Create data from input string.
            DataBusiness createBusiness = new DataBusiness();
            var data = createBusiness.CreateData(items);

            //Display data.
            DisplayData displayData = new DisplayData();
            displayData.Display(data);

            //Input action to see remaining data as input string.
            var inputString = inputAction.InputActionsString();

            //Caculate data remaining.
            var dataRemaining = createBusiness.RemainingData(inputString, data);

            //Display data remaining.
            displayData.Display(dataRemaining);

            Console.WriteLine("Press any key to exits");
            Console.ReadKey();
        }
    }
}
