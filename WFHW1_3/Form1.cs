using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WFHW1_3
{
    //Написать программу, которая по введенной дате определяет день недели.Результат выводить в текстовое поле(желательно по-русски). 
    public partial class Form1 : Form
    {

        DateTime date = new DateTime();  //объект типа DateTime (dt) определяет день недели.
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            textBox1.Text = date.ToString("dddd", CultureInfo.GetCultureInfo("ru-ru"));
            //ToString позволяет указывать день недели полностью
            //CultureInfo включают имена языков и региональных параметров, систему письма, используемый календарь, порядок сортировки строк и форматы дат и чисел.
        }
    }
}

//   Для меня   ///
//https://learn.microsoft.com/ru-ru/dotnet/standard/base-types/custom-date-and-time-format-strings?redirectedfrom=MSDN
//https://learn.microsoft.com/ru-ru/dotnet/api/system.globalization?view=net-6.0