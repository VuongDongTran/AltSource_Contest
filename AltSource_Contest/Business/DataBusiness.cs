using AltSource_Contest.Entitys;
using System;

namespace AltSource_Contest.Business
{
    public class DataBusiness
    {
        public Data CreateData(string[] inputString)
        {
            Data data = new Data();

            for (int item = 0; item < inputString.Length; item++)
            {
                var money = inputString[item].Substring(0, 1);
                if (inputString[item].Substring(0, 1) == "$")
                {
                    data.Price = Convert.ToDouble(inputString[item].Substring(1));
                }
                if (inputString[item] == "for" && inputString[item + 1] == "option")
                {
                    data.Name = inputString[item + 2].Replace(",", "");
                }
                if (inputString[item] == "minutes" || inputString[item] == "minute")
                {
                    data.VoiceMunite = Convert.ToInt32(inputString[item - 1]);
                }
                if (inputString[item] == "text"|| inputString[item] == "messages")
                {
                    var isNumeric = int.TryParse(inputString[item - 1], out int n);
                    if (isNumeric)
                        data.TextMessage = Convert.ToInt32(inputString[item - 1]);
                }
                if (inputString[item] == "MB")
                {
                    data.DataInMBs = Convert.ToInt32(inputString[item - 1]);
                }
            }
            return data;
        }

        public Data RemainingData(string[] inputString, Data data)
        {
            Data newData = new Data();
            for (int item = 0; item < inputString.Length; item++)
            {
                var money = inputString[item].Substring(0, 1);
                if (inputString[item].Substring(0, 1) == "$")
                {
                    data.Price = Convert.ToDouble(inputString[item].Substring(1));
                }
                if (inputString[item] == "for" && inputString[item + 1] == "option")
                {
                    data.Name = inputString[item + 2].Replace(",", "");
                }
                if (inputString[item] == "minutes" || inputString[item] == "minute")
                {
                    data.VoiceMunite = data.VoiceMunite - Convert.ToInt32(inputString[item - 1]);
                }
                if (inputString[item] == "text" || inputString[item] == "messages")
                {
                    data.TextMessage = data.TextMessage - Convert.ToInt32(inputString[item - 1]);
                }
                if (inputString[item] == "MB")
                {
                    data.DataInMBs = data.DataInMBs - Convert.ToInt32(inputString[item - 1]);
                }
            }
            return data;
        }
    }
}
