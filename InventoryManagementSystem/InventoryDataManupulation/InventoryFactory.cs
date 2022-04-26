using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.InventoryManagement;

namespace InventoryManagementSystem.InventoryDataManupulation
{
    public class InventoryFactory
    {
        public InventoryFields ReadJson(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            var inventory = JsonConvert.DeserializeObject<InventoryFields>(json);
            return inventory;
        }
        public void WriteToJson(string filePath, InventoryFields fields)
        { 
        var serializeJson=JsonConvert.SerializeObject(fields);
            File.WriteAllText(filePath, serializeJson);
        }
    }
}
