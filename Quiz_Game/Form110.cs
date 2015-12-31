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
    public partial class Form110 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form111 frm111;
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
        private int Time5;
        public int passTime5
        {
            get
            {
                return Time5;
            }
            set
            {
                Time5 = value;
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
        public Form110()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form110_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Реставрацията във Франция е през кой период?";
                button1.Text = "1810-1820г";
                button2.Text = "1804-1815г";
                button3.Text = "1808-1820г";
                button4.Text = "1815-1830г";  // Верният отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Какъв по религиозност е бил Ленин?";
                button1.Text = "Християнин";
                button2.Text = "Мюсулманин";
                button3.Text = "Будист";
                button4.Text = "Атеист"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Какъв е бил бащата на Йосив Сталин?";
                button1.Text = "политик";
                button2.Text = "обущар"; // Верният отговор
                button3.Text = "търговец";
                button4.Text = "безработен";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button5.Text == "Реставрацията във Франция е през кой период?")
            {
                player.Play();


                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct;
                frm111.Show();
                Hide();

            }
            if (button5.Text == "Какъв по религиозност е бил Ленин?")
            {
                player.Play();

                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct;
                frm111.Show();
                Hide();
            }
            if (button5.Text == "Какъв е бил бащата на Йосив Сталин?")
            {
                player.Play();

                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct;
                frm111.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Реставрацията във Франция е през кой период?")
            {
                player.Play();


                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct;
                frm111.Show();
                Hide();

            }
            if (button5.Text == "Какъв по религиозност е бил Ленин?")
            {
                player.Play();

                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct;
                frm111.Show();
                Hide();
            }
            if (button5.Text == "Какъв е бил бащата на Йосив Сталин?")
            {
                player1.Play();

                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct  + 1;
                frm111.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Реставрацията във Франция е през кой период?")
            {
                player.Play();


                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct;
                frm111.Show();
                Hide();

            }
            if (button5.Text == "Какъв по религиозност е бил Ленин?")
            {
                player.Play();

                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct;
                frm111.Show();
                Hide();
            }
            if (button5.Text == "Какъв е бил бащата на Йосив Сталин?")
            {
                player.Play();

                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct;
                frm111.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Реставрацията във Франция е през кой период?")
            {
                player1.Play();


                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct + 1;
                frm111.Show();
                Hide();

            }
            if (button5.Text == "Какъв по религиозност е бил Ленин?")
            {
                player1.Play();

                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct + 1;
                frm111.Show();
                Hide();
            }
            if (button5.Text == "Какъв е бил бащата на Йосив Сталин?")
            {
                player.Play();

                frm111 = new Form111();
                frm111.passTime1 = Time1;
                frm111.passTime2 = Time2;
                frm111.passTime3 = Time3;
                frm111.passTime4 = Time4;
                frm111.passTime5 = Time5;
                frm111.passTime6 = a;
                frm111.passCorrect = Correct;
                frm111.Show();
                Hide();
            }
        }
    }
}
