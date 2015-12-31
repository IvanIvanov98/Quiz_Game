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
    public partial class Form29 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form30 frm30;
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
        public Form29()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form29_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "П-ов Флотта е част от?";
                    button1.Text = "САЩ";
                    button2.Text = "РЮА";
                    button3.Text = "Русия"; // Верният Отговор
                    button4.Text = "Испания";
                }
                if (q1 == 2)
                {
                    button5.Text = "Нац. парк Олимпик се намира в?";
                    button1.Text = "Гърция";
                    button2.Text = "Франция";
                    button3.Text = "Италия";
                    button4.Text = "САЩ"; // Верният Отговор
                }
                if (q1 == 3)
                {
                    button5.Text = "Вторият най-малкият щат в САЩ е?";
                    button1.Text = "Върмонт";
                    button2.Text = "Род Айланд";
                    button3.Text = "Делауър"; // Верният отговор
                    button4.Text = "Масачузетс";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "П-ов Флотта е част от?")
            {
                player.Play();
                
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct;
                frm30.Show();
                Hide();

            }
            if (button5.Text == "Нац. парк Олимпик се намира в?")
            {
                player.Play();
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct;
                frm30.Show();
                Hide();
            }
            if (button5.Text == "Вторият най-малкият щат в САЩ е?")
            {
                player.Play();
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct;
                frm30.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "П-ов Флотта е част от?")
            {
                player.Play();

                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct;
                frm30.Show();
                Hide();

            }
            if (button5.Text == "Нац. парк Олимпик се намира в?")
            {
                player.Play();
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct;
                frm30.Show();
                Hide();
            }
            if (button5.Text == "Вторият най-малкият щат в САЩ е?")
            {
                player.Play();
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct;
                frm30.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "П-ов Флотта е част от?")
            {
                player1.Play();   //Верен отговор
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct + 1;
                frm30.Show();
                Hide();

            }
            if (button5.Text == "Нац. парк Олимпик се намира в?")
            {
                player.Play();
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct;
                frm30.Show();
                Hide();
            }
            if (button5.Text == "Вторият най-малкият щат в САЩ е?")
            {
                player1.Play();   //Верен отговор
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct + 1;
                frm30.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "П-ов Флотта е част от?")
            {
                player.Play();

                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct;
                frm30.Show();
                Hide();

            }
            if (button5.Text == "Нац. парк Олимпик се намира в?")
            {
                player1.Play();   //Верен отговор
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct + 1;
                frm30.Show();
                Hide();
            }
            if (button5.Text == "Вторият най-малкият щат в САЩ е?")
            {
                player.Play();
                
                frm30 = new Form30();
                frm30.passTime1 = Time1;
                frm30.passTime2 = Time2;
                frm30.passTime3 = Time3;
                frm30.passTime4 = Time4;
                frm30.passTime5 = a;
                frm30.passCorrect = Correct;
                frm30.Show();
                Hide();
            }
        }
    }
}
