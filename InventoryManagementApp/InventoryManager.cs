using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp
{
    class InventoryManager
    {
        private List<InventoryItem> inventory;


        public InventoryManager()
        {
            inventory = new List<InventoryItem>();
        }

        public InventoryItem GetInventoryItem(int index)
        {
            return inventory[index];
        }

        public void addItem(InventoryItem item)
        {
            inventory.Add(item);
        }

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

        public int Size()
        {
            return inventory.Count;
        }

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

        public void Sort()
        {
            inventory.Sort();
        }


    }
}
