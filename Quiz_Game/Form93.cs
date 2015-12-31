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
    public partial class Form93 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form94 frm94;
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
        public Form93()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form93_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кое е растит. аналог на хитина?";
                button1.Text = "Целуозата"; // Верният отговор
                button2.Text = "Гликогенът";
                button3.Text = "Скорбялата";
                button4.Text = "Гликогенът"; 
            }
            if (q1 == 2)
            {
                button5.Text = "Тилакоидната мембрана е характерна за?";
                button1.Text = "Митохондрите";
                button2.Text = "Рибозомите";
                button3.Text = "Хлоропластите"; // Верният Отговор
                button4.Text = "Алвеолите"; 
            }
            if (q1 == 3)
            {

                button5.Text = "Хаплоиден хромозомен набор имат?";
                button1.Text = "Половите клетки"; // Верният отговор
                button2.Text = "Нервните клетки"; 
                button3.Text = "Епителните клетки";
                button4.Text = "Левкоцитни клетки";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое е растит. аналог на хитина?")
            {
                player1.Play();


                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct + 1;
                frm94.Show();
                Hide();

            }
            if (button5.Text == "Тилакоидната мембрана е характерна за?")
            {
                player.Play();

                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct;
                frm94.Show();
                Hide();
            }
            if (button5.Text == "Хаплоиден хромозомен набор имат?")
            {
                player1.Play();

                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct + 1;
                frm94.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое е растит. аналог на хитина?")
            {
                player.Play();


                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct;
                frm94.Show();
                Hide();

            }
            if (button5.Text == "Тилакоидната мембрана е характерна за?")
            {
                player.Play();

                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct;
                frm94.Show();
                Hide();
            }
            if (button5.Text == "Хаплоиден хромозомен набор имат?")
            {
                player.Play();

                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct;
                frm94.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое е растит. аналог на хитина?")
            {
                player.Play();


                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct;
                frm94.Show();
                Hide();

            }
            if (button5.Text == "Тилакоидната мембрана е характерна за?")
            {
                player1.Play();

                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct + 1;
                frm94.Show();
                Hide();
            }
            if (button5.Text == "Хаплоиден хромозомен набор имат?")
            {
                player.Play();

                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct;
                frm94.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое е растит. аналог на хитина?")
            {
                player.Play();


                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct;
                frm94.Show();
                Hide();

            }
            if (button5.Text == "Тилакоидната мембрана е характерна за?")
            {
                player.Play();

                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct;
                frm94.Show();
                Hide();
            }
            if (button5.Text == "Хаплоиден хромозомен набор имат?")
            {
                player.Play();

                frm94 = new Form94();
                frm94.passTime1 = Time1;
                frm94.passTime2 = Time2;
                frm94.passTime3 = Time3;
                frm94.passTime4 = Time4;
                frm94.passTime5 = Time5;
                frm94.passTime6 = Time6;
                frm94.passTime7 = Time7;
                frm94.passTime8 = Time8;
                frm94.passTime9 = a;
                frm94.passCorrect = Correct;
                frm94.Show();
                Hide();
            }
        }
    }
}
