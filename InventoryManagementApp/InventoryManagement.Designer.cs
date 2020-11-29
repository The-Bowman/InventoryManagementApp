
namespace InventoryManagementApp
{
    partial class InventoryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchByNameLabel = new System.Windows.Forms.Label();
            this.searchByPriceButton = new System.Windows.Forms.Button();
            this.searchPriceTextBox = new System.Windows.Forms.TextBox();
            this.searchByPriceLabel = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.searchDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.searchItemNumOutputLabel = new System.Windows.Forms.Label();
            this.searchStockOutputLabel = new System.Windows.Forms.Label();
            this.searchPriceOutputLabel = new System.Windows.Forms.Label();
            this.searchDescrOutputLabel = new System.Windows.Forms.Label();
            this.searchNameOutputLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addCountTextBox = new System.Windows.Forms.TextBox();
            this.addItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.enterCountLabel = new System.Windows.Forms.Label();
            this.enterPriceLabel = new System.Windows.Forms.Label();
            this.addItemDescrTextBox = new System.Windows.Forms.TextBox();
            this.enterDescrLabel = new System.Windows.Forms.Label();
            this.addItemNameTextBox = new System.Windows.Forms.TextBox();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.searchDisplayGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.Location = new System.Drawing.Point(295, 359);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(75, 23);
            this.searchByNameButton.TabIndex = 1;
            this.searchByNameButton.Text = "Search";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            this.searchByNameButton.Click += new System.EventHandler(this.searchByNameButton_Click);
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(189, 361);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchNameTextBox.TabIndex = 2;
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.AutoSize = true;
            this.searchByNameLabel.Location = new System.Drawing.Point(70, 364);
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(113, 13);
            this.searchByNameLabel.TabIndex = 3;
            this.searchByNameLabel.Text = "Search By Item Name:";
            // 
            // searchByPriceButton
            // 
            this.searchByPriceButton.Location = new System.Drawing.Point(295, 388);
            this.searchByPriceButton.Name = "searchByPriceButton";
            this.searchByPriceButton.Size = new System.Drawing.Size(75, 23);
            this.searchByPriceButton.TabIndex = 4;
            this.searchByPriceButton.Text = "Search";
            this.searchByPriceButton.UseVisualStyleBackColor = true;
            this.searchByPriceButton.Click += new System.EventHandler(this.searchByPriceButton_Click);
            // 
            // searchPriceTextBox
            // 
            this.searchPriceTextBox.Location = new System.Drawing.Point(189, 390);
            this.searchPriceTextBox.Name = "searchPriceTextBox";
            this.searchPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchPriceTextBox.TabIndex = 5;
            // 
            // searchByPriceLabel
            // 
            this.searchByPriceLabel.AutoSize = true;
            this.searchByPriceLabel.Location = new System.Drawing.Point(74, 393);
            this.searchByPriceLabel.Name = "searchByPriceLabel";
            this.searchByPriceLabel.Size = new System.Drawing.Size(109, 13);
            this.searchByPriceLabel.TabIndex = 6;
            this.searchByPriceLabel.Text = "Search By Item Price:";
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(474, 318);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(135, 23);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "Sort Alphabetically";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // searchDisplayGroupBox
            // 
            this.searchDisplayGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchDisplayGroupBox.Controls.Add(this.searchItemNumOutputLabel);
            this.searchDisplayGroupBox.Controls.Add(this.searchStockOutputLabel);
            this.searchDisplayGroupBox.Controls.Add(this.searchPriceOutputLabel);
            this.searchDisplayGroupBox.Controls.Add(this.searchDescrOutputLabel);
            this.searchDisplayGroupBox.Controls.Add(this.searchNameOutputLabel);
            this.searchDisplayGroupBox.Location = new System.Drawing.Point(77, 150);
            this.searchDisplayGroupBox.Name = "searchDisplayGroupBox";
            this.searchDisplayGroupBox.Size = new System.Drawing.Size(293, 147);
            this.searchDisplayGroupBox.TabIndex = 8;
            this.searchDisplayGroupBox.TabStop = false;
            this.searchDisplayGroupBox.Text = "Search Results";
            // 
            // searchItemNumOutputLabel
            // 
            this.searchItemNumOutputLabel.AutoSize = true;
            this.searchItemNumOutputLabel.Location = new System.Drawing.Point(27, 67);
            this.searchItemNumOutputLabel.Name = "searchItemNumOutputLabel";
            this.searchItemNumOutputLabel.Size = new System.Drawing.Size(64, 13);
            this.searchItemNumOutputLabel.TabIndex = 4;
            this.searchItemNumOutputLabel.Text = "item number";
            // 
            // searchStockOutputLabel
            // 
            this.searchStockOutputLabel.AutoSize = true;
            this.searchStockOutputLabel.Location = new System.Drawing.Point(26, 111);
            this.searchStockOutputLabel.Name = "searchStockOutputLabel";
            this.searchStockOutputLabel.Size = new System.Drawing.Size(34, 13);
            this.searchStockOutputLabel.TabIndex = 3;
            this.searchStockOutputLabel.Text = "count";
            // 
            // searchPriceOutputLabel
            // 
            this.searchPriceOutputLabel.AutoSize = true;
            this.searchPriceOutputLabel.Location = new System.Drawing.Point(27, 89);
            this.searchPriceOutputLabel.Name = "searchPriceOutputLabel";
            this.searchPriceOutputLabel.Size = new System.Drawing.Size(30, 13);
            this.searchPriceOutputLabel.TabIndex = 2;
            this.searchPriceOutputLabel.Text = "price";
            // 
            // searchDescrOutputLabel
            // 
            this.searchDescrOutputLabel.AutoSize = true;
            this.searchDescrOutputLabel.Location = new System.Drawing.Point(26, 46);
            this.searchDescrOutputLabel.Name = "searchDescrOutputLabel";
            this.searchDescrOutputLabel.Size = new System.Drawing.Size(33, 13);
            this.searchDescrOutputLabel.TabIndex = 1;
            this.searchDescrOutputLabel.Text = "descr";
            // 
            // searchNameOutputLabel
            // 
            this.searchNameOutputLabel.AutoSize = true;
            this.searchNameOutputLabel.Location = new System.Drawing.Point(27, 24);
            this.searchNameOutputLabel.Name = "searchNameOutputLabel";
            this.searchNameOutputLabel.Size = new System.Drawing.Size(20, 13);
            this.searchNameOutputLabel.TabIndex = 0;
            this.searchNameOutputLabel.Text = "vis";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.addCountTextBox);
            this.groupBox1.Controls.Add(this.addItemPriceTextBox);
            this.groupBox1.Controls.Add(this.enterCountLabel);
            this.groupBox1.Controls.Add(this.enterPriceLabel);
            this.groupBox1.Controls.Add(this.addItemDescrTextBox);
            this.groupBox1.Controls.Add(this.enterDescrLabel);
            this.groupBox1.Controls.Add(this.addItemNameTextBox);
            this.groupBox1.Controls.Add(this.enterNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(77, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(443, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 55);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addCountTextBox
            // 
            this.addCountTextBox.Location = new System.Drawing.Point(299, 48);
            this.addCountTextBox.Name = "addCountTextBox";
            this.addCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.addCountTextBox.TabIndex = 7;
            // 
            // addItemPriceTextBox
            // 
            this.addItemPriceTextBox.Location = new System.Drawing.Point(299, 13);
            this.addItemPriceTextBox.Name = "addItemPriceTextBox";
            this.addItemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.addItemPriceTextBox.TabIndex = 6;
            // 
            // enterCountLabel
            // 
            this.enterCountLabel.AutoSize = true;
            this.enterCountLabel.Location = new System.Drawing.Point(224, 51);
            this.enterCountLabel.Name = "enterCountLabel";
            this.enterCountLabel.Size = new System.Drawing.Size(69, 13);
            this.enterCountLabel.TabIndex = 5;
            this.enterCountLabel.Text = "Stock Count:";
            // 
            // enterPriceLabel
            // 
            this.enterPriceLabel.AutoSize = true;
            this.enterPriceLabel.Location = new System.Drawing.Point(236, 16);
            this.enterPriceLabel.Name = "enterPriceLabel";
            this.enterPriceLabel.Size = new System.Drawing.Size(57, 13);
            this.enterPriceLabel.TabIndex = 4;
            this.enterPriceLabel.Text = "Item Price:";
            // 
            // addItemDescrTextBox
            // 
            this.addItemDescrTextBox.Location = new System.Drawing.Point(98, 48);
            this.addItemDescrTextBox.Name = "addItemDescrTextBox";
            this.addItemDescrTextBox.Size = new System.Drawing.Size(100, 20);
            this.addItemDescrTextBox.TabIndex = 3;
            // 
            // enterDescrLabel
            // 
            this.enterDescrLabel.AutoSize = true;
            this.enterDescrLabel.Location = new System.Drawing.Point(6, 51);
            this.enterDescrLabel.Name = "enterDescrLabel";
            this.enterDescrLabel.Size = new System.Drawing.Size(86, 13);
            this.enterDescrLabel.TabIndex = 2;
            this.enterDescrLabel.Text = "Item Description:";
            // 
            // addItemNameTextBox
            // 
            this.addItemNameTextBox.Location = new System.Drawing.Point(98, 13);
            this.addItemNameTextBox.Name = "addItemNameTextBox";
            this.addItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addItemNameTextBox.TabIndex = 1;
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Location = new System.Drawing.Point(31, 16);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(61, 13);
            this.enterNameLabel.TabIndex = 0;
            this.enterNameLabel.Text = "Item Name:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(474, 364);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 47);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(701, 150);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(701, 180);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(75, 23);
            this.restockButton.TabIndex = 12;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchDisplayGroupBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.searchByPriceLabel);
            this.Controls.Add(this.searchPriceTextBox);
            this.Controls.Add(this.searchByPriceButton);
            this.Controls.Add(this.searchByNameLabel);
            this.Controls.Add(this.searchNameTextBox);
            this.Controls.Add(this.searchByNameButton);
            this.Name = "InventoryManagement";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            this.searchDisplayGroupBox.ResumeLayout(false);
            this.searchDisplayGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Label searchByNameLabel;
        private System.Windows.Forms.Button searchByPriceButton;
        private System.Windows.Forms.TextBox searchPriceTextBox;
        private System.Windows.Forms.Label searchByPriceLabel;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.GroupBox searchDisplayGroupBox;
        private System.Windows.Forms.Label searchPriceOutputLabel;
        private System.Windows.Forms.Label searchDescrOutputLabel;
        private System.Windows.Forms.Label searchNameOutputLabel;
        private System.Windows.Forms.Label searchStockOutputLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addCountTextBox;
        private System.Windows.Forms.TextBox addItemPriceTextBox;
        private System.Windows.Forms.Label enterCountLabel;
        private System.Windows.Forms.Label enterPriceLabel;
        private System.Windows.Forms.TextBox addItemDescrTextBox;
        private System.Windows.Forms.Label enterDescrLabel;
        private System.Windows.Forms.TextBox addItemNameTextBox;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label searchItemNumOutputLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button restockButton;
    }
}

