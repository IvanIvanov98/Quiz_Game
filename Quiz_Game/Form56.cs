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
    public partial class Form56 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form57 frm57;
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
        public Form56()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form56_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Колко метра е голямо игрището в пллажния волейбол?";
                    button1.Text = "16 на 10";
                    button2.Text = "16 на 12";
                    button3.Text = "18 на 12";
                    button4.Text = "16 на 8"; // Верният Отговор
                }
                if (q1 == 2)
                {
                    button5.Text = "Международната федерация по плуване е основана през?";
                    button1.Text = "1908"; // Верният Отговор
                    button2.Text = "1942";
                    button3.Text = "1965";
                    button4.Text = "1964";
                }
                if (q1 == 3)
                {
                    button5.Text = "При стрелбатас лък диаметъра на мишената е?";
                    button1.Text = "30см";
                    button2.Text = "46см";
                    button3.Text = "36см"; // Верният отговор
                    button4.Text = "32";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко метра е голямо игрището в пллажния волейбол?")
            {
                player.Play();
                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct;
                frm57.Show();
                Hide();

            }
            if (button5.Text == "Международната федерация по плуване е основана през?")
            {
                player1.Play();
                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct + 1;
                frm57.Show();
                Hide();
            }
            if (button5.Text == "При стрелбатас лък диаметъра на мишената е?")
            {
                player.Play();

                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct;
                frm57.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко метра е голямо игрището в пллажния волейбол?")
            {
                player.Play();
                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct;
                frm57.Show();
                Hide();

            }
            if (button5.Text == "Международната федерация по плуване е основана през?")
            {
                player.Play();
                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct;
                frm57.Show();
                Hide();
            }
            if (button5.Text == "При стрелбатас лък диаметъра на мишената е?")
            {
                player.Play();

                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct;
                frm57.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко метра е голямо игрището в пллажния волейбол?")
            {
                player.Play();
                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct;
                frm57.Show();
                Hide();

            }
            if (button5.Text == "Международната федерация по плуване е основана през?")
            {
                player.Play();
                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct;
                frm57.Show();
                Hide();
            }
            if (button5.Text == "При стрелбатас лък диаметъра на мишената е?")
            {
                player1.Play();

                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct + 1;
                frm57.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (button5.Text == "Колко метра е голямо игрището в пллажния волейбол?")
            {
                player1.Play();
                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct + 1;
                frm57.Show();
                Hide();
            }
            if (button5.Text == "Международната федерация по плуване е основана през?")
            {
                player.Play();
                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct;
                frm57.Show();
                Hide();
            }
            if (button5.Text == "При стрелбатас лък диаметъра на мишената е?")
            {
                player.Play();

                
                frm57 = new Form57();
                frm57.passTime1 = Time1;
                frm57.passTime2 = a;
                frm57.passCorrect = Correct;
                frm57.Show();
                Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }
    }
}
