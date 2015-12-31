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
    public partial class Form113 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form114 frm114;
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
        public Form113()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form113_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Колко дъщери е имал Стефан Стамболов?";
                button1.Text = "1"; // Верният отговор
                button2.Text = "0";
                button3.Text = "2";
                button4.Text = "3";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой е убиецът на Стефан Стамболов?";
                button1.Text = "Михаил Ставрев"; // Верният Отговор
                button2.Text = "Михаил Петров";
                button3.Text = "Георги Тюртев";
                button4.Text = "Петър Трънски";
            }
            if (q1 == 3)
            {

                button5.Text = "Според Ньойският договор Б-ия дължи?";
                button1.Text = "2.54млр. марки";
                button2.Text = "5 млр. марки";
                button3.Text = "25 млр. марки";
                button4.Text = "2.25 млр. марки"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко дъщери е имал Стефан Стамболов?")
            {
                player1.Play();


                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct + 1;
                frm114.Show();
                Hide();

            }
            if (button5.Text == "Кой е убиецът на Стефан Стамболов?")
            {
                player.Play();

                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct;
                frm114.Show();
                Hide();
            }
            if (button5.Text == "Според Ньойският договор Б-ия дължи?")
            {
                player.Play();

                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct;
                frm114.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко дъщери е имал Стефан Стамболов?")
            {
                player.Play();


                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct;
                frm114.Show();
                Hide();

            }
            if (button5.Text == "Кой е убиецът на Стефан Стамболов?")
            {
                player1.Play();

                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct + 1;
                frm114.Show();
                Hide();
            }
            if (button5.Text == "Според Ньойският договор Б-ия дължи?")
            {
                player.Play();

                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct;
                frm114.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко дъщери е имал Стефан Стамболов?")
            {
                player.Play();


                frm114 = new Form114();
                    frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct;
                frm114.Show();
                Hide();

            }
            if (button5.Text == "Кой е убиецът на Стефан Стамболов?")
            {
                player.Play();

                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct;
                frm114.Show();
                Hide();
            }
            if (button5.Text == "Според Ньойският договор Б-ия дължи?")
            {
                player.Play();

                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct;
                frm114.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко дъщери е имал Стефан Стамболов?")
            {
                player.Play();


                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct;
                frm114.Show();
                Hide();

            }
            if (button5.Text == "Кой е убиецът на Стефан Стамболов?")
            {
                player.Play();

                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct;
                frm114.Show();
                Hide();
            }
            if (button5.Text == "Според Ньойският договор Б-ия дължи?")
            {
                player1.Play();

                frm114 = new Form114();
                frm114.passTime1 = Time1;
                frm114.passTime2 = Time2;
                frm114.passTime3 = Time3;
                frm114.passTime4 = Time4;
                frm114.passTime5 = Time5;
                frm114.passTime6 = Time6;
                frm114.passTime7 = Time7;
                frm114.passTime8 = Time8;
                frm114.passTime9 = a;
                frm114.passCorrect = Correct + 1;
                frm114.Show();
                Hide();
            }
        }
    }
}
