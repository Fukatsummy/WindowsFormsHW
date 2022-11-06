using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Вывести на экран свое(краткое!!!) резюме с помощью последовательности MessageBox’ов(числом не менее трех). Причем на заголовке
//последнего должно отобразиться среднее число символов на странице (общее количество символов в резюме / количество MessageBox’ов).
namespace WFHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] arr = { "Студент: Лукьянчикова Анастасия", "Предмет: Windows Forms", "Группа: ПВ-111" };
            int element = 0;
            string caption;

            for (int i = 0; i < arr.Length; i++)
            {
                element += arr[i].Length;
                caption = (arr.Length - 1 == i) ? $"MessageBox {i + 1}. Среднее число символов - {element / arr.Length}" : $"MessageBox {i + 1}";
                MessageBox.Show(arr[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
