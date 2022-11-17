namespace WFHW5_2
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1PriceProduct = new System.Windows.Forms.Label();
            this.label1allProduct = new System.Windows.Forms.Label();
            this.AllPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 21);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавть товар";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(21, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 21);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Внести изменения";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(21, 82);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(144, 21);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "Добавить в список";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.button3_Click);
            // 
            // listProducts
            // 
            this.listProducts.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listProducts.ColumnWidth = 290;
            this.listProducts.FormattingEnabled = true;
            this.listProducts.IntegralHeight = false;
            this.listProducts.Location = new System.Drawing.Point(0, 0);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(317, 290);
            this.listProducts.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Price
            // 
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Location = new System.Drawing.Point(344, 28);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(114, 13);
            this.Price.TabIndex = 5;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(323, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 98);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что нужно сделать?";
            // 
            // label1PriceProduct
            // 
            this.label1PriceProduct.AutoSize = true;
            this.label1PriceProduct.Location = new System.Drawing.Point(354, 9);
            this.label1PriceProduct.Name = "label1PriceProduct";
            this.label1PriceProduct.Size = new System.Drawing.Size(125, 13);
            this.label1PriceProduct.TabIndex = 7;
            this.label1PriceProduct.Text = "Цена товаров в списке";
            this.label1PriceProduct.Visible = false;
            // 
            // label1allProduct
            // 
            this.label1allProduct.AutoSize = true;
            this.label1allProduct.Location = new System.Drawing.Point(354, 22);
            this.label1allProduct.Name = "label1allProduct";
            this.label1allProduct.Size = new System.Drawing.Size(118, 13);
            this.label1allProduct.TabIndex = 10;
            this.label1allProduct.Text = "Товаров в списке нет";
            // 
            // AllPrice
            // 
            this.AllPrice.AutoSize = true;
            this.AllPrice.Location = new System.Drawing.Point(480, 32);
            this.AllPrice.Name = "AllPrice";
            this.AllPrice.Size = new System.Drawing.Size(27, 13);
            this.AllPrice.TabIndex = 11;
            this.AllPrice.Text = "pyб.";
            this.AllPrice.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 491);
            this.Controls.Add(this.AllPrice);
            this.Controls.Add(this.label1allProduct);
            this.Controls.Add(this.label1PriceProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продаж";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1PriceProduct;
        private System.Windows.Forms.Label label1allProduct;
        private System.Windows.Forms.Label AllPrice;
    }
}

