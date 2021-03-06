﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp
{
    class InventoryManager
    {
        private List<InventoryItem> inventory;

        // constructors
        public InventoryManager()
        {
            inventory = new List<InventoryItem>();
        }

        // returns an inventory item at the specified index
        public InventoryItem GetInventoryItem(int index)
        {
            return inventory[index];
        }

        // adds item to inventory
        public void addItem(InventoryItem item)
        {
            inventory.Add(item);
        }

        // removes item from inventory
        public bool removeItem(string name)
        {
            bool success = false;
            foreach (InventoryItem item in inventory)
            {
                if (item.getItemName().Equals(name))
                {
                    inventory.Remove(item);
                    success = true;
                    break;
                }
            }
            return success;
        }

        // searches inventory for item by name
        public InventoryItem SearchByName(string name)
        {
            InventoryItem temp = new InventoryItem("Item not found", "Item not found", 0000, 0.00, 0);

            foreach (InventoryItem item in inventory)
            {
                if (item.getItemName().Equals(name))
                {
                    temp = item;
                }
            }
            return temp;
        }

        // searches inventory for item by price
        public InventoryItem SearchByPrice(double price)
        {
            InventoryItem temp = new InventoryItem("Item not found", "Item not found", 0000, 0.00, 0);

            foreach (InventoryItem item in inventory)
            {
                if (item.getPrice() == price)
                    temp = item;


            }

            return temp;
        }

        // restocks item specified by name
        public void RestockItem(string name)
        {
            foreach (InventoryItem item in inventory)
            {
                if (item.getItemName().Equals(name))
                {
                    item.setStock(item.getStock() + 5);
                    Console.WriteLine("Stock of item is: " + item.getStock());
                }


            }
        }

        // size of List
        public int Size()
        {
            return inventory.Count;
        }

        // prints all elements and fields to console
        public void showAllItems()
        {
            foreach (InventoryItem item in inventory)
            {
                Console.Write("Item name: " + item.getItemName() + " || ");
                Console.Write("Item description: " + item.getDescr() + " || ");
                Console.Write("Item number: " + item.getItemNum() + " || ");
                Console.Write("Item price: " + item.getPrice() + " || ");
                Console.Write("Stock count: " + item.getStock());
                Console.WriteLine();
            }
        }

        // sorts inventory alphabetically
        public void Sort()
        {
            inventory.Sort();
        }


    }
}
