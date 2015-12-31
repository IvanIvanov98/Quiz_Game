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
    public partial class Form107 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form108 frm108;
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
        public Form107()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form107_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой книжовник е съвременник на цар Иван Шишман?";
                button1.Text = "Йоан Екзарх";
                button2.Text = "Климент Охридски";  // Верният отговор
                button3.Text = "Патриарх Евтимий";
                button4.Text = "Матей Граматик";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой наследява Кубрат след смъртта му?";
                button1.Text = "Аспарух";
                button2.Text = "Котраг";
                button3.Text = "Батбаян"; // Верният Отговор
                button4.Text = "Кубер";
            }
            if (q1 == 3)
            {

                button5.Text = "През 565 населението на Византийската империя е?";
                button1.Text = "26млн. души";  // Верният отговор
                button2.Text = "5млн. души";
                button3.Text = "8млн. души";
                button4.Text = "12млн. души ";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой книжовник е съвременник на цар Иван Шишман?")
            {
                player.Play();


                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct;
                frm108.Show();
                Hide();

            }
            if (button5.Text == "Кой наследява Кубрат след смъртта му?")
            {
                player.Play();

                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct;
                frm108.Show();
                Hide();
            }
            if (button5.Text == "През 565 населението на Византийската империя е?")
            {
                player1.Play();

                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct + 1;
                frm108.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой книжовник е съвременник на цар Иван Шишман?")
            {
                player1.Play();


                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct + 1;
                frm108.Show();
                Hide();

            }
            if (button5.Text == "Кой наследява Кубрат след смъртта му?")
            {
                player.Play();

                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct;
                frm108.Show();
                Hide();
            }
            if (button5.Text == "През 565 населението на Византийската империя е?")
            {
                player.Play();

                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct;
                frm108.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой книжовник е съвременник на цар Иван Шишман?")
            {
                player.Play();


                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct;
                frm108.Show();
                Hide();

            }
            if (button5.Text == "Кой наследява Кубрат след смъртта му?")
            {
                player1.Play();

                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct + 1;
                frm108.Show();
                Hide();
            }
            if (button5.Text == "През 565 населението на Византийската империя е?")
            {
                player.Play();

                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct;
                frm108.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой книжовник е съвременник на цар Иван Шишман?")
            {
                player.Play();


                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct;
                frm108.Show();
                Hide();

            }
            if (button5.Text == "Кой наследява Кубрат след смъртта му?")
            {
                player.Play();

                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct;
                frm108.Show();
                Hide();
            }
            if (button5.Text == "През 565 населението на Византийската империя е?")
            {
                player.Play();

                frm108 = new Form108();
                frm108.passTime1 = Time1;
                frm108.passTime2 = Time2;
                frm108.passTime3 = a;
                frm108.passCorrect = Correct;
                frm108.Show();
                Hide();
            }
        }
    }
}
