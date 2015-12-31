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
    public partial class Form87 : Form
    {

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form88 frm88;
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
        public Form87()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form87_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кои бактерии са разположени по единично?";
                button1.Text = "Стрептококи";
                button2.Text = "Сарцини";
                button3.Text = "Диплококи";
                button4.Text = "Микрококи"; // Верният Отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Всички специализирани клетки се образъват от?";
                button1.Text = "Склеренхимна тъкан";
                button2.Text = "Меристемна тъкан"; // Верният Отговор
                button3.Text = "Епидермиса";
                button4.Text = "Аеренхимна тъкан";
            }
            if (q1 == 3)
            {

                button5.Text = "Кой описва в детайли ендосимбионтната теория?";
                button1.Text = "Робърт Хук"; 
                button2.Text = "Крик";
                button3.Text = "Лин Маргулис"; // Верният отговор
                button4.Text = "Вирхов";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои бактерии са разположени по единично?")
            {
                player.Play();


                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct;
                frm88.Show();
                Hide();

            }
            if (button5.Text == "Всички специализирани клетки се образъват от?")
            {
                player.Play();

                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct;
                frm88.Show();
                Hide();
            }
            if (button5.Text == "Кой описва в детайли ендосимбионтната теория?")
            {
                player.Play();

                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct;

                frm88.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои бактерии са разположени по единично?")
            {
                player.Play();


              
                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct;
                frm88.Show();
                Hide();

            }
            if (button5.Text == "Всички специализирани клетки се образъват от?")
            {
                player1.Play();

                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct + 1;
                frm88.Show();
                Hide();
            }
            if (button5.Text == "Кой описва в детайли ендосимбионтната теория?")
            {
                player.Play();

                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct;
                frm88.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои бактерии са разположени по единично?")
            {
                player.Play();


                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct;
                frm88.Show();
                Hide();

            }
            if (button5.Text == "Всички специализирани клетки се образъват от?")
            {
                player.Play();

                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct;
                frm88.Show();
                Hide();
            }
            if (button5.Text == "Кой описва в детайли ендосимбионтната теория?")
            {
                player1.Play();

                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct + 1;
                frm88.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои бактерии са разположени по единично?")
            {
                player1.Play();


                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct + 1;
                frm88.Show();
                Hide();

            }
            if (button5.Text == "Всички специализирани клетки се образъват от?")
            {
                player.Play();

                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct;
                frm88.Show();
                Hide();
            }
            if (button5.Text == "Кой описва в детайли ендосимбионтната теория?")
            {
                player.Play();

                frm88 = new Form88();
                frm88.passTime1 = Time1;
                frm88.passTime2 = Time2;
                frm88.passTime3 = a;
                frm88.passCorrect = Correct;
                frm88.Show();
                Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
