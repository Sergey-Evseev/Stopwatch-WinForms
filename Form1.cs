using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        //по нажатию на первую кнопку
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) //если таймер работает 
            {                
                timer1.Enabled = false; //то выключить его
                button1.Text = "Пуск";  //проименовать первую кнопку в Пуск
                button2.Enabled = true; //сделать доступной кнопку Сброс
            }
            else //если таймер не работает 
            {
                timer1.Enabled = true; // то включить его
                button1.Text = "Стоп"; //проименовать первую кнопку в Стоп  
                button1.Enabled = true; //и сделать 1-ю кнопку доступной
                button2.Enabled = false; //кнопку Сброс сделать недоступной
            }
        }

        // при нажатии на кнопку Сброс
        private void button2_Click(object sender, EventArgs e)
        { //обнуляем значения всех разрядов времени
            m = 0;
            s = 0;
            ms = 0;
            label1.Text = "00"; //сбрасываем цифр. значения на обоих лейблах
            label2.Text = "00";

            button1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) //событие мигание таймера
        {
            if (label3.Visible) //если тикер виден
            {
                if (s < 59) //если количество секунд меньше 59                    
                {
                    s++; //то переменную секунд увеличить на 1
                    //при этом если секунд меньше 10, то вывести 0 и кол-во секунд приведенные к стрке
                    if (s < 10) label2.Text = "0" + s.ToString();
                    //* т.е. добавляем спереди 0
                    //если больше 10 то 2-й лейбл просто кол-во секунд к строке
                    else label2.Text = s.ToString();
                }
                else //если секунд больше 59
                {
                    if (m < 59) //если минут меньше 59
                    {
                        //то начинаем считать минуты
                        m++; //то кол-во минут увеличить на 1
                             //при этом если минут меньше 10, то 0 + строку кол-ва минут
                        if (m < 10) label1.Text = "0" + m.ToString();
                        //если больше 10 то просто количество минут (int к строке )
                        else label1.Text = m.ToString();

                        s = 0; //обнулить счетчик секунд
                        label2.Text = "00"; //установить на счетчике секунд нули
                    }
                    else //если минут больше 59
                    {
                        m = 0; //обнулить счетчик минут
                        label1.Text = "00"; //и установить нули на счетчике минут
                    }
                }
                label3.Visible = false; //после прохождения условия сделать тикер невидимым
            }
            else { label3.Visible = true; } //если тикер невидим, сделать его видимым
        }

        public Form1()
        {
            InitializeComponent();
            
            timer1.Interval = 500; //интервал обновления в милисекундах 
            m = 0; //обновление показателей
            s = 0;
            ms = 0;

            label1.Text = "00"; //прописываем в любом случае текст
            label2.Text = "00"; //несмотря на то что он есть на ярлыке
            label3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
