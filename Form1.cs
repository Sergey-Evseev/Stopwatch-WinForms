using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_WinForms
{
    public partial class Form1 : Form
    {
        int m, s, ms; //переменные минут, секунд, миллисекудн

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            
            timer1.Interval = 500;
            m = 0; //обновление показателей
            s = 0;
            ms = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
