using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW5_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SearchF2.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBF2.Text == "")
                {
                    MessageBox.Show("Какой формат ищем?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    string[] list = Directory.GetFiles(folder.SelectedPath, TBF2.Text, SearchOption.AllDirectories);
                    listBox1.Items.Clear();
                    if (list.Length != 0)
                    {
                        foreach (var item in list)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                    else MessageBox.Show($"Файл не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//для отображения списка элементов
        {

        }
    }
}
   