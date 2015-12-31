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
    public partial class Form42 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form43 frm43;
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
        public Form42()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form42_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Кубрат Пулев е?";
                    button1.Text = "Футболист";
                    button2.Text = "Волейболист";
                    button3.Text = "Боксьор";  // Верният Отговор
                    button4.Text = "Програмист";
                }
                if (q1 == 2)
                {
                    button5.Text = "Футболния отбор „Барселона“ е от?";
                    button1.Text = "Австрия";
                    button2.Text = "Шотландия";
                    button3.Text = "Македония";
                    button4.Text = "Испания"; // Верният Отговор
                }
                if (q1 == 3)
                {
                    button5.Text = "Баскетболът е най-развит в?";
                    button1.Text = "Канада";
                    button2.Text = "Мексико";   
                    button3.Text = "САЩ"; // Верният отговор
                    button4.Text = "Беларус";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кубрат Пулев е?")
            {
                player.Play();

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct;
                frm43.Show();
                Hide();

            }
            if (button5.Text == "Футболния отбор „Барселона“ е от?")
            {
                player.Play();

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct;
                frm43.Show();
                Hide();
            }
            if (button5.Text == "Баскетболът е най-развит в?")
            {
                player.Play();

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct;
                frm43.Show();
                Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кубрат Пулев е?")
            {
                player.Play();

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct;
                frm43.Show();
                Hide();

            }
            if (button5.Text == "Футболния отбор „Барселона“ е от?")
            {
                player.Play();

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct;
                frm43.Show();
                Hide();
            }
            if (button5.Text == "Баскетболът е най-развит в?")
            {
                player.Play();

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct;
                frm43.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кубрат Пулев е?")
            {
                player1.Play();   //Верен отговор

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct + 1;
                frm43.Show();
                Hide();

            }
            if (button5.Text == "Футболния отбор „Барселона“ е от?")
            {
                player.Play();

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct;
                frm43.Show();
                Hide();
            }
            if (button5.Text == "Баскетболът е най-развит в?")
            {
                player1.Play();   //Верен отговор

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct + 1;
                frm43.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кубрат Пулев е?")
            {

                player.Play();

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct;
                frm43.Show();
                Hide();

            }
            if (button5.Text == "Футболния отбор „Барселона“ е от?")
            {
                player1.Play();   //Верен отговор

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct + 1;
                frm43.Show();
                Hide();
            }
            if (button5.Text == "Баскетболът е най-развит в?")
            {

                player.Play();

                
                frm43 = new Form43();
                frm43.passTime1 = Time1;
                frm43.passTime2 = Time2;
                frm43.passTime3 = Time3;
                frm43.passTime4 = Time4;
                frm43.passTime5 = Time5;
                frm43.passTime6 = Time6;
                frm43.passTime7 = Time7;
                frm43.passTime8 = a;
                frm43.passCorrect = Correct;
                frm43.Show();
                Hide();
            }
        }
    }
}
