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
    public partial class Form129 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form130 frm130;
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
        public Form129()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form129_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Коя от страните не е била час от Оста?";
                button1.Text = "СССР"; // Верният отговор
                button2.Text = "Нациста Германия";
                button3.Text = "Япония";
                button4.Text = "Унгария";
            }
            if (q1 == 2)
            {

                button5.Text = "Колко са икономическите загуби от ПСВ?";
                button1.Text = "10мил долара";
                button2.Text = "100мил долара"; 
                button3.Text = "360млр долара"; // Верният Отговор
                button4.Text = "30млр долара";
            }
            if (q1 == 3)
            {

                button5.Text = "Коя страна повишава богатство си в хода на ПСВ?";
                button1.Text = "САЩ"; // Верният отговор
                button2.Text = "Франция";
                button3.Text = "Германия";
                button4.Text = "Русия"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от страните не е била час от Оста?")
            {
                player1.Play();


                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct + 1;
                frm130.Show();
                Hide();

            }
            if (button5.Text == "Колко са икономическите загуби от ПСВ?")
            {
                player.Play();

                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct;
                frm130.Show();
                Hide();
            }
            if (button5.Text == "Коя страна повишава богатство си в хода на ПСВ?")
            {
                player1.Play();

                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct + 1;
                frm130.Show();
                Hide();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от страните не е била час от Оста?")
            {
                player.Play();


                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct;
                frm130.Show();
                Hide();

            }
            if (button5.Text == "Колко са икономическите загуби от ПСВ?")
            {
                player.Play();

                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct;
                frm130.Show();
                Hide();
            }
            if (button5.Text == "Коя страна повишава богатство си в хода на ПСВ?")
            {
                player.Play();

                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct;
                frm130.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от страните не е била час от Оста?")
            {
                player.Play();


                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct;
                frm130.Show();
                Hide();

            }
            if (button5.Text == "Колко са икономическите загуби от ПСВ?")
            {
                player1.Play();

                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct + 1;
                frm130.Show();
                Hide();
            }
            if (button5.Text == "Коя страна повишава богатство си в хода на ПСВ?")
            {
                player.Play();

                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct;
                frm130.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от страните не е била час от Оста?")
            {
                player.Play();


                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct;
                frm130.Show();
                Hide();

            }
            if (button5.Text == "Колко са икономическите загуби от ПСВ?")
            {
                player.Play();

                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct;
                frm130.Show();
                Hide();
            }
            if (button5.Text == "Коя страна повишава богатство си в хода на ПСВ?")
            {
                player.Play();

                frm130 = new Form130();
                frm130.passTime1 = Time1;
                frm130.passTime2 = Time2;
                frm130.passTime3 = Time3;
                frm130.passTime4 = Time4;
                frm130.passTime5 = a;
                frm130.passCorrect = Correct;
                frm130.Show();
                Hide();
            }
        }
    }
}
