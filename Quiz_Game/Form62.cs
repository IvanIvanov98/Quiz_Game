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
    public partial class Form62 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form63 frm63;
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
        public Form62()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form62_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Баскетболистът с най-много асистенции е?";
                    button1.Text = "Майкъл Джордън";
                    button2.Text = "Джон Стоктън"; // Верният Отговор
                    button3.Text = "Уилт Чембърлейн";
                    button4.Text = "Леброн Джеймс";
                }
                if (q1 == 2)
                {
                    button5.Text = "Летните олимпйските игри от 1948 са проведени в?";
                    button1.Text = "Хелзинги";
                    button2.Text = "Лондон"; // Верният Отговор
                    button3.Text = "Токио";
                    button4.Text = "Мелбърн";
                }
                if (q1 == 3)
                {
                    button5.Text = "Кое място заема Б-ия на олимпиадата 1996?";
                    button1.Text = "23";
                    button2.Text = "22"; // Верният отговор
                    button3.Text = "15";
                    button4.Text = "19";
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Баскетболистът с най-много асистенции е?")
            {
                player.Play();
                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct;

                frm63.Show();
                Hide();

            }
            if (button5.Text == "Летните олимпйските игри от 1948 са проведени в?")
            {
                player.Play();
                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct;
                frm63.Show();
                Hide();
            }
            if (button5.Text == "Кое място заема Б-ия на олимпиадата 1996?")
            {
                player.Play();

                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct;
                frm63.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Баскетболистът с най-много асистенции е?")
            {
                player1.Play();
                
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct + 1;
                frm63 = new Form63();
                frm63.Show();
                Hide();

            }
            if (button5.Text == "Летните олимпйските игри от 1948 са проведени в?")
            {
                player1.Play();
                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct + 1;
                frm63.Show();
                Hide();
            }
            if (button5.Text == "Кое място заема Б-ия на олимпиадата 1996?")
            {
                player1.Play();

                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct + 1;
                frm63.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Баскетболистът с най-много асистенции е?")
            {
                player.Play();
                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct;
                frm63.Show();
                Hide();

            }
            if (button5.Text == "Летните олимпйските игри от 1948 са проведени в?")
            {
                player.Play();
                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct;
                frm63.Show();
                Hide();
            }
            if (button5.Text == "Кое място заема Б-ия на олимпиадата 1996?")
            {
                player.Play();

                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct;
                frm63.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Баскетболистът с най-много асистенции е?")
            {
                player.Play();
                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct;
                frm63.Show();
                Hide();

            }
            if (button5.Text == "Летните олимпйските игри от 1948 са проведени в?")
            {
                player.Play();
                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct;
                frm63.Show();
                Hide();
            }
            if (button5.Text == "Кое място заема Б-ия на олимпиадата 1996?")
            {
                player.Play();

                
                frm63 = new Form63();
                frm63.passTime1 = Time1;
                frm63.passTime2 = Time2;
                frm63.passTime3 = Time3;
                frm63.passTime4 = Time4;
                frm63.passTime5 = Time5;
                frm63.passTime6 = Time6;
                frm63.passTime7 = Time7;
                frm63.passTime8 = a;
                frm63.passCorrect = Correct;
                frm63.Show();
                Hide();
            }
        }
    }
}
