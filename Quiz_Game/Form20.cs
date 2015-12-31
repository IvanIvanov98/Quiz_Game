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
    public partial class Form20 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form21 frm21;
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
        public Form20()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Единствения гейзер в Б-я е в?";
                    button1.Text = "Малко Търново"; 
                    button2.Text = "Смолян";
                    button3.Text = "Велинград"; 
                    button4.Text = "Сапареева Баня"; // Верният Отговор
                }
                if (q1 == 2)
                {
                    button5.Text = "Най-пълноводна река в Света е?";
                    button1.Text = "Нил";
                    button2.Text = "Амазонка"; // Верният Отговор
                    button3.Text = "Волга"; 
                    button4.Text = "Замбези";
                }
                if (q1 == 3)
                {
                    button5.Text = "Най-дълбоката точка в Света е?";
                    button1.Text = "Марианската падина"; // Верният отговор
                    button2.Text = "Егейско море";
                    button3.Text = "Средиземно море";
                    button4.Text = "Бяло море"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Единствения гейзер в Б-я е в?")
            {
                player.Play(); 
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = Correct;
                frm21.Show();
                Hide();

            }
            if (button5.Text == "Най-пълноводна река в Света е?")
            {
                player.Play();
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = Correct;
                frm21.Show();
                Hide();
            }
            if (button5.Text == "Най-дълбоката точка в Света е?")
            {
                player1.Play(); // Верен отговор
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = (Correct + 1);
                frm21.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Единствения гейзер в Б-я е в?")
            {
                player.Play();
                
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = Correct;
                frm21.Show();
                Hide();

            }
            if (button5.Text == "Най-пълноводна река в Света е?")
            {
                player1.Play();   //Верен отговор
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = (Correct + 1);
                frm21.Show();
                Hide();
            }
            if (button5.Text == "Най-дълбоката точка в Света е?")
            {
                player.Play();
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = Correct;
                frm21.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Единствения гейзер в Б-я е в?")
            {
                player.Play();
                
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = Correct;
                frm21.Show();
                Hide();

            }
            if (button5.Text == "Най-пълноводна река в Света е?")
            {
                player.Play();
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = Correct;
                frm21.Show();
                Hide();
            }
            if (button5.Text == "Най-дълбоката точка в Света е?")
            {
                player.Play();
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = Correct;
                frm21.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Единствения гейзер в Б-я е в?")
            {
                player1.Play();   //Верен отговор
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = (Correct + 1);
                frm21.Show();
                Hide();

            }
            if (button5.Text == "Най-пълноводна река в Света е?")
            {
                player.Play();
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = Correct;
                frm21.Show();
                Hide();
            }
            if (button5.Text == "Най-дълбоката точка в Света е?")
            {
                player.Play();
                
                frm21 = new Form21();
                frm21.passTime1 = Time1;
                frm21.passTime2 = Time2;
                frm21.passTime3 = Time3;
                frm21.passTime4 = Time4;
                frm21.passTime5 = Time5;
                frm21.passTime6 = a;
                frm21.passCorrect = Correct;
                frm21.Show();
                Hide();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

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
    }
}
