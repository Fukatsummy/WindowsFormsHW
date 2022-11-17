using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW5_2
{
    public partial class Form1 : Form
    {
        public double AllPrise { get; set; } = 0;
        List<Product> product = null;
        public Form1()
        {
            InitializeComponent();
            product = new List<Product>();
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            comboBox1.SelectedIndexChanged += ProductStock_SelectedIndexChanged;
            btnAddList.Click += BtnAddList_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void BtnAddList_Click(object sender, EventArgs e)
        {
            try
            {
                listProducts.Items.Add(((Product)comboBox1.Items[comboBox1.SelectedIndex]).ToString());
                AllPrise += ((Product)comboBox1.Items[comboBox1.SelectedIndex]).Price;
                if (listProducts.Items.Count > 0)
                {
                    label1allProduct.Visible = false;
                    label1PriceProduct.Visible = true;
                    Price.Visible = true;
                    AllPrice.Visible = true;
                }
                Price.Text = AllPrise.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали товар!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
