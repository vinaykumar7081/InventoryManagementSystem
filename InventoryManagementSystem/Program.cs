using System;
using InventoryManagementSystem.InventoryManagement;
using InventoryManagementSystem.InventoryDataManupulation;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome In The Inventory Management");
        const string INVENTORY_PATH = @"D:\InventoryManagementProblemStatement\InventoryManagementSystem\InventoryManagementSystem\InventoryManagement\Inventory.json";
        InventoryData inventoryData = new InventoryData();
        InventoryManupulate inventoryManupulate = new InventoryManupulate();
        Console.WriteLine("Display 1\n Add Data in the Inventory 2\n Editing the Data 3\n ");
        bool check = true;
        while (check)
        {
            Console.WriteLine("Enter the Above Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                   inventoryData.DisplayInventoryData(INVENTORY_PATH);
                    break;
                case 2:
                    Console.WriteLine(" Enter the Adding data\n Inventory ListName\n File Path");
                    string inventory_Name=Console.ReadLine();
                    InventoryData data=new InventoryData();
                    inventoryManupulate.AddInventory(data, inventory_Name,INVENTORY_PATH);
                    break;
                case 3:
                    Console.WriteLine("Enter the InventoryName List \n Grain Name\n FilePath");
                    string inventoryName=Console.ReadLine();
                    string grain_NAme=Console.ReadLine();
                    inventoryManupulate.EditInventory(inventoryName, grain_NAme, INVENTORY_PATH);
                    break;

                case 0:
                    check = false;
                    break;
            }
        }
    }
}