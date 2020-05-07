using AltSource_Contest.Abstracts;
using System;

namespace AltSource_Contest.Business
{
    public class InputText : InputTextBase
    {
        public string[] InputString()
        {
            Console.WriteLine("Input your text here, please:\n");
            Console.WriteLine("Syntax: top up $10 for option B1, get 20 minutes of phone call, 50 text messages and 0 MB \n");
            
            var message = Console.ReadLine();
            var items = SplitData(message.Trim());

            return items;
        }

        public string[] InputActionsString()
        {
            Console.WriteLine("Input use's action here, please:\n");
            Console.WriteLine("Syntax: called for 5 minutes and sent 5 messages and 0 MB\n");
            var message = Console.ReadLine();
            return SplitData(message.Trim());
        }
    }
}
