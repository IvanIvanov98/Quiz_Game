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
    public partial class Form120 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form121 frm121;
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
        public Form120()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form120_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Лафонтен е?";
                button1.Text = "Баснописец"; // Верният отговор
                button2.Text = "Певец";
                button3.Text = "Актьор";
                button4.Text = "Художник";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой от изброените инструментите е струнен?";
                button1.Text = "Пиано";
                button2.Text = "Акордеон";
                button3.Text = "Китара"; // Верният Отговор
                button4.Text = "Саксофон";
            }
            if (q1 == 3)
            {

                button5.Text = "Кой от изброените инструментите е духов?";
                button1.Text = "Барабан";
                button2.Text = "Арфа";
                button3.Text = "Тамбура";
                button4.Text = "Флейта"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Лафонтен е?")
            {
                player1.Play();


                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct + 1;
                frm121.Show();
                Hide();

            }
            if (button5.Text == "Кой от изброените инструментите е струнен?")
            {
                player.Play();

                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct;
                frm121.Show();
                Hide();
            }
            if (button5.Text == "Кой от изброените инструментите е духов?")
            {
                player.Play();

                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct;
                frm121.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Лафонтен е?")
            {
                player.Play();


                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct;
                frm121.Show();
                Hide();

            }
            if (button5.Text == "Кой от изброените инструментите е струнен?")
            {
                player.Play();

                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct;
                frm121.Show();
                Hide();
            }
            if (button5.Text == "Кой от изброените инструментите е духов?")
            {
                player.Play();

                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct;
                frm121.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Лафонтен е?")
            {
                player.Play();


                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct;
                frm121.Show();
                Hide();

            }
            if (button5.Text == "Кой от изброените инструментите е струнен?")
            {
                player1.Play();

                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct + 1;
                frm121.Show();
                Hide();
            }
            if (button5.Text == "Кой от изброените инструментите е духов?")
            {
                player.Play();

                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct;
                frm121.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Лафонтен е?")
            {
                player.Play();


                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct;
                frm121.Show();
                Hide();

            }
            if (button5.Text == "Кой от изброените инструментите е струнен?")
            {
                player.Play();

                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct;
                frm121.Show();
                Hide();
            }
            if (button5.Text == "Кой от изброените инструментите е духов?")
            {
                player1.Play();

                frm121 = new Form121();
                frm121.passTime1 = Time1;
                frm121.passTime2 = Time2;
                frm121.passTime3 = Time3;
                frm121.passTime4 = Time4;
                frm121.passTime5 = Time5;
                frm121.passTime6 = a;
                frm121.passCorrect = Correct + 1;
                frm121.Show();
                Hide();
            }
        }
    }
}
