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
    public partial class Form32 : Form

    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form33 frm33;
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
        public Form32()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form32_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Коя от изброените страни няма столица?";
                    button1.Text = "Сан Марино";
                    button2.Text = "Бахрейн"; 
                    button3.Text = "Сингапур";
                    button4.Text = "Науру"; // Верният Отговор
                }
                if (q1 == 2)
                {
                    button5.Text = "Кой е вицепрезидент на Судан?";
                    button1.Text = "Омар ал-Башир";
                    button2.Text = "Али Осман Таха"; // Верният Отговор
                    button3.Text = "Исмаил паша";
                    button4.Text = "Тауфик паша"; 
                }
                if (q1 == 3)
                {
                    button5.Text = "Коя от посочените реки не извира от Хималаите?";
                    button1.Text = "Инд";
                    button2.Text = "Ганг"; 
                    button3.Text = "Брахмапутра";
                    button4.Text = "Бригах"; // Верният отговор
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от изброените страни няма столица?")
            {
                player.Play();
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct;
                frm33.Show();
                Hide();

            }
            if (button5.Text == "Кой е вицепрезидент на Судан?")
            {
                player.Play();
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct;
                frm33.Show();
                Hide();
            }
            if (button5.Text == "Коя от посочените реки не извира от Хималаите?")
            {
                player.Play();
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct;
                frm33.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от изброените страни няма столица?")
            {
                player.Play();   
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct;
                frm33.Show();
                Hide();

            }
            if (button5.Text == "Кой е вицепрезидент на Судан?")
            {
                player1.Play();   //Верен отговор
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct + 1;
                frm33.Show();
                Hide();
            }
            if (button5.Text == "Коя от посочените реки не извира от Хималаите?")
            {
                player.Play();
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct;
                frm33.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от изброените страни няма столица?")
            {
                player.Play();
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct;
                frm33.Show();
                Hide();

            }
            if (button5.Text == "Кой е вицепрезидент на Судан?")
            {
                player.Play();
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct;
                frm33.Show();
                Hide();
            }
            if (button5.Text == "Коя от посочените реки не извира от Хималаите?")
            {
                player.Play();
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct;
                frm33.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от изброените страни няма столица?")
            {
                player1.Play();   //Верен отговор
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct + 1;
                frm33.Show();
                Hide();

            }
            if (button5.Text == "Кой е вицепрезидент на Судан?")
            {
                player.Play();
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct;
                frm33.Show();
                Hide();
            }
            if (button5.Text == "Коя от посочените реки не извира от Хималаите?")
            {
                player1.Play();   //Верен отговор
                
                frm33 = new Form33();
                frm33.passTime1 = Time1;
                frm33.passTime2 = Time2;
                frm33.passTime3 = Time3;
                frm33.passTime4 = Time4;
                frm33.passTime5 = Time5;
                frm33.passTime6 = Time6;
                frm33.passTime7 = Time7;
                frm33.passTime8 = a;
                frm33.passCorrect = Correct + 1;
                frm33.Show();
                Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
