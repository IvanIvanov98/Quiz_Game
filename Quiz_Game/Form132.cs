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
    public partial class Form132 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form133 frm133;
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
        public Form132()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form132_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Индивидуална и извънредна длъжност в древен Рим е:";
                button1.Text = "Диктатор"; // Верният отговор
                button2.Text = "Консул";
                button3.Text = "Едил";
                button4.Text = "Претор";
            }
            if (q1 == 2)
            {
                button5.Text = "Кога се създава българската екзархия?";
                button1.Text = "1835";
                button2.Text = "1824"; 
                button3.Text = "1862";
                button4.Text = "1870"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "През коя година е издаден „Рибен буквар“?";
                button1.Text = "1800";
                button2.Text = "1850";
                button3.Text = "1824"; // Верният отговор
                button4.Text = "1847"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Индивидуална и извънредна длъжност в древен Рим е:")
            {
                player1.Play();


                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct + 1;
                frm133.Show();
                Hide();

            }
            if (button5.Text == "Кога се създава българската екзархия?")
            {
                player.Play();

                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct;
                frm133.Show();
                Hide();
            }
            if (button5.Text == "През коя година е издаден „Рибен буквар“?")
            {
                player.Play();

                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct;
                frm133.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Индивидуална и извънредна длъжност в древен Рим е:")
            {
                player.Play();


                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct;
                frm133.Show();
                Hide();

            }
            if (button5.Text == "Кога се създава българската екзархия?")
            {
                player.Play();

                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct;
                frm133.Show();
                Hide();
            }
            if (button5.Text == "През коя година е издаден „Рибен буквар“?")
            {
                player.Play();

                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct;
                frm133.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Индивидуална и извънредна длъжност в древен Рим е:")
            {
                player.Play();


                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct;
                frm133.Show();
                Hide();

            }
            if (button5.Text == "Кога се създава българската екзархия?")
            {
                player.Play();

                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct;
                frm133.Show();
                Hide();
            }
            if (button5.Text == "През коя година е издаден „Рибен буквар“?")
            {
                player1.Play();

                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct + 1;
                frm133.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Индивидуална и извънредна длъжност в древен Рим е:")
            {
                player.Play();


                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct;
                frm133.Show();
                Hide();

            }
            if (button5.Text == "Кога се създава българската екзархия?")
            {
                player1.Play();

                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct + 1;
                frm133.Show();
                Hide();
            }
            if (button5.Text == "През коя година е издаден „Рибен буквар“?")
            {
                player.Play();

                frm133 = new Form133();
                frm133.passTime1 = Time1;
                frm133.passTime2 = Time2;
                frm133.passTime3 = Time3;
                frm133.passTime4 = Time4;
                frm133.passTime5 = Time5;
                frm133.passTime6 = Time6;
                frm133.passTime7 = Time7;
                frm133.passTime8 = a;
                frm133.passCorrect = Correct;
                frm133.Show();
                Hide();
            }
        }
    }
}
