using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace InventoryManagementSystem.InventoryManagement
{
    public class InventoryData
    {
        public void DisplayInventoryData(string filePath)
        { 
        StreamReader reader = new StreamReader(filePath);

            string json = reader.ReadToEnd();
            var inventory = JsonConvert.DeserializeObject<List<Inventory>>(json);
            Console.WriteLine("Name"+"\t"+"PricePrKg"+"\t"+"Weight"+"\t\t"+"TotalPrice");
            foreach (Inventory item in inventory)
            {
                Console.WriteLine(item.Name+ "\t" +item.Price+ "\t\t" +item.Weight+  "\t\t" +(item.Price * item.Weight));
            }
        }
    }
}
