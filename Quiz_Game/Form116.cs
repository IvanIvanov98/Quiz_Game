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
    public partial class Form116 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form117 frm117;
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
        public Form116()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form116_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой е авторът на „Майце си“?";
                button1.Text = "Христо Ботев"; // Верният отговор
                button2.Text = "Иван Вазов";
                button3.Text = "Васил Левски";
                button4.Text = "Любен Каравелов";
            }
            if (q1 == 2)
            {
                button5.Text = "Какъв жанр е „Под игото“?";
                button1.Text = "Стихотворение";
                button2.Text = "Ода";
                button3.Text = "Поема";
                button4.Text = "Роман";  // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Какъв вид изкуство е живописта?";
                button1.Text = "Музикално";
                button2.Text = "Изобразително"; // Верният отговор
                button3.Text = "Театрално";
                button4.Text = "Литературно";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (button5.Text == "Кой е авторът на „Майце си“?")
            {
                player1.Play();


                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct + 1;
                frm117.Show();
                Hide ();

            }
            if (button5.Text == "Какъв жанр е „Под игото“?")
            {
                player.Play();

                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct;
                frm117.Show();
                Hide();
            }
            if (button5.Text == "Какъв вид изкуство е живописта?")
            {
                player.Play();

                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct;
                frm117.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е авторът на „Майце си“?")
            {
                player.Play();


                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct;
                frm117.Show();
                Hide();

            }
            if (button5.Text == "Какъв жанр е „Под игото“?")
            {
                player.Play();

                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct;
                frm117.Show();
                Hide();
            }
            if (button5.Text == "Какъв вид изкуство е живописта?")
            {
                player1.Play();

                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct + 1;
                frm117.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е авторът на „Майце си“?")
            {
                player.Play();


                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct;
                frm117.Show();
                Hide();

            }
            if (button5.Text == "Какъв жанр е „Под игото“?")
            {
                player.Play();

                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct;
                frm117.Show();
                Hide();
            }
            if (button5.Text == "Какъв вид изкуство е живописта?")
            {
                player.Play();

                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct;
                frm117.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е авторът на „Майце си“?")
            {
                player.Play();


                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct;
                frm117.Show();
                Hide();

            }
            if (button5.Text == "Какъв жанр е „Под игото“?")
            {
                player1.Play();

                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct + 1;
                frm117.Show();
                Hide();
            }
            if (button5.Text == "Какъв вид изкуство е живописта?")
            {
                player.Play();

                frm117 = new Form117();
                frm117.passTime1 = Time1;
                frm117.passTime2 = a;
                frm117.passCorrect = Correct;
                frm117.Show();
                Hide();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
