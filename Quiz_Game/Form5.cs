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
    public partial class Form5 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();

        private Form6 frm6;
        int value;
        int Correct2;
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
        public Form5()
        {

            InitializeComponent();
            player.SoundLocation = "wrong.wav";
            player1.SoundLocation = "right.wav";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int eE = Time1 + 1;
            timer2.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "С колко страни граничи България?";
                button1.Text = "Четири";
                button2.Text = "Пет"; // Верният Отговор
                button3.Text = "Шест";
                button4.Text = "Седем";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой е най-големия океан в света?";
                button1.Text = "Тихи океан"; // Верният Отговор 
                button2.Text = "Индийски океан";
                button3.Text = "Атлантически океан";
                button4.Text = "Южен океан";
            }
            if (q1 == 3)
            {
                button5.Text = "В кой континент се намира Русия?";
                button1.Text = "Европа";
                button2.Text = "Азия"; // Верният Отговор
                button3.Text = "Африка";
                button4.Text = "Австралия";
            }
    }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (value++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button5.Text == "С колко страни граничи България?")
            {
                player.Play();

                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);
                frm6.Show();
                Hide();

            }
            if (button5.Text == "Кой е най-големия океан в света?")
            {
                player1.Play();
                Correct2 = 1;

                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);
                frm6.Show();
                Hide();
            }
            if (button5.Text == "В кой континент се намира Русия?")
            {
                player.Play();

                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);

                frm6.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С колко страни граничи България?")
            {
                player1.Play();
                Correct2 = 1;

                frm6 = new Form6();
                frm6.passTime1 = Time1; // Prashtam vremeto ot purviq vupros - 1
                frm6.passTime2 = value; // Prashtam vremeto ot vtoriq vupros - 2
                frm6.passCorrect = (Correct + Correct2);
                frm6.Show();
                Hide();
                
            }
            if (button5.Text == "Кой е най-големия океан в света?")
            {
                player.Play();

                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);

                frm6.Show();
                Hide();
            }
            if (button5.Text == "В кой континент се намира Русия?")
            {
                player1.Play();
                Correct2 = 1;

                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;

                frm6.passCorrect = (Correct + Correct2);

                frm6.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С колко страни граничи България?")

            {
                player.Play();

                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);
                frm6.Show();
                Hide();

            }
            if (button5.Text == "Кой е най-големия океан в света?")
            {
                player.Play();

                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);

                frm6.Show();
                Hide();
            }
            if (button5.Text == "В кой континент се намира Русия?")
            {
                player.Play();

                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);

                frm6.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С колко страни граничи България?")
            {
                player.Play();

                
                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);
                frm6.Show();
                Hide();

            }
            if (button5.Text == "Кой е най-големия океан в света?")
            {
                player.Play();

               
                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);

                frm6.Show();
                Hide();
            }
            if (button5.Text == "В кой континент се намира Русия?")
            {
                player.Play();

                
                frm6 = new Form6();
                frm6.passTime1 = Time1;
                frm6.passTime2 = value;
                frm6.passCorrect = (Correct + Correct2);

                frm6.Show();
                Hide();
            }
        }
    }
}
