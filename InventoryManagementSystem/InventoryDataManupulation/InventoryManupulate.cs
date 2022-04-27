using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.InventoryManagement;

namespace InventoryManagementSystem.InventoryDataManupulation
{
    public class InventoryManupulate
    {
        InventoryData inventory =new InventoryData();
        InventoryFactory factory=new InventoryFactory();
        List<InventoryData> riceList = new List<InventoryData>();
        List<InventoryData> pulsesList=new List<InventoryData>();
        List<InventoryData> wheatList = new List<InventoryData>();
        public void ReadData(string filePath)
        {
            InventoryFields field = factory.ReadJson(filePath);
            this.riceList = field.RiceList;
            this.pulsesList = field.PulsesList;
            this.wheatList = field.WheatList;
        }
        public void AddInventory(InventoryData data,string inventoryName ,string filePath)
        {
             if (inventoryName.Equals("RiceList"))
             {
                 riceList.Add(data);
             }
            if (inventoryName.Equals("PulsesList"))
            {
                pulsesList.Add(data);
            }
            if (inventoryName.Equals("WheatList"))
            {
                wheatList.Add(data);
            }
            SaveInventory(filePath);
            
        }
        public void SaveInventory(string filePath)
        { 
        InventoryFields fields=new InventoryFields();
            fields.RiceList = riceList;
            fields.PulsesList = pulsesList;
            fields.WheatList = wheatList;
            factory.WriteToJson(filePath, fields);
           inventory.DisplayInventoryData(filePath);
        }
        public void EditInventory(Inventory data1, string inventoryName, string filePath)
        {
            ReadData(filePath);
            Inventory inventory = new Inventory();
            if (inventoryName.Equals("Rice"))
            {
                foreach (InventoryData data in riceList)
                {
                    if (data.Equals(data1))
                    { 
                    Console.WriteLine("Enter the Option to edit the Code");
                        int option=Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                inventory.Name=Console.ReadLine();
                                break;
                            case 2:
                                inventory.Price =Convert.ToDecimal (Console.ReadLine());
                                break;
                            case 3:
                                inventory.Weight = Convert.ToDecimal(Console.ReadLine());
                                break;
                        }
                    }
                }
            }

            if (inventoryName.Equals("Pulses"))
            {
                foreach (InventoryData data in pulsesList)
                {
                    if (data.Equals(data1))
                    {
                        Console.WriteLine("Enter the Option to edit the Code");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                inventory.Name = Console.ReadLine();
                                break;
                            case 2:
                                inventory.Price = Convert.ToDecimal(Console.ReadLine());
                                break;
                            case 3:
                                inventory.Weight = Convert.ToDecimal(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (inventoryName.Equals("Wheat"))
            {
                foreach (InventoryData data in wheatList)
                {
                    if (data.Equals(data1))
                    {
                        Console.WriteLine("Enter the Option to edit the Code");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                inventory.Name = Console.ReadLine();
                                break;
                            case 2:
                                inventory.Price = Convert.ToDecimal(Console.ReadLine());
                                break;
                            case 3:
                                inventory.Weight = Convert.ToDecimal(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            SaveInventory(filePath);
        }   
    }
}
