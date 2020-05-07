using AltSource_Contest.Entitys;
using System;

namespace AltSource_Contest.Business
{
    public class DisplayData
    {
        public void Display(Data data)
        {
            Console.WriteLine("|  Name   | Price | Voice minutes | Text message | Data in MBs |");
            Console.WriteLine($"|  {data.Name}   | {data.Price} | {data.VoiceMunite} | {data.TextMessage} | {data.DataInMBs} |");
        }
    }
}
