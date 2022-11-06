using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Разработать приложение «убегающий статик»:) Суть приложения:на форме расположен статический элемент управления(«статик»).
//Пользователь пытается подвести курсор мыши к «статику», и, если курсор находиться близко со статиком, элемент управления «убегает». Предусмотреть перемещение «статика» только в пределах формы.

// В моей программе СТАТИК убегает при нажатии на кпопку.
namespace WFHW1_2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, EventArgs e)
        {
            //Выходит за пределы консоли
            //button1.Location = new Point(rnd.Next(this.Width - button1.Width), rnd.Next(this.Height - button1.Height));
            // Не выходит за пределы окна консоли
            button1.Location = new Point(rnd.Next(this.ClientSize.Width - button1.Width), rnd.Next(this.ClientSize.Height - button1.Height));
        }
    }
}

