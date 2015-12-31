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
    public partial class Form109 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form110 frm110;
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
        public Form109()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form109_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Колко брака е имал Карл Велики?";
                button1.Text = "3";
                button2.Text = "1";
                button3.Text = "8"; // Верният отговор
                button4.Text = "5";
            }
            if (q1 == 2)
            {
                button5.Text = "Колко потомци е имал Карл Велики?";
                button1.Text = "6";
                button2.Text = "13"; // Верният Отговор
                button3.Text = "15";
                button4.Text = "9";
            }
            if (q1 == 3)
            {

                button5.Text = "Коя година е коронацията на Наполеон I?";
                button1.Text = "1804"; // Верният отговор
                button2.Text = "1815";
                button3.Text = "1810";
                button4.Text = "1802";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко брака е имал Карл Велики?")
            {
                player.Play();


                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct;
                frm110.Show();
                Hide();

            }
            if (button5.Text == "Колко потомци е имал Карл Велики?")
            {
                player.Play();

                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct;
                frm110.Show();
                Hide();
            }
            if (button5.Text == "Коя година е коронацията на Наполеон I?")
            {
                player1.Play();

                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct + 1;
                frm110.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко брака е имал Карл Велики?")
            {
                player.Play();


                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct;
                frm110.Show();
                Hide();

            }
            if (button5.Text == "Колко потомци е имал Карл Велики?")
            {
                player1.Play();

                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct + 1;
                frm110.Show();
                Hide();
            }
            if (button5.Text == "Коя година е коронацията на Наполеон I?")
            {
                player.Play();

                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct;
                frm110.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко брака е имал Карл Велики?")
            {
                player1.Play();


                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct + 1;
                frm110.Show();
                Hide();

            }
            if (button5.Text == "Колко потомци е имал Карл Велики?")
            {
                player.Play();

                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct;
                frm110.Show();
                Hide();
            }
            if (button5.Text == "Коя година е коронацията на Наполеон I?")
            {
                player.Play();

                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct;
                frm110.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко брака е имал Карл Велики?")
            {
                player.Play();


                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct;
                frm110.Show();
                Hide();

            }
            if (button5.Text == "Колко потомци е имал Карл Велики?")
            {
                player.Play();

                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct;
                frm110.Show();
                Hide();
            }
            if (button5.Text == "Коя година е коронацията на Наполеон I?")
            {
                player.Play();

                frm110 = new Form110();
                frm110.passTime1 = Time1;
                frm110.passTime2 = Time2;
                frm110.passTime3 = Time3;
                frm110.passTime4 = Time4;
                frm110.passTime5 = a;
                frm110.passCorrect = Correct;
                frm110.Show();
                Hide();
            }
        }
    }
}
