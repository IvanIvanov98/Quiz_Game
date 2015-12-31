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
    public partial class Form119 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form120 frm120;
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
        public Form119()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form119_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой жанр се нарича „популярната музика“?";
                button1.Text = "Балада";
                button2.Text = "Класика";
                button3.Text = "Поп"; // Верният отговор
                button4.Text = "Рок";
            }
            if (q1 == 2)
            {
                button5.Text = "Как се нарича изпълнението от двама души?";
                button1.Text = "Дует"; // Верният Отговор
                button2.Text = "Трио";
                button3.Text = "Квартет";
                button4.Text = "Кавър";
            }
            if (q1 == 3)
            {

                button5.Text = "„Кръстникът“ е?";
                button1.Text = "Песен";
                button2.Text = "Картина";
                button3.Text = "Филм"; // Верният отговор
                button4.Text = "Група";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой жанр се нарича „популярната музика“?")
            {
                player.Play();


                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct;
                frm120.Show();
                Hide();

            }
            if (button5.Text == "Как се нарича изпълнението от двама души?")
            {
                player.Play();

                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct;
                frm120.Show();
                Hide();
            }
            if (button5.Text == "„Кръстникът“ е?")
            {
                player.Play();

                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct;
                frm120.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой жанр се нарича „популярната музика“?")
            {
                player1.Play();


                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct + 1;
                frm120.Show();
                Hide();

            }
            if (button5.Text == "Как се нарича изпълнението от двама души?")
            {
                player.Play();

                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct;
                frm120.Show();
                Hide();
            }
            if (button5.Text == "„Кръстникът“ е?")
            {
                player.Play();

                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct;
                frm120.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой жанр се нарича „популярната музика“?")
            {
                player1.Play();


                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct  + 1;
                frm120.Show();
                Hide();

            }
            if (button5.Text == "Как се нарича изпълнението от двама души?")
            {
                player.Play();

                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct;
                frm120.Show();
                Hide();
            }
            if (button5.Text == "„Кръстникът“ е?")
            {
                player1.Play();

                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct + 1;
                frm120.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой жанр се нарича „популярната музика“?")
            {
                player.Play();


                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct;
                frm120.Show();
                Hide();

            }
            if (button5.Text == "Как се нарича изпълнението от двама души?")
            {
                player.Play();

                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct;
                frm120.Show();
                Hide();
            }
            if (button5.Text == "„Кръстникът“ е?")
            {
                player.Play();

                frm120 = new Form120();
                frm120.passTime1 = Time1;
                frm120.passTime2 = Time2;
                frm120.passTime3 = Time3;
                frm120.passTime4 = Time4;
                frm120.passTime5 = a;
                frm120.passCorrect = Correct;
                frm120.Show();
                Hide();
            }
        }
    }
}
