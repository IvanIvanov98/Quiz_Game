using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game
{
    public partial class Form39 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        
        private Form40 frm40;
        int a = 0;
        private int Time1;
        public int passTime1
        {
            get
            {
                return Time1;
            }
            set
            {
                Time1 = value;
            }
        }
        private int Time2;
        public int passTime2
        {
            get
            {
                return Time2;
            }
            set
            {
                Time2 = value;
            }
        }
        private int Time3;
        public int passTime3
        {
            get
            {
                return Time3;
            }
            set
            {
                Time3 = value;
            }
        }
        private int Time4;
        public int passTime4
        {
            get
            {
                return Time4;
            }
            set
            {
                Time4 = value;
            }
        }
        private int Correct;
        public int passCorrect
        {
            get
            {
                return Correct;
            }
            set
            {
                Correct = value;
            }
        }
        public Form39()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form39_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Кое от следните е бойно изкуство?";
                    button1.Text = "Тенис на маса";
                    button2.Text = "Тенис на корт";
                    button3.Text = "Хандбал";
                    button4.Text = "Джудо"; // Верният Отговор
                }
                if (q1 == 2)
                {
                    button5.Text = "Кой спорт в света е считан за най-популярен?";
                    button1.Text = "Баскетбол"; 
                    button2.Text = "Ръгбу";
                    button3.Text = "Футбол"; // Верният Отговор
                    button4.Text = "Бокс";
                }
                if (q1 == 3)
                {
                    button5.Text = "Боксът е силно развит в?";
                    button1.Text = "Пакистан";
                    button2.Text = "Хаити";
                    button3.Text = "Ватикана";
                    button4.Text = "Америка";  // Верният отговор
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое от следните е бойно изкуство?")
            {
                player1.Play();   //Верен отговор

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct + 1;
                frm40.Show();
                Hide();

            }
            if (button5.Text == "Кой спорт в света е считан за най-популярен?")
            {
                player.Play();

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct;
                frm40.Show();
                Hide();
            }
            if (button5.Text == "Боксът е силно развит в?")
            {
                player1.Play();   //Верен отговор

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct + 1;
                frm40.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое от следните е бойно изкуство?")
            {
                player.Play();

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct;
                frm40.Show();
                Hide();

            }
            if (button5.Text == "Кой спорт в света е считан за най-популярен?")
            {
                player1.Play();   //Верен отговор
               
                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct + 1;
                frm40.Show();
                Hide();
            }
            if (button5.Text == "Боксът е силно развит в?")
            {
                player.Play();
                

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct;
                frm40.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое от следните е бойно изкуство?")
            {
                player.Play();

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct;
                frm40.Show();
                Hide();

            }
            if (button5.Text == "Кой спорт в света е считан за най-популярен?")
            {
                player.Play();

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct;
                frm40.Show();
                Hide();
            }
            if (button5.Text == "Боксът е силно развит в?")
            {
                player.Play();

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct;
                frm40.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое от следните е бойно изкуство?")
            {
                player.Play();

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct;
                frm40.Show();
                Hide();

            }
            if (button5.Text == "Кой спорт в света е считан за най-популярен?")
            {
                player.Play();

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct;
                frm40.Show();
                Hide();
            }
            if (button5.Text == "Боксът е силно развит в?")
            {
                player.Play();

                
                frm40 = new Form40();
                frm40.passTime1 = Time1;
                frm40.passTime2 = Time2;
                frm40.passTime3 = Time3;
                frm40.passTime4 = Time4;
                frm40.passTime5 = a;
                frm40.passCorrect = Correct;
                frm40.Show();
                Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
