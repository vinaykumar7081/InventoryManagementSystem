using System;
using InventoryManagementSystem.InventoryManagement;
using InventoryManagementSystem.InventoryDataManupulation;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome In The Inventory Management");
        const string INVENTORY_PATH = @"D:\InventoryManagementProblemStatement\InventoryManagementSystem\InventoryManagementSystem\InventoryDataManupulation\InventoryObject.json";
        InventoryData inventoryData = new InventoryData();
        InventoryManupulate inventoryManupulate = new InventoryManupulate();
        Console.WriteLine("Display 1\n  Editing the Data 2\n ");
        bool check = true;
        while (check)
        {
            Console.WriteLine("Enter the Above Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    inventoryManupulate.ReadData(INVENTORY_PATH);
                    break;
                case 2:
                    Console.WriteLine("Enter the InventoryName List \n Grain Name\n FilePath");
                    string inventoryName = Console.ReadLine();
                    Inventory data1 = new Inventory();
                    data1.Name = Console.ReadLine();
                    data1.Weight = 40;
                    data1.Price = 75;
                    inventoryManupulate.EditInventory(data1, inventoryName, INVENTORY_PATH);
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}