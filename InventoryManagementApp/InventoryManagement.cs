using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class InventoryManagement : Form
    {

        private InventoryItem currentItem;
        private InventoryManager inventory = new InventoryManager();
        ListBox itemsList = new ListBox();


        public InventoryManagement()
        {
            InitializeComponent();
        }
        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            itemsList.Location = new Point(400, 150);
            itemsList.Size = new Size(270, 150);
            itemsList.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(itemsList);

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            string name;
            string descr;
            int itemNum;
            double price;
            int count;

            name = addItemNameTextBox.Text;
            descr = addItemDescrTextBox.Text;
            if (!double.TryParse(addItemPriceTextBox.Text, out price))
            {
                MessageBox.Show("Price entered is not a number \nItem not added");
                return;
            } 
            
            if (!int.TryParse(addCountTextBox.Text, out count))
            {
                MessageBox.Show("Stock count entered is not a whole integer \nItem not added");
                return;
            }   
            
            itemNum = rand.Next(100000, 1000000);
            currentItem = new InventoryItem(name, descr, itemNum, price, count);
            inventory.addItem(currentItem);
            itemsList.Items.Add(InventoryItem.ItemToString(currentItem));
            itemsList.Update();         

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            itemsList.Items.Clear();
            inventory.Sort();
           
            for (int i = 0; i < inventory.Size(); i++)
            {
                itemsList.Items.Add(InventoryItem.ItemToString(inventory.GetInventoryItem(i)));
            }
            
        }

        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            currentItem = inventory.SearchByName(searchNameTextBox.Text);
            searchNameOutputLabel.Text = currentItem.getItemName();
            searchDescrOutputLabel.Text = currentItem.getDescr();
            searchItemNumOutputLabel.Text = currentItem.getItemNum().ToString();
            searchPriceOutputLabel.Text = currentItem.getPrice().ToString();
            searchStockOutputLabel.Text = currentItem.getStock().ToString();

        }

        private void searchByPriceButton_Click(object sender, EventArgs e)
        {
            double price;
            if (double.TryParse(searchPriceTextBox.Text, out price)) 
            {
                currentItem = inventory.SearchByPrice(price);
                searchNameOutputLabel.Text = currentItem.getItemName();
                searchDescrOutputLabel.Text = currentItem.getDescr();
                searchItemNumOutputLabel.Text = currentItem.getItemNum().ToString();
                searchPriceOutputLabel.Text = currentItem.getPrice().ToString();
                searchStockOutputLabel.Text = currentItem.getStock().ToString();
            }
            else
            {
                MessageBox.Show("Price entered is not valid");
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (itemsList.SelectedIndex == -1)
            {

                MessageBox.Show("No item selected");
                return;
            } else
            {
                currentItem = inventory.GetInventoryItem(itemsList.SelectedIndex);
                itemsList.Items.RemoveAt(itemsList.SelectedIndex);
                searchNameOutputLabel.Text = currentItem.getItemName();
                searchDescrOutputLabel.Text = currentItem.getDescr();
                searchItemNumOutputLabel.Text = currentItem.getItemNum().ToString();
                searchPriceOutputLabel.Text = currentItem.getPrice().ToString();
                searchStockOutputLabel.Text = currentItem.getStock().ToString();
                Console.WriteLine("\n");
                inventory.showAllItems();
                inventory.removeItem(currentItem.getItemName());
                Console.WriteLine("\n");
                inventory.showAllItems();
            }
            

        }
    }
}
