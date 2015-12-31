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
    public partial class Form117 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form118 frm118;
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
        public Form117()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form117_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "За какво се дава наградата „Оскар“?";
                button1.Text = "Песен";
                button2.Text = "Филм";  // Верният отговор
                button3.Text = "Театрално представление";
                button4.Text = "Картина";
            }
            if (q1 == 2)
            {
                button5.Text = "Кое е публицистична творба?";
                button1.Text = "Роман";
                button2.Text = "Разказ";
                button3.Text = "Поема";
                button4.Text = "Есе";  // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Колко на брой са музикалните ноти?";
                button1.Text = "5";
                button2.Text = "10";
                button3.Text = "7"; // Верният отговор
                button4.Text = "3";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "За какво се дава наградата „Оскар“?")
            {
                player.Play();


                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct;
                frm118.Show();
                Hide();

            }
            if (button5.Text == "Кое е публицистична творба?")
            {
                player.Play();

                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct;
                frm118.Show();
                Hide();
            }
            if (button5.Text == "Колко на брой са музикалните ноти?")
            {
                player.Play();

                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct;
                frm118.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "За какво се дава наградата „Оскар“?")
            {
                player1.Play();


                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct + 1;
                frm118.Show();
                Hide();

            }
            if (button5.Text == "Кое е публицистична творба?")
            {
                player.Play();

                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct;
                frm118.Show();
                Hide();
            }
            if (button5.Text == "Колко на брой са музикалните ноти?")
            {
                player.Play();

                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct;
                frm118.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "За какво се дава наградата „Оскар“?")
            {
                player.Play();


                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct;
                frm118.Show();
                Hide();

            }
            if (button5.Text == "Кое е публицистична творба?")
            {
                player.Play();

                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct;
                frm118.Show();
                Hide();
            }
            if (button5.Text == "Колко на брой са музикалните ноти?")
            {
                player1.Play();

                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct + 1;
                frm118.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "За какво се дава наградата „Оскар“?")
            {
                player.Play();


                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct;
                frm118.Show();
                Hide();

            }
            if (button5.Text == "Кое е публицистична творба?")
            {
                player1.Play();

                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct + 1;
                frm118.Show();
                Hide();
            }
            if (button5.Text == "Колко на брой са музикалните ноти?")
            {
                player.Play();

                frm118 = new Form118();
                frm118.passTime1 = Time1;
                frm118.passTime2 = Time2;
                frm118.passTime3 = a;
                frm118.passCorrect = Correct;
                frm118.Show();
                Hide();
            }
        }
    }
}
