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
    public partial class Form127 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form128 frm128;
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
        public Form127()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form127_Load(object sender, EventArgs e)
        {

            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Коя страна става осн. кредитор след ПСВ";
                button1.Text = "САЩ"; // Верният отговор
                button2.Text = "Англия";
                button3.Text = "Франция";
                button4.Text = "Китай";
            }
            if (q1 == 2)
            {
                button5.Text = "Причина за началото на ПСВ е конфл. м/у?";
                button1.Text = "Австро - унгария и Сърбия"; // Верният Отговор
                button2.Text = "Германия и Сърбия";
                button3.Text = "Б-ия и Сърбия";
                button4.Text = "Германия и Англия";  
            }
            if (q1 == 3)
            {
                button5.Text = "Коя от страните капитулира по време на ПСВ?";
                button1.Text = "Англия";
                button2.Text = "Франция"; 
                button3.Text = "Русия"; // Верният отговор
                button4.Text = "Италия";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя страна става осн. кредитор след ПСВ")
            {
                player1.Play();


                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct + 1;
                frm128.Show();
                Hide();

            }
            if (button5.Text == "Причина за началото на ПСВ е конфл. м/у?")
            {
                player1.Play();

                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct + 1;
                frm128.Show();
                Hide();
            }
            if (button5.Text == "Коя от страните капитулира по време на ПСВ?")
            {
                player.Play();

                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct;
                frm128.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя страна става осн. кредитор след ПСВ")
            {
                player1.Play();


                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct + 1;
                frm128.Show();
                Hide();

            }
            if (button5.Text == "Причина за началото на ПСВ е конфл. м/у?")
            {
                player.Play();

                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct;
                frm128.Show();
                Hide();
            }
            if (button5.Text == "Коя от страните капитулира по време на ПСВ?")
            {
                player.Play();

                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct;
                frm128.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя страна става осн. кредитор след ПСВ")
            {
                player.Play();


                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct;
                frm128.Show();
                Hide();

            }
            if (button5.Text == "Причина за началото на ПСВ е конфл. м/у?")
            {
                player.Play();

                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct;
                frm128.Show();
                Hide();
            }
            if (button5.Text == "Коя от страните капитулира по време на ПСВ?")
            {
                player1.Play();

                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct + 1;
                frm128.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя страна става осн. кредитор след ПСВ")
            {
                player.Play();


                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct;
                frm128.Show();
                Hide();

            }
            if (button5.Text == "Причина за началото на ПСВ е конфл. м/у?")
            {
                player.Play();

                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct;
                frm128.Show();
                Hide();
            }
            if (button5.Text == "Коя от страните капитулира по време на ПСВ?")
            {
                player.Play();

                frm128 = new Form128();
                frm128.passTime1 = Time1;
                frm128.passTime2 = Time2;
                frm128.passTime3 = a;
                frm128.passCorrect = Correct;
                frm128.Show();
                Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }
    }
}
