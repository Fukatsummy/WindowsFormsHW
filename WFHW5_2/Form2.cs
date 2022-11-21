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
    public partial class Form2 : Form
    {
        Product product;
        bool addnew = true;
        public Form2()
        {
            InitializeComponent();
            this.product = product;
            this.addnew = addnew;
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
