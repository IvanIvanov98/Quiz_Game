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
    public partial class Form83 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form84 frm84;
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
        private int Time7;
        public int passTime7
        {
            get
            {
                return Time7;
            }
            set
            {
                Time7 = value;
            }
        }
        private int Time8;
        public int passTime8
        {
            get
            {
                return Time8;
            }
            set
            {
                Time8 = value;
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
        public Form83()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form83_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Едно дърво и организмите в него образуват?";
                button1.Text = "Популация";
                button2.Text = "Биоценозата"; // Верният Отговор
                button3.Text = "Организма";
                button4.Text = "Екосистемата";
            }
            if (q1 == 2)
            {
                button5.Text = "Най разпространени хим.ел.в жив.организми?";
                button1.Text = " P и S";
                button2.Text = "Mn и Co";
                button3.Text = "Cu, Zn и F";
                button4.Text = "C, H, O и N"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Нуклеотидите са мономери на?";
                button1.Text = "Белтъците"; 
                button2.Text = "Дизахаридите";
                button3.Text = "Полизахаридите";
                button4.Text = "Нуклеиновите к-ни"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Едно дърво и организмите в него образуват?")
            {
                player.Play();


                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct;
                frm84.Show();
                Hide();

            }
            if (button5.Text == "Най разпространени хим.ел.в жив.организми?")
            {
                player.Play();

                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct;
                frm84.Show();
                Hide();
            }
            if (button5.Text == "Нуклеотидите са мономери на?")
            {
                player.Play();

                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct;
                frm84.Show();
                Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Едно дърво и организмите в него образуват?")
            {
                player1.Play();


                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct + 1;
                frm84.Show();
                Hide();

            }
            if (button5.Text == "Най разпространени хим.ел.в жив.организми?")
            {
                player.Play();

                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct;
                frm84.Show();
                Hide();
            }
            if (button5.Text == "Нуклеотидите са мономери на?")
            {
                player.Play();

                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct;
                frm84.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Едно дърво и организмите в него образуват?")
            {
                player.Play();


                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct;
                frm84.Show();
                Hide();

            }
            if (button5.Text == "Най разпространени хим.ел.в жив.организми?")
            {
                player.Play();

                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct;
                frm84.Show();
                Hide();
            }
            if (button5.Text == "Нуклеотидите са мономери на?")
            {
                player.Play();

                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct;
                frm84.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Едно дърво и организмите в него образуват?")
            {
                player.Play();


                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct;
                frm84.Show();
                Hide();

            }
            if (button5.Text == "Най разпространени хим.ел.в жив.организми?")
            {
                player1.Play();

                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct + 1;
                frm84.Show();
                Hide();
            }
            if (button5.Text == "Нуклеотидите са мономери на?")
            {
                player1.Play();

                frm84 = new Form84();
                frm84.passTime1 = Time1;
                frm84.passTime2 = Time2;
                frm84.passTime3 = Time3;
                frm84.passTime4 = Time4;
                frm84.passTime5 = Time5;
                frm84.passTime6 = Time6;
                frm84.passTime7 = Time7;
                frm84.passTime8 = Time8;
                frm84.passTime9 = a;
                frm84.passCorrect = Correct + 1;
                frm84.Show();
                Hide();
            }
        }
    }
}
    

