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
    public partial class Form100 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form101 frm101;
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
        public Form100()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form100_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "През II световна война Германия е в съюз с?";
                button1.Text = "Америка";
                button2.Text = "Италия";  // Верният отговор
                button3.Text = "Франция";
                button4.Text = "Англия";
            }
            if (q1 == 2)
            {
                button5.Text = "От посочените кое изучава историята?";
                button1.Text = "Космоса"; 
                button2.Text = "Извънземните";
                button3.Text = "Войните"; // Верният Отговор
                button4.Text = "Почвата";
            }
            if (q1 == 3)
            {

                button5.Text = "“Княз“ е какво?";
                button1.Text = "Кошмар";
                button2.Text = "Титла"; // Верният отговор
                button3.Text = "Град"; 
                button4.Text = "Име";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През II световна война Германия е в съюз с?")
            {
                player.Play();


                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct;
                frm101.Show();
                Hide();

            }
            if (button5.Text == "От посочените кое изучава историята?")
            {
                player.Play();

                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct;
                frm101.Show();
                Hide();
            }
            if (button5.Text == "“Княз“ е какво?")
            {
                player.Play();

                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct;
                frm101.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През II световна война Германия е в съюз с?")
            {
                player1.Play();  // Верният отговор


                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct + 1;
                frm101.Show();
                Hide();

            }
            if (button5.Text == "От посочените кое изучава историята?")
            {
                player.Play();

                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct;
                frm101.Show();
                Hide();
            }
            if (button5.Text == "“Княз“ е какво?")
            {
                player1.Play();  // Верният отговор

                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct + 1;
                frm101.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През II световна война Германия е в съюз с?")
            {
                player.Play();


                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct;
                frm101.Show();
                Hide();

            }
            if (button5.Text == "От посочените кое изучава историята?")
            {
                player1.Play();  // Верният отговор

                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct + 1;
                frm101.Show();
                Hide();
            }
            if (button5.Text == "“Княз“ е какво?")
            {
                player.Play();

                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct;
                frm101.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През II световна война Германия е в съюз с?")
            {
                player.Play();


                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct;
                frm101.Show();
                Hide();

            }
            if (button5.Text == "От посочените кое изучава историята?")
            {
                player.Play();

                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct;
                frm101.Show();
                Hide();
            }
            if (button5.Text == "“Княз“ е какво?")
            {
                player.Play();

                frm101 = new Form101();
                frm101.passTime1 = Time1;
                frm101.passTime2 = Time2;
                frm101.passTime3 = Time3;
                frm101.passTime4 = Time4;
                frm101.passTime5 = Time5;
                frm101.passTime6 = a;
                frm101.passCorrect = Correct;
                frm101.Show();
                Hide();
            }
        }
    }
}
