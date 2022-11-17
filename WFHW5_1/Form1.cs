using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW5_1
{
    public partial class Form1 : Form
    {
        //Разработайте программу, которая позволяет пользователю осуществлять поиск файлов по заданному критерию. Приложение состоит из двух форм – главное окно и окно поиска. Пользователь может
        //открыть сколько угодно окон для поиска.Окно поиска запускается немодально.В окне поиска пользователь выбирает папку, в которой
        //будет идти поиск и вводит маску поиска, например «*.doc». Найденные файлы отображаются в списке.
                Form2 form2 = null;
        public Form1()
        {
            InitializeComponent();
            btSearch.Click += Search_Click;
        }
        
        private void Search_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
