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
    public partial class Form67 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form68 frm68;
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
        public Form67()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form67_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Фауната обхваща всички?";
                button1.Text = "Растения";
                button2.Text = "Гъби";
                button3.Text = "Животни"; // Верният Отговор
                button4.Text = "Бозайници";
            }
            if (q1 == 2)
            {
                button5.Text = "Флората обхваща всички?";
                button1.Text = "Животни";
                button2.Text = "Влечуги";
                button3.Text = "Земноводни";
                button4.Text = "Растения"; // Верният Отговор
            }
            if (q1 == 3)
            {
                button5.Text = "Кое животно се развива в 4 етапа?";
                button1.Text = "Пеперуда"; // Верният отговор
                button2.Text = "Кенгуру";
                button3.Text = "Риба";
                button4.Text = "Кокошка";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Фауната обхваща всички?")
            {
                player.Play();


                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct;
                frm68.Show();
                Hide();

            }
            if (button5.Text == "Флората обхваща всички?")
            {
                player.Play(); 

                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct;
                frm68.Show();
                Hide();
            }
            if (button5.Text == "Кое животно се развива в 4 етапа?")
            {
                player1.Play(); // Верен отговор

                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct + 1;
                frm68.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Фауната обхваща всички?")
            {
                player.Play();


                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct;
                frm68.Show();
                Hide();

            }
            if (button5.Text == "Флората обхваща всички?")
            {
                player.Play(); 

                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct;
                frm68.Show();
                Hide();
            }
            if (button5.Text == "Кое животно се развива в 4 етапа?")
            {
                player.Play();

                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct;
                frm68.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Фауната обхваща всички?")
            {
                player1.Play(); // Верен отговор


                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct + 1;
                frm68.Show();
                Hide();

            }
            if (button5.Text == "Флората обхваща всички?")
            {
                player.Play(); 

                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct;
                frm68.Show();
                Hide();
            }
            if (button5.Text == "Кое животно се развива в 4 етапа?")
            {
                player.Play();

                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct;
                frm68.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Фауната обхваща всички?")
            {
                player.Play();


                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct;
                frm68.Show();
                Hide();

            }
            if (button5.Text == "Флората обхваща всички?")
            {
                player1.Play(); // Верен отговор

                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct + 1;
                frm68.Show();
                Hide();
            }
            if (button5.Text == "Кое животно се развива в 4 етапа?")
            {
                player.Play();

                frm68 = new Form68();
                frm68.passTime1 = Time1;
                frm68.passTime2 = Time2;
                frm68.passTime3 = a;
                frm68.passCorrect = Correct;
                frm68.Show();
                Hide();
            }
        }
    }
}
    

