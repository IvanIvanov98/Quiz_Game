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
    public partial class Form76 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form77 frm77;
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

        public Form76()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form76_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кое влиза в състава на РНК?";
                button1.Text = "Глюкозата";
                button2.Text = "Фруктозата";
                button3.Text = "Рибозата"; // Верният Отговор
                button4.Text = "Дезоксирибозата";
            }
            if (q1 == 2)
            {
                button5.Text = "Колко монозах. остатъка има в полизахаридите?";
                button1.Text = "Повече от 1";
                button2.Text = "Повече от 9";  // Верният Отговор
                button3.Text = "Повече от 3";
                button4.Text = "Повече от 30";
            }
            if (q1 == 3)
            {

                button5.Text = "Кои в-ва доставят най-много енергия?";
                button1.Text = "Мазнините"; // Верният отговор
                button2.Text = "Въглехидратите";
                button3.Text = "Солите";
                button4.Text = "Аминокиселините";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое влиза в състава на РНК?")
            {
                player.Play();


                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct;
                frm77.Show();
                Hide();

            }
            if (button5.Text == "Колко монозах. остатъка има в полизахаридите?")
            {
                player.Play();

                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct;
                frm77.Show();
                Hide();
            }
            if (button5.Text == "Кои в-ва доставят най-много енергия?")
            {
                player1.Play();

                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct + 1;
                frm77.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое влиза в състава на РНК?")
            {
                player.Play();


                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct;
                frm77.Show();
                Hide();

            }
            if (button5.Text == "Колко монозах. остатъка има в полизахаридите?")
            {
                player1.Play();

                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct + 1;
                frm77.Show();
                Hide();
            }
            if (button5.Text == "Кои в-ва доставят най-много енергия?")
            {
                player.Play();

                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct;
                frm77.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое влиза в състава на РНК?")
            {
                player1.Play();


                frm77 = new Form77();

                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct + 1;
                frm77.Show();
                Hide();

            }
            if (button5.Text == "Колко монозах. остатъка има в полизахаридите?")
            {
                player.Play();

                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct;
                frm77.Show();
                Hide();
            }
            if (button5.Text == "Кои в-ва доставят най-много енергия?")
            {
                player.Play();

                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct;
                frm77.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое влиза в състава на РНК?")
            {
                player.Play();


                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct;
                frm77.Show();
                Hide();

            }
            if (button5.Text == "Колко монозах. остатъка има в полизахаридите?")
            {
                player.Play();

                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct;
                frm77 = new Form77();
                frm77.Show();
                Hide();
            }
            if (button5.Text == "Кои в-ва доставят най-много енергия?")
            {
                player.Play();

                frm77 = new Form77();
                frm77.passTime1 = Time1;
                frm77.passTime2 = a;
                frm77.passCorrect = Correct;
                frm77.Show();
                Hide();
            }
        }
    }
}
