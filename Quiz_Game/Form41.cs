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
    public partial class Form41 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form42 frm42;
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
        public Form41()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form41_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Прякорът на Христо Стоичков?";
                    button1.Text = "Извънземното";
                    button2.Text = "Камата"; // Верният Отговор
                    button3.Text = "Баскетболиста";
                    button4.Text = "Ванката";
                }
                if (q1 == 2)
                {
                    button5.Text = "Колко минути протича 1 редовен баскетболен мач?";
                    button1.Text = "15"; 
                    button2.Text = "20";
                    button3.Text = "30";
                    button4.Text = "40"; // Верният Отговор
                }
                if (q1 == 3)
                {
                    button5.Text = "От коя страна произлиза футбола?";
                    button1.Text = "Сърбия";
                    button2.Text = "Англия";   // Верният отговор
                    button3.Text = "Гърция";
                    button4.Text = "България";
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Прякорът на Христо Стоичков?")
            {
                player.Play();

                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct;
                frm42.Show();
                Hide();

            }
            if (button5.Text == "Колко минути протича 1 редовен баскетболен мач?")
            {
                player.Play();

                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct;
                frm42.Show();
                Hide();
            }
            if (button5.Text == "От коя страна произлиза футбола?")
            {
                player.Play();

                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct;
                frm42.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Прякорът на Христо Стоичков?")
            {

                player1.Play();   //Верен отговор
                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct + 1;
                frm42.Show();
                Hide();

            }
            if (button5.Text == "Колко минути протича 1 редовен баскетболен мач?")
            {
                player.Play();
                
                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct;
                frm42.Show();
                Hide();
            }
            if (button5.Text == "От коя страна произлиза футбола?")
            {
                player1.Play();   //Верен отговор

                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct + 1;
                frm42.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Прякорът на Христо Стоичков?")
            {
                player.Play();

                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct;
                frm42.Show();
                Hide();

            }
            if (button5.Text == "Колко минути протича 1 редовен баскетболен мач?")
            {
                player.Play();

                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct;
                frm42.Show();
                Hide();
            }
            if (button5.Text == "От коя страна произлиза футбола?")
            {
                player.Play();

                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct;
                frm42.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Прякорът на Христо Стоичков?")
            {
                player.Play();

                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct;
                frm42.Show();
                Hide();

            }
            if (button5.Text == "Колко минути протича 1 редовен баскетболен мач?")
            {
                player1.Play(); // Верен отговор
                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct + 1;
                frm42.Show();
                Hide();
            }
            if (button5.Text == "От коя страна произлиза футбола?")
            {

                player.Play();   
                
                frm42 = new Form42();
                frm42.passTime1 = Time1;
                frm42.passTime2 = Time2;
                frm42.passTime3 = Time3;
                frm42.passTime4 = Time4;
                frm42.passTime5 = Time5;
                frm42.passTime6 = Time6;
                frm42.passTime7 = a;
                frm42.passCorrect = Correct;
                frm42.Show();
                Hide();
            }
        }
    }
}
