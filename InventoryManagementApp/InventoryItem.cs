using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp
{
    class InventoryItem : IComparable<InventoryItem>
    {

        private string name;
        private string itemDescr;
        private int itemNum;
        private double price;
        private int stock;

        //Constructor methods
        //No-args constructor gives default values to be defined by setters
        public InventoryItem()
        {
            name = "Unknown";
            itemDescr = "Unknown";
            itemNum = 999;
            price = 999.99;
        }

        //Initializes with values for all data points
        public InventoryItem(string name, string itemDescr, int itemNum, double price, int stock)
        {
            this.name = name;
            this.itemDescr = itemDescr;
            this.itemNum = itemNum;
            this.price = price;
            this.stock = stock;
        }

        public InventoryItem(InventoryItem item)
        {
            this.name = item.getItemName();
            this.itemDescr = item.getDescr();
            this.itemNum = item.getItemNum();
            this.price = item.getPrice();
            this.stock = item.getStock();
        }


        //getter and setter methods for variables
        public int getItemNum()
        {
            return itemNum;
        }

        public void setItemNum(int itemNum)
        {
            this.itemNum = itemNum;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public string getItemName()
        {
            return name;
        }

        public void setItemName(string name)
        {
            this.name = name;
        }

        public string getDescr()
        {
            return itemDescr;
        }

        public void setDescr(string itemDescr)
        {
            this.itemDescr = itemDescr;
        }

        public int getStock()
        {
            return stock;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }

        public static void printItem(InventoryItem item)
        {
            Console.Write("Item name: " + item.getItemName() + " || " + "Item description: " +
                item.getDescr() + " || " + " Item number: " + item.getItemNum() + " || " + "Price: $" + item.getPrice() +
                " || " + "Stock count: " + item.getStock());
            Console.WriteLine();
        }

        // converts item to string
        public static string ItemToString(InventoryItem item)
        {
            return item.getItemName() + "; " + item.getDescr() + "; " + item.getItemNum().ToString() + "; " 
                + item.getPrice().ToString() + "; " + item.getStock().ToString();
        }

        // compares item name for sort method
        public int CompareTo(InventoryItem item)
        {
            return this.name.CompareTo(item.name);
        }

        public int CompareByPrice(InventoryItem item)
        {
            return this.price.CompareTo(item.price);
        }
    }
}
