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
    public partial class Form35 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        
        private Form36 frm36;
        int a = 0;
        int Correct = 0;
        public Form35()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form35_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Най-бързия човек на земята е?";
                    button1.Text = "Юсейн Болт"; // Верният Отговор
                    button2.Text = "Йохан Блейк";
                    button3.Text = "Асафа Пауэлл";
                    button4.Text = "Тайсън Гей";
                }
                if (q1 == 2)
                {
                    button5.Text = "Олимпийски игри се провежда през?";
                    button1.Text = "1 година";
                    button2.Text = "3 години";
                    button3.Text = "4 години"; // Верният Отговор
                    button4.Text = "5 години"; 
                }
                if (q1 == 3)
                {
                    button5.Text = "Брояйт на играчите в баскетбола е?";
                    button1.Text = "10"; // Верният отговор
                    button2.Text = "2"; 
                    button3.Text = "4";
                    button4.Text = "5";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-бързия човек на земята е?")
            {
                player1.Play();   //Верен отговор

                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct + 1;
                frm36.Show();
                Hide();

            }
            if (button5.Text == "Олимпийски игри се провежда през?")
            {
                player.Play();

                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct;
                frm36.Show();
                Hide();
            }
            if (button5.Text == "Брояйт на играчите в баскетбола е?")
            {
                player1.Play();   //Верен отговор

                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct + 1;
                frm36.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-бързия човек на земята е?")
            {
                player.Play();
                
                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct;
                frm36.Show();
                Hide();

            }
            if (button5.Text == "Олимпийски игри се провежда през?")
            {
                player.Play();

                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct;
                frm36.Show();
                Hide();
            }
            if (button5.Text == "Брояйт на играчите в баскетбола е?")
            {
                player.Play();

                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct;
                frm36.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-бързия човек на земята е?")
            {
                player.Play();
               
                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct;
                frm36.Show();
                Hide();

            }
            if (button5.Text == "Олимпийски игри се провежда през?")
            {
                player1.Play();   //Верен отговор

                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct + 1;
                frm36.Show();
                Hide();
            }
            if (button5.Text == "Брояйт на играчите в баскетбола е?")
            {
                player.Play();

                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct;
                frm36.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-бързия човек на земята е?")
            {
                player.Play();
                
                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct;
                frm36.Show();
                Hide();

            }
            if (button5.Text == "Олимпийски игри се провежда през?")
            {
                player.Play();

                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct;
                frm36.Show();
                Hide();
            }
            if (button5.Text == "Брояйт на играчите в баскетбола е?")
            {
                player.Play();

                
                frm36 = new Form36();
                frm36.passTime1 = a;
                frm36.passCorrect = Correct;
                frm36.Show();
                Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
