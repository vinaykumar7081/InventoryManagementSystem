using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace InventoryManagementSystem.StockAccountManagement
{
    public class StockPortfolio
    {
        const string File_Path = @"D:\InventoryManagementProblemStatement\InventoryManagementSystem\InventoryManagementSystem\StockAccountManagement\StockAccount.json"; 
        StreamReader reader = new StreamReader(File_Path);
        public void DisplayStockDetails()
        {
            string json = reader.ReadToEnd();
            var stockPrice= JsonConvert.DeserializeObject<List<StockDetails>>(json);
            Console.WriteLine("StockName"+"\t"+"NumberOfShare"+"\t"+"SharePrice"+"\t"+"TotalSharePrice");
            foreach (var data in stockPrice)
            { 
            Console.WriteLine(data.StockName+ "\t\t" +data.NumberOFShare+ "\t\t" +data.SharePrice+ "\t\t" +(data.NumberOFShare* data.SharePrice));
            }
        }
    }
}
