﻿using System;
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
    public partial class Form51 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form52 frm52;
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
        private int Time5;
        public int passTime5
        {
            get
            {
                return Time5;
            }
            set
            {
                Time5 = value;
            }
        }
        private int Time6;
        public int passTime6
        {
            get
            {
                return Time6;
            }
            set
            {
                Time6 = value;
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
        public Form51()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form51_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Какъв е световният рекорд на 100м?";
                    button1.Text = "10.02сек";
                    button2.Text = "8,90сек";
                    button3.Text = "9,58сек"; // Верният Отговор
                    button4.Text = "10.11сек"; 
                }
                if (q1 == 2)
                {
              
                    button5.Text = "Първият отбор в който играе Леброн Джеймс е?";
                    button1.Text = "Маями Хийт";
                    button2.Text = "Кливланд Кавалиърс"; // Верният Отговор
                    button3.Text = "Чикаго Булс";
                    button4.Text = "Торонто Раптърс";
                }
                if (q1 == 3)
                {
                    button5.Text = "В кой отбор играе баскетболистът Коби Брайънт?";
                    button1.Text = "ЛА Лейкърс"; // Верният отговор
                    button2.Text = "Кливланд Кавалиърс";
                    button3.Text = "ЛА Клипърс";
                    button4.Text = "Юта Джаз"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв е световният рекорд на 100м?")
            {

                player1.Play(); // Верният отговор

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct + 1;
                frm52.Show();
                Hide();

            }
            if (button5.Text == "Първият отбор в който играе Леброн Джеймс е?")
            {
                player.Play();   

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct;
                frm52.Show();
                Hide();
            }
            if (button5.Text == "В кой отбор играе баскетболистът Коби Брайънт?")
            {

                player.Play();

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct;
                frm52.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв е световният рекорд на 100м?")
            {

                player.Play();

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct;
                frm52.Show();
                Hide();

            }
            if (button5.Text == "Първият отбор в който играе Леброн Джеймс е?")
            {
                player1.Play();   // Верен отговор

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct + 1;
                frm52.Show();
                Hide();
            }
            if (button5.Text == "В кой отбор играе баскетболистът Коби Брайънт?")
            {

                player.Play();

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct;
                frm52.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв е световният рекорд на 100м?")
            {

                player1.Play();   //Верен отговор

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct + 1;
                frm52.Show();
                Hide();

            }
            if (button5.Text == "Първият отбор в който играе Леброн Джеймс е?")
            {
                player.Play();  

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct;
                frm52.Show();
                Hide();
            }
            if (button5.Text == "В кой отбор играе баскетболистът Коби Брайънт?")
            {

                player.Play();

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct;
                frm52.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв е световният рекорд на 100м?")
            {

                player.Play();

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct;
                frm52.Show();
                Hide();

            }
            if (button5.Text == "Първият отбор в който играе Леброн Джеймс е?")
            {
                player.Play();  

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct;
                frm52.Show();
                Hide();
            }
            if (button5.Text == "В кой отбор играе баскетболистът Коби Брайънт?")
            {

                player.Play();

                
                frm52 = new Form52();
                frm52.passTime1 = Time1;
                frm52.passTime2 = Time2;
                frm52.passTime3 = Time3;
                frm52.passTime4 = Time4;
                frm52.passTime5 = Time5;
                frm52.passTime6 = Time6;
                frm52.passTime7 = a;
                frm52.passCorrect = Correct;
                frm52.Show();
                Hide();
            }
        }
    }
}
