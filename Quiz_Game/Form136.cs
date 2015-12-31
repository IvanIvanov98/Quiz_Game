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
    public partial class Form136 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form137 frm137;
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
        public Form136()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form136_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой е създателят на кубизма?";
                button1.Text = "Ерих Хекел";
                button2.Text = "Мане";
                button3.Text = "Винсент Ван Гог";  
                button4.Text = "Пикасо"; // Верният отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Кой е художникът нарисувал „Слънчогледите“?";
                button1.Text = "Ерих Хекел"; 
                button2.Text = "Мане";
                button3.Text = "Винсент Ван Гог"; // Верният Отговор
                button4.Text = "Пикасо";
            }
            if (q1 == 3)
            {

                button5.Text = "Клод Моне е представител на?";
                button1.Text = "Импресионизма"; // Верният отговор
                button2.Text = "Кубизма"; 
                button3.Text = "Символизма";
                button4.Text = "Барока";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е създателят на кубизма?")
            {
                player.Play();


                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct;
                frm137.Show();
                Hide();

            }
            if (button5.Text == "Кой е художникът нарисувал „Слънчогледите“?")
            {
                player.Play();

                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct;
                frm137.Show();
                Hide();
            }
            if (button5.Text == "Клод Моне е представител на?")
            {
                player1.Play();

                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct + 1;
                frm137.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е създателят на кубизма?")
            {
                player.Play();


                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct;
                frm137.Show();
                Hide();

            }
            if (button5.Text == "Кой е художникът нарисувал „Слънчогледите“?")
            {
                player.Play();

                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct;
                frm137.Show();
                Hide();
            }
            if (button5.Text == "Клод Моне е представител на?")
            {
                player.Play();

                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct;
                frm137.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е създателят на кубизма?")
            {
                player.Play();


                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct;
                frm137.Show();
                Hide();

            }
            if (button5.Text == "Кой е художникът нарисувал „Слънчогледите“?")
            {
                player1.Play();

                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct + 1;
                frm137.Show();
                Hide();
            }
            if (button5.Text == "Клод Моне е представител на?")
            {
                player.Play();

                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct;
                frm137.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е създателят на кубизма?")
            {
                player1.Play();


                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct + 1;
                frm137.Show();
                Hide();

            }
            if (button5.Text == "Кой е художникът нарисувал „Слънчогледите“?")
            {
                player.Play();

                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct;
                frm137.Show();
                Hide();
            }
            if (button5.Text == "Клод Моне е представител на?")
            {
                player.Play();

                frm137 = new Form137();
                frm137.passTime1 = Time1;
                frm137.passTime2 = a;
                frm137.passCorrect = Correct;
                frm137.Show();
                Hide();
            }
        }
    }
}
