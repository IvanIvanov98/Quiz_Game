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
    public partial class Form121 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form122 frm122;
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
        public Form121()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form121_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Какъв е Силвесър Сталоун?";
                button1.Text = "Художник";
                button2.Text = "Актьор";  // Верният отговор
                button3.Text = "Певец";
                button4.Text = "Модел";
            }
            if (q1 == 2)
            {
                button5.Text = "Какво е характерно за комедията?";
                button1.Text = "Тъга";
                button2.Text = "Страх";
                button3.Text = "Тревога";
                button4.Text = "Смях"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Как се нарича поредицата от филмови епизоди?";
                button1.Text = "Книга";
                button2.Text = "Сериал"; // Верният отговор
                button3.Text = "Том";
                button4.Text = "Колекция";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв е Силвесър Сталоун?")
            {
                player.Play();


                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct;
                frm122.Show();
                Hide();

            }
            if (button5.Text == "Какво е характерно за комедията?")
            {
                player.Play();

                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct;
                frm122.Show();
                Hide();
            }
            if (button5.Text == "Как се нарича поредицата от филмови епизоди?")
            {
                player.Play();

                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct;
                frm122.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв е Силвесър Сталоун?")
            {
                player1.Play();


                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct + 1;
                frm122.Show();
                Hide();

            }
            if (button5.Text == "Какво е характерно за комедията?")
            {
                player.Play();

                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct;
                frm122.Show();
                Hide();
            }
            if (button5.Text == "Как се нарича поредицата от филмови епизоди?")
            {
                player1.Play();

                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct  + 1;
                frm122.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв е Силвесър Сталоун?")
            {
                player.Play();


                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct;
                frm122.Show();
                Hide();

            }
            if (button5.Text == "Какво е характерно за комедията?")
            {
                player.Play();

                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct;
                frm122.Show();
                Hide();
            }
            if (button5.Text == "Как се нарича поредицата от филмови епизоди?")
            {
                player.Play();

                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct;
                frm122.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв е Силвесър Сталоун?")
            {
                player.Play();


                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct;
                frm122.Show();
                Hide();

            }
            if (button5.Text == "Какво е характерно за комедията?")
            {
                player1.Play();

                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct + 1;
                frm122.Show();
                Hide();
            }
            if (button5.Text == "Как се нарича поредицата от филмови епизоди?")
            {
                player.Play();

                frm122 = new Form122();
                frm122.passTime1 = Time1;
                frm122.passTime2 = Time2;
                frm122.passTime3 = Time3;
                frm122.passTime4 = Time4;
                frm122.passTime5 = Time5;
                frm122.passTime6 = Time6;
                frm122.passTime7 = a;
                frm122.passCorrect = Correct;
                frm122.Show();
                Hide();
            }
        }
    }
}
