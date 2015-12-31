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
    public partial class Form8 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form9 frm9;
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
        public Form8()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Коя е столицата на Австрия?";
                button1.Text = "Виена"; // Верният Отговор
                button2.Text = "Рим"; 
                button3.Text = "Букурещ";
                button4.Text = "Мадрид";
            }
            if (q1 == 2)
            {
                button5.Text = "Колко общо са щатите в САЩ?";
                button1.Text = "30";
                button2.Text = "40";
                button3.Text = "50"; // Верният Отговор
                button4.Text = "60";
            }
            if (q1 == 3)
            {
                button5.Text = "Къде се намира Колизеумът?";
                button1.Text = "Пекин";
                button2.Text = "Лима"; 
                button3.Text = "Сидни";
                button4.Text = "Рим"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на Австрия?")
            {

                player1.Play();

                frm9 = new Form9();
                frm9.passTime1 = Time1; //.prashtaaaaaaaaam
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = (Correct + 1);

                frm9.Show();
                Hide();
                
            }
            if (button5.Text == "Колко общо са щатите в САЩ?")
            {
                player.Play();

                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = Correct ;

                frm9.Show();
                Hide();
            }
            if (button5.Text == "Къде се намира Колизеумът?")
            {
                player.Play();

                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = Correct;

                frm9.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на Австрия?")
            {
                player.Play();

                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = Correct;

                frm9.Show();
                Hide();

            }
            if (button5.Text == "Колко общо са щатите в САЩ?")
            {
                player.Play();

                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = Correct;

                frm9.Show();
                Hide();
            }
            if (button5.Text == "Къде се намира Колизеумът?")
            {
                player.Play();
                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = Correct;

                frm9.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на Австрия?")
            {
                player.Play();
                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = Correct;

                frm9.Show();
                Hide();

            }
            if (button5.Text == "Колко общо са щатите в САЩ?")
            {
                player1.Play();

                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = (Correct + 1);

                frm9.Show();
                Hide();
            }
            if (button5.Text == "Къде се намира Колизеумът?")
            {
                player.Play();

                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = Correct;

                frm9.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на Австрия?")
            {
                player.Play();

                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = Correct;

                frm9.Show();
                Hide();

            }
            if (button5.Text == "Колко общо са щатите в САЩ?")
            {
                player.Play();

                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = Correct;

                frm9.Show();
                Hide();
            }
            if (button5.Text == "Къде се намира Колизеумът?")
            {
                player1.Play(); 

                frm9 = new Form9();
                frm9.passTime1 = Time1;
                frm9.passTime2 = Time2;
                frm9.passTime3 = Time3;
                frm9.passTime4 = Time4;
                frm9.passTime5 = a;

                frm9.passCorrect = (Correct + 1);

                frm9.Show();
                Hide();
            }
        }
    }
}
