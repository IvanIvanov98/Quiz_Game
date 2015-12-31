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
    public partial class Form145 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form146 frm146;
        int a = 0;
        int Correct = 0;
        public Form145()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form145_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Винсент Ван Гог е представител на?";
                button1.Text = "Импресионизъм";
                button2.Text = "Кубизъм";
                button3.Text = "Постимпресионизъм";  // Верният отговор
                button4.Text = "Дадаизъм";
            }
            if (q1 == 2)
            {
                button5.Text = "През коя година е нарисувана „Слънчогледите“ от Винсент Ван Гог?";
                button1.Text = "1791"; 
                button2.Text = "1856";
                button3.Text = "1865";
                button4.Text = "1889"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Къде е роден Едгар Алън По?";
                button1.Text = "Бостън"; // Верният отговор
                button2.Text = "Балтимор"; 
                button3.Text = "Вашингтон";
                button4.Text = "Лондон";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Винсент Ван Гог е представител на?")
            {
                player.Play();


                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct;
                frm146.Show();
                Hide();

            }
            if (button5.Text == "През коя година е нарисувана „Слънчогледите“ от Винсент Ван Гог?")
            {
                player.Play();

                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct;
                frm146.Show();
                Hide();
            }
            if (button5.Text == "Къде е роден Едгар Алън По?")
            {
                player1.Play();

                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct + 1;
                frm146.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Винсент Ван Гог е представител на?")
            {
                player.Play();


                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct;
                frm146.Show();
                Hide();

            }
            if (button5.Text == "През коя година е нарисувана „Слънчогледите“ от Винсент Ван Гог?")
            {
                player.Play();

                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct;
                frm146.Show();
                Hide();
            }
            if (button5.Text == "Къде е роден Едгар Алън По?")
            {
                player.Play();

                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct;
                frm146.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Винсент Ван Гог е представител на?")
            {
                player1.Play();


                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct + 1;
                frm146.Show();
                Hide();

            }
            if (button5.Text == "През коя година е нарисувана „Слънчогледите“ от Винсент Ван Гог?")
            {
                player.Play();

                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct;
                frm146.Show();
                Hide();
            }
            if (button5.Text == "Къде е роден Едгар Алън По?")
            {
                player.Play();

                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct;
                frm146.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Винсент Ван Гог е представител на?")
            {
                player.Play();


                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct;
                frm146.Show();
                Hide();

            }
            if (button5.Text == "През коя година е нарисувана „Слънчогледите“ от Винсент Ван Гог?")
            {
                player1.Play();

                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct + 1;
                frm146.Show();
                Hide();
            }
            if (button5.Text == "Къде е роден Едгар Алън По?")
            {
                player.Play();

                frm146 = new Form146();
                frm146.passTime1 = a;
                frm146.passCorrect = Correct;
                frm146.Show();
                Hide();
            }
        }
    }
}
