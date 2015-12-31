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
    public partial class Form59 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form60 frm60;
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
        public Form59()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form59_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Първия световен шампионат по хокей на трева е през?";
                    button1.Text = "1920";
                    button2.Text = "1971"; // Верният Отговор
                    button3.Text = "1941";
                    button4.Text = "1965";
                }
                if (q1 == 2)
                {
                    button5.Text = "Международната волейболна фед. е осована през?";
                    button1.Text = "1947";  // Верният Отговор
                    button2.Text = "1948";
                    button3.Text = "1987";
                    button4.Text = "1966";
                }
                if (q1 == 3)
                {
                    button5.Text = "Дължината на съвременният маратон в километри е?";
                    button1.Text = "42,150";
                    button2.Text = "42,000";
                    button3.Text = "42,195"; // Верният отговор
                    button4.Text = "42,200";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Първия световен шампионат по хокей на трева е през?")
            {
                player.Play();
                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct;
                frm60.Show();
                Hide();

            }
            if (button5.Text == "Международната волейболна фед. е осована през?")
            {
                player1.Play();
                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct + 1;
                frm60.Show();
                Hide();
            }
            if (button5.Text == "Дължината на съвременният маратон в километри е?")
            {
                player.Play();

                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct;
                frm60.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Първия световен шампионат по хокей на трева е през?")
            {
                player1.Play();
                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct + 1;
                frm60.Show();
                Hide();

            }
            if (button5.Text == "Международната волейболна фед. е осована през?")
            {
                player.Play();
                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct;
                frm60.Show();
                Hide();
            }
            if (button5.Text == "Дължината на съвременният маратон в километри е?")
            {
                player.Play();

                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct;
                frm60.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Първия световен шампионат по хокей на трева е през?")
            {
                player.Play();
                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct;
                frm60.Show();
                Hide();

            }
            if (button5.Text == "Международната волейболна фед. е осована през?")
            {
                player.Play();
                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct;
                frm60.Show();
                Hide();
            }
            if (button5.Text == "Дължината на съвременният маратон в километри е?")
            {
                player1.Play();

                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct + 1;
                frm60.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Първия световен шампионат по хокей на трева е през?")
            {
                player.Play();
                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct;
                frm60.Show();
                Hide();

            }
            if (button5.Text == "Международната волейболна фед. е осована през?")
            {
                player.Play();
                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct;
                frm60.Show();
                Hide();
            }
            if (button5.Text == "Дължината на съвременният маратон в километри е?")
            {
                player.Play();

                
                frm60 = new Form60();
                frm60.passTime1 = Time1;
                frm60.passTime2 = Time2;
                frm60.passTime3 = Time3;
                frm60.passTime4 = Time4;
                frm60.passTime5 = a;
                frm60.passCorrect = Correct;
                frm60.Show();
                Hide();
            }
        }
    }
}
