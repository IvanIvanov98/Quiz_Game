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
    public partial class Form97 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form98 frm98;
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
        public Form97()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form97_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Коя година се счита за начало на българската държава?";
                button1.Text = "101";
                button2.Text = "681"; // Верният отговор
                button3.Text = "1402";
                button4.Text = "1998"; 
            }
            if (q1 == 2)
            {
                button5.Text = "Кой е основателият на българската държава?";
                button1.Text = "Борис";
                button2.Text = "Крум"; 
                button3.Text = "Аспарух"; // Верният Отговор
                button4.Text = "Левски";
            }
            if (q1 == 3)
            {

                button5.Text = "От изброените столица на България е била?";
                button1.Text = "Видин"; 
                button2.Text = "Лондон";
                button3.Text = "Несебър";
                button4.Text = "Плиска"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя година се счита за начало на българската държава?")
            {
                player.Play();


                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct;
                frm98.Show();
                Hide();

            }
            if (button5.Text == "Кой е основателият на българската държава?")
            {
                player.Play();

                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct;
                frm98.Show();
                Hide();
            }
            if (button5.Text == "От изброените столица на България е била?")
            {
                player.Play();

                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct;
                frm98.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя година се счита за начало на българската държава?")
            {
                player1.Play(); // Верният отговор


                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct + 1;
                frm98.Show();
                Hide();

            }
            if (button5.Text == "Кой е основателият на българската държава?")
            {
                player.Play();

                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct;
                frm98.Show();
                Hide();
            }
            if (button5.Text == "От изброените столица на България е била?")
            {
                player.Play();

                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct;
                frm98.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя година се счита за начало на българската държава?")
            {
                player.Play();


                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct;
                frm98.Show();
                Hide();

            }
            if (button5.Text == "Кой е основателият на българската държава?")
            {
                player1.Play(); // Верният отговор

                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct + 1;
                frm98.Show();
                Hide();
            }
            if (button5.Text == "От изброените столица на България е била?")
            {
                player.Play();

                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct;
                frm98.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя година се счита за начало на българската държава?")
            {
                player.Play();


                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct;
                frm98.Show();
                Hide();

            }
            if (button5.Text == "Кой е основателият на българската държава?")
            {
                player.Play();

                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct;
                frm98.Show();
                Hide();
            }
            if (button5.Text == "От изброените столица на България е била?")
            {
                player1.Play(); // Верният отговор

                frm98 = new Form98();
                frm98.passTime1 = Time1;
                frm98.passTime2 = Time2;
                frm98.passTime3 = a;
                frm98.passCorrect = Correct + 1;
                frm98.Show();
                Hide();
            }
        }
    }
}
