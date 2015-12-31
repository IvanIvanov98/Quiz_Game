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
    public partial class Form49 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form50 frm50;
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
        public Form49()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form49_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Отборът с най-много титли от Лига Европа е?";
                    button1.Text = "Аякс";
                    button2.Text = "Севилия"; // Верният Отговор
                    button3.Text = "Атл. Мадрид";
                    button4.Text = "Челси"; 
                }
                if (q1 == 2)
                {
                    button5.Text = "С каква националност е Луис Суарес?";
                    button1.Text = "Панамска"; 
                    button2.Text = "Бразилска";
                    button3.Text = "Аржентинска";
                    button4.Text = "Уругвайска"; // Верният Отговор
                }
                if (q1 == 3)
                {
                    button5.Text = "В кой отбор започва проф. кариера на Бекъм?";
                    button1.Text = "Ман Ю"; // Верният отговор
                    button2.Text = "Реал Мадрид";
                    button3.Text = "ПСЖ";
                    button4.Text = "Милан"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Отборът с най-много титли от Лига Европа е?")
            {

                player.Play();

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct;
                frm50.Show();
                Hide();

            }
            if (button5.Text == "С каква националност е Луис Суарес?")
            {
                player.Play();   

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct;
                frm50.Show();
                Hide();
            }
            if (button5.Text == "В кой отбор започва проф. кариера на Бекъм?")
            {

                player1.Play();   //Верен отговор

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct + 1;
                frm50.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Отборът с най-много титли от Лига Европа е?")
            {

                player1.Play();   //Верен отговор

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct + 1;
                frm50.Show();
                Hide();

            }
            if (button5.Text == "С каква националност е Луис Суарес?")
            {
                player.Play();   

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct;
                frm50.Show();
                Hide();
            }
            if (button5.Text == "В кой отбор започва проф. кариера на Бекъм?")
            {

                player.Play();

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct;
                frm50.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Отборът с най-много титли от Лига Европа е?")
            {

                player.Play();

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct;
                frm50.Show();
                Hide();

            }
            if (button5.Text == "С каква националност е Луис Суарес?")
            {
                player.Play(); 

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct;
                frm50.Show();
                Hide();
            }
            if (button5.Text == "В кой отбор започва проф. кариера на Бекъм?")
            {

                player.Play();

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct;
                frm50.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Отборът с най-много титли от Лига Европа е?")
            {

                player.Play();

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct;
                frm50.Show();
                Hide();

            }
            if (button5.Text == "С каква националност е Луис Суарес?")
            {
                player1.Play();   //Верен отговор

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct  + 1;
                frm50.Show();
                Hide();
            }
            if (button5.Text == "В кой отбор започва проф. кариера на Бекъм?")
            {

                player.Play();

                
                frm50 = new Form50();
                frm50.passTime1 = Time1;
                frm50.passTime2 = Time2;
                frm50.passTime3 = Time3;
                frm50.passTime4 = Time4;
                frm50.passTime5 = a;
                frm50.passCorrect = Correct;
                frm50.Show();
                Hide();
            }
        }
    }
}
