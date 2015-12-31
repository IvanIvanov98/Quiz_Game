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
    public partial class Form95 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form96 frm96;
        int a = 0;
        int Correct = 0;
        public Form95()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form95_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Колко световни войни е имало досега?";
                button1.Text = "2"; // Верният отговор
                button2.Text = "3";
                button3.Text = "4";
                button4.Text = "1";
            }
            if (q1 == 2)
            {
                button5.Text = "Коя империя е управлявал Юлий Цезар?";
                button1.Text = "Извънземната";
                button2.Text = "Немската";
                button3.Text = "Римската"; // Верният Отговор
                button4.Text = "Османската";
            }
            if (q1 == 3)
            {

                button5.Text = "При кой владател е „златния век“ на България?";
                button1.Text = "Тодор Живков"; 
                button2.Text = "Симеон"; // Верният отговор
                button3.Text = "Омуртаг";
                button4.Text = "Орфей";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко световни войни е имало досега?")
            {
                player1.Play(); // Верният отговор


                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct + 1;
                frm96.Show();
                Hide();

            }
            if (button5.Text == "Коя империя е управлявал Юлий Цезар?")
            {
                player.Play();

                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct;
                frm96.Show();
                Hide();
            }
            if (button5.Text == "При кой владател е „златния век“ на България?")
            {
                player.Play();

                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct;
                frm96.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко световни войни е имало досега?")
            {
                player.Play();


                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct;
                frm96.Show();
                Hide();

            }
            if (button5.Text == "Коя империя е управлявал Юлий Цезар?")
            {
                player.Play();

                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct;
                frm96.Show();
                Hide();
            }
            if (button5.Text == "При кой владател е „златния век“ на България?")
            {
                player1.Play(); // Верният отговор

                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct + 1;
                frm96.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко световни войни е имало досега?")
            {
                player.Play();


                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct;
                frm96.Show();
                Hide();

            }
            if (button5.Text == "Коя империя е управлявал Юлий Цезар?")
            {
                player1.Play(); // Верният отговор

                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct + 1;
                frm96.Show();
                Hide();
            }
            if (button5.Text == "При кой владател е „златния век“ на България?")
            {
                player.Play();

                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct;
                frm96.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко световни войни е имало досега?")
            {
                player.Play();


                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct;
                frm96.Show();
                Hide();

            }
            if (button5.Text == "Коя империя е управлявал Юлий Цезар?")
            {
                player.Play();

                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct;
                frm96.Show();
                Hide();
            }
            if (button5.Text == "При кой владател е „златния век“ на България?")
            {
                player.Play();

                frm96 = new Form96();
                frm96.passTime1 = a;
                frm96.passCorrect = Correct;
                frm96.Show();
                Hide();
            }
        }
    }
}
