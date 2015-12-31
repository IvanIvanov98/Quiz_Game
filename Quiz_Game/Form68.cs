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
    public partial class Form68 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form69 frm69;
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
        public Form68()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form68_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {   

                button5.Text = "С какво се хранят тревопасните животни?";
                button1.Text = "Слънчева светлина";
                button2.Text = "Растения"; // Верният Отговор
                button3.Text = "Животни"; 
                button4.Text = "Минерални соли";
            }
            if (q1 == 2)
            {

                button5.Text = "Какъв цвят вещество е хлорофилът?";
                button1.Text = "Син";
                button2.Text = "Червен";
                button3.Text = "Жълт";
                button4.Text = "Зелен";  // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "С какво растенията обогатяват въздуха?";
                button1.Text = "Азот"; 
                button2.Text = "Кислород"; // Верният отговор
                button3.Text = "Сяра";
                button4.Text = "Въглероден диоксид";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С какво се хранят тревопасните животни?")
            {
                player.Play();


                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct;
                frm69.Show();
                Hide();

            }
            if (button5.Text == "Какъв цвят вещество е хлорофилът?")
            {
                player.Play();

                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct;
                frm69.Show();
                Hide();
            }
            if (button5.Text == "С какво растенията обогатяват въздуха?")
            {
                player.Play(); 

                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct;
                frm69.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С какво се хранят тревопасните животни?")
            {
                player1.Play(); // Верен отговор


                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct + 1;
                frm69.Show();
                Hide();

            }
            if (button5.Text == "Какъв цвят вещество е хлорофилът?")
            {
                player.Play();

                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct;
                frm69.Show();
                Hide();
            }
            if (button5.Text == "С какво растенията обогатяват въздуха?")
            {
                player1.Play(); // Верен отговор

                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct + 1;
                frm69.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С какво се хранят тревопасните животни?")
            {
                player.Play();


                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct;
                frm69.Show();
                Hide();

            }
            if (button5.Text == "Какъв цвят вещество е хлорофилът?")
            {
                player.Play();

                frm69 = new Form69();
                frm69.Show();
                Hide();
            }
            if (button5.Text == "С какво растенията обогатяват въздуха?")
            {
                player.Play(); 

                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct;
                frm69.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С какво се хранят тревопасните животни?")
            {
                player.Play();


                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct;
                frm69.Show();
                Hide();

            }
            if (button5.Text == "Какъв цвят вещество е хлорофилът?")
            {
                player1.Play(); // Верен отговор

                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct + 1;
                frm69.Show();
                Hide();
            }
            if (button5.Text == "С какво растенията обогатяват въздуха?")
            {
                player.Play();

                frm69 = new Form69();
                frm69.passTime1 = Time1;
                frm69.passTime2 = Time2;
                frm69.passTime3 = Time3;
                frm69.passTime4 = a;
                frm69.passCorrect = Correct;
                frm69.Show();
                Hide();
            }
        }
    }
    }

