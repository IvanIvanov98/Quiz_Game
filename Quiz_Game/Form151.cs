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
    public partial class Form151 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form152 frm152;
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
        public Form151()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form151_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "„Каквото и да е, аз съм против“ е цитат от?";
                button1.Text = "Чарли Шийн";
                button2.Text = "Дъглас Феърбанкс";
                button3.Text = "Граучо Маркс";  // Верният отговор
                button4.Text = "Мери Пикфорд";
            }
            if (q1 == 2)
            {
                button5.Text = "Кога е роден Бъстър Кийтън?";
                button1.Text = "1800"; // Верният Отговор
                button2.Text = "1865";
                button3.Text = "1875";
                button4.Text = "1895";
            }
            if (q1 == 3)
            {

                button5.Text = "Какъв жанр е водевил?";
                button1.Text = "Комедия";
                button2.Text = "Драма"; // Верният отговор
                button3.Text = "Мистерия";
                button4.Text = "Трилър";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "„Каквото и да е, аз съм против“ е цитат от?")
            {
                player.Play();


                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct;
                frm152.Show();
                Hide();

            }
            if (button5.Text == "Кога е роден Бъстър Кийтън?")
            {
                player.Play();

                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct;
                frm152.Show();
                Hide();
            }
            if (button5.Text == "Какъв жанр е водевил?")
            {
                player1.Play();

                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct + 1;
                frm152.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "„Каквото и да е, аз съм против“ е цитат от?")
            {
                player.Play();


                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct;
                frm152.Show();
                Hide();

            }
            if (button5.Text == "Кога е роден Бъстър Кийтън?")
            {
                player.Play();

                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct;
                frm152.Show();
                Hide();
            }
            if (button5.Text == "Какъв жанр е водевил?")
            {
                player.Play();

                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct;
                frm152.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "„Каквото и да е, аз съм против“ е цитат от?")
            {
                player1.Play();


                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct + 1;
                frm152.Show();
                Hide();

            }
            if (button5.Text == "Кога е роден Бъстър Кийтън?")
            {
                player.Play();

                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct;
                frm152.Show();
                Hide();
            }
            if (button5.Text == "Какъв жанр е водевил?")
            {
                player.Play();

                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct;
                frm152.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "„Каквото и да е, аз съм против“ е цитат от?")
            {
                player.Play();


                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct;
                frm152.Show();
                Hide();

            }
            if (button5.Text == "Кога е роден Бъстър Кийтън?")
            {
                player1.Play();

                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct + 1;
                frm152.Show();
                Hide();
            }
            if (button5.Text == "Какъв жанр е водевил?")
            {
                player.Play();

                frm152 = new Form152();
                frm152.passTime1 = Time1;
                frm152.passTime2 = Time2;
                frm152.passTime3 = Time3;
                frm152.passTime4 = Time4;
                frm152.passTime5 = Time5;
                frm152.passTime6 = Time6;
                frm152.passTime7 = a;
                frm152.passCorrect = Correct;
                frm152.Show();
                Hide();
            }
        }
    }
}
