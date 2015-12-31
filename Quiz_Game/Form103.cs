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
    public partial class Form103 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form104 frm104;
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
        public Form103()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form103_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "През II световна война Италия е управлявана от?";
                button1.Text = "Мусолини"; // Верният отговор
                button2.Text = "Хитлер";
                button3.Text = "цар Борис";
                button4.Text = "Кубрат";
            }
            if (q1 == 2)
            {
                button5.Text = "Коя империя е считана за най-великата?";
                button1.Text = "Османската"; 
                button2.Text = "Индийската";
                button3.Text = "Българската";
                button4.Text = "Римската"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Васил Левски е бил?";
                button1.Text = "Апостол за свобода"; // Верният отговор
                button2.Text = "престъпник";
                button3.Text = "Обирджия"; 
                button4.Text = "Поп";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През II световна война Италия е управлявана от?")
            {
                player1.Play(); // Верният отговор


                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct + 1;
                frm104.Show();
                Hide();

            }
            if (button5.Text == "Коя империя е считана за най-великата?")
            {
                player.Play();

                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct;
                frm104.Show();
                Hide();
            }
            if (button5.Text == "Васил Левски е бил?")
            {
                player1.Play(); // Верният отговор

                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct + 1;
                frm104.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През II световна война Италия е управлявана от?")
            {
                player.Play();


                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct;
                frm104.Show();
                Hide();

            }
            if (button5.Text == "Коя империя е считана за най-великата?")
            {
                player.Play();

                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct;
                frm104.Show();
                Hide();
            }
            if (button5.Text == "Васил Левски е бил?")
            {
                player.Play();

                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct;
                frm104.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През II световна война Италия е управлявана от?")
            {
                player.Play();


                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct;
                frm104.Show();
                Hide();

            }
            if (button5.Text == "Коя империя е считана за най-великата?")
            {
                player.Play();

                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct;
                frm104.Show();
                Hide();
            }
            if (button5.Text == "Васил Левски е бил?")
            {
                player.Play();

                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct;
                frm104.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През II световна война Италия е управлявана от?")
            {
                player.Play();


                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct;
                frm104.Show();
                Hide();

            }
            if (button5.Text == "Коя империя е считана за най-великата?")
            {
                player1.Play(); // Верният отговор

                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct + 1;
                frm104.Show();
                Hide();
            }
            if (button5.Text == "Васил Левски е бил?")
            {
                player.Play();

                frm104 = new Form104();
                frm104.passTime1 = Time1;
                frm104.passTime2 = Time2;
                frm104.passTime3 = Time3;
                frm104.passTime4 = Time4;
                frm104.passTime5 = Time5;
                frm104.passTime6 = Time6;
                frm104.passTime7 = Time7;
                frm104.passTime8 = Time8;
                frm104.passTime9 = a;
                frm104.passCorrect = Correct;
                frm104.Show();
                Hide();
            }
        }
    }
}
