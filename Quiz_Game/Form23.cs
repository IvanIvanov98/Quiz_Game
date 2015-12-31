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
    public partial class Form23 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form24 frm24;
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
        public Form23()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Столицата на Кения е?";
                    button1.Text = "Найроби"; // Верният Отговор
                    button2.Text = "Адис Абеба";
                    button3.Text = "Кайро";
                    button4.Text = "Тунис";
                }
                if (q1 == 2)
                {
                    button5.Text = "Кафето идва от?";
                    button1.Text = "Аржентина";
                    button2.Text = "Бразилия"; // Верният Отговор
                    button3.Text = "Турция"; 
                    button4.Text = "Египет";
                }
                if (q1 == 3)
                {
                    button5.Text = "Царевицата идва от?";
                    button1.Text = "САЩ";
                    button2.Text = "Чили";
                    button3.Text = "Мексико"; // Верният отговор
                    button4.Text = "Холандия"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столицата на Кения е?")
            {
                player1.Play();   //Верен отговор
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = (Correct + 1);
                frm24.Show();
                Hide();

            }
            if (button5.Text == "Кафето идва от?")
            {
                player.Play();
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = Correct;
                frm24.Show();
                Hide();
            }
            if (button5.Text == "Царевицата идва от?")
            {
                player.Play();
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = Correct;
                frm24.Show();
                
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столицата на Кения е?")
            {
                player.Play();
                
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = Correct;
                frm24.Show();
                Hide();

            }
            if (button5.Text == "Кафето идва от?")
            {
                player1.Play();   //Верен отговор
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = (Correct + 1);
                frm24.Show();
                Hide();
            }
            if (button5.Text == "Царевицата идва от?")
            {
                player.Play();
                
                frm24 = new Form24();
                     frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = Correct;
                frm24.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столицата на Кения е?")
            {
                player.Play();
                
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = Correct;
                frm24.Show();
                Hide();

            }
            if (button5.Text == "Кафето идва от?")
            {
                player.Play();
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = Correct;
                frm24.Show();
                Hide();
            }
            if (button5.Text == "Царевицата идва от?")
            {
               
                player1.Play();   //Верен отговор
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = (Correct + 1);
                frm24.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столицата на Кения е?")
            {
                player.Play();
                
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = Correct;
                frm24.Show();
                Hide();

            }
            if (button5.Text == "Кафето идва от?")
            {
                player.Play();
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = Correct;
                frm24.Show();
                Hide();
            }
            if (button5.Text == "Царевицата идва от?")
            {
                player.Play();
                
                frm24 = new Form24();
                frm24.passTime1 = Time1;
                frm24.passTime2 = Time2;
                frm24.passTime3 = Time3;
                frm24.passTime4 = Time4;
                frm24.passTime5 = Time5;
                frm24.passTime6 = Time6;
                frm24.passTime7 = Time7;
                frm24.passTime8 = Time8;
                frm24.passTime9 = a;
                frm24.passCorrect = Correct;
                frm24.Show();
                Hide();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
