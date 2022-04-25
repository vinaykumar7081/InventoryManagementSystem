using System;
using InventoryManagementSystem.InventoryManagement;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome In The Inventory Management");
        const string INVENTORY_FILE_PATH = @"D:\InventoryManagementProblemStatement\InventoryManagementSystem\InventoryManagementSystem\InventoryManagement\Inventory.json";
        InventoryData inventoryData = new InventoryData();
        Console.WriteLine("Display 1\n");
        bool check = true;
        while (check)
        {
            Console.WriteLine("Enter the Above Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                   inventoryData.DisplayInventoryData(INVENTORY_FILE_PATH);
                    break;
                case 2:
                    check = false;
                    break;
            }
        }
    }
}