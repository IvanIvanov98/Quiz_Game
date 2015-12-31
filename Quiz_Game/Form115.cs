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
    public partial class Form115 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form116 frm116;
        int a = 0;
        int Correct = 0;
        public Form115()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form115_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Иван Вазов е?";
                button1.Text = "Поет";  // Верният отговор
                button2.Text = "Певец";
                button3.Text = "Художник";
                button4.Text = "Владетел";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой е художникът нарисувал „Мона Лиза“?";
                button1.Text = "Пикасо";
                button2.Text = "Леонардо да Винчи"; // Верният Отговор
                button3.Text = "Микеланджело";
                button4.Text = "Донатело";
            }
            if (q1 == 3)
            {

                button5.Text = "Кой е химнът на Европа?";
                button1.Text = "„Хубава си моя горо“";
                button2.Text = "„Симфония №9“";
                button3.Text = "„Ода на радостта“"; // Верният отговор
                button4.Text = "„Лунната соната“";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Иван Вазов е?")
            {
                player1.Play();


                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct + 1;
                frm116.Show();
                Hide();

            }
            if (button5.Text == "Кой е художникът нарисувал „Мона Лиза“?")
            {
                player.Play();

                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct;
                frm116.Show();
                Hide();
            }
            if (button5.Text == "Кой е химнът на Европа?")
            {
                player.Play();

                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct;
                frm116.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Иван Вазов е?")
            {
                player.Play();


                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct;
                frm116.Show();
                Hide();

            }
            if (button5.Text == "Кой е художникът нарисувал „Мона Лиза“?")
            {
                player1.Play();

                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct + 1;
                frm116.Show();
                Hide();
            }
            if (button5.Text == "Кой е химнът на Европа?")
            {
                player.Play();

                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct;
                frm116.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Иван Вазов е?")
            {
                player.Play();


                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct;
                frm116.Show();
                Hide();

            }
            if (button5.Text == "Кой е художникът нарисувал „Мона Лиза“?")
            {
                player.Play();

                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct;
                frm116.Show();
                Hide();
            }
            if (button5.Text == "Кой е химнът на Европа?")
            {
                player1.Play();

                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct + 1;
                frm116.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Иван Вазов е?")
            {
                player.Play();


                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct;
                frm116.Show();
                Hide();

            }
            if (button5.Text == "Кой е художникът нарисувал „Мона Лиза“?")
            {
                player.Play();

                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct;
                frm116.Show();
                Hide();
            }
            if (button5.Text == "Кой е химнът на Европа?")
            {
                player.Play();

                frm116 = new Form116();
                frm116.passTime1 = a;
                frm116.passCorrect = Correct;
                frm116.Show();
                Hide();
            }
        }
    }
}
