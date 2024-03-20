using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace DictionarySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> currencyDictionary = new Dictionary<string, List<string>>()
            {
                { "FIAT", new List<string> { "USD", "EUR", "JPY" } },
                { "Cryptocurrency", new List<string> { "BTC", "ETH", "XRP" } },
                { "Commodity Money", new List<string> { "GOLD", "SILVER", "PLATINUM" } }
            };
            foreach (var key in currencyDictionary.Keys.ToList())
            {
                currencyDictionary[key].Sort();
            }
            string json = JsonConvert.SerializeObject(currencyDictionary, Formatting.Indented);
            Console.WriteLine("відсортований  словник валют:");
            Console.WriteLine(json);
            string filePath = "D:\\Json valuta.txt";
            File.WriteAllText(filePath, json);

            Console.WriteLine($"JSON saved to: {"D:\\Json valuta.txt"}");
        }
    }
}
