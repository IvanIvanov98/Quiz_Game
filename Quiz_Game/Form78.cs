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
    public partial class Form78 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form79 frm79;
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
        public Form78()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form78_Load(object sender, EventArgs e)
        {

            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кои кръвни клетки имат защитна функция?";
                button1.Text = "Ретикулоцитите";
                button2.Text = "Левкоцитите"; // Верният Отговор
                button3.Text = "Еритороцитите";
                button4.Text = "Цианоцитите";
            }
            if (q1 == 2)
            {
                button5.Text = "Кръвни клетки, образуващи се в костния мозък?";
                button1.Text = "Еритроцити";
                button2.Text = "Тромбоцити";
                button3.Text = "Левкоцити";
                button4.Text = "Ретикулоцити"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Биологичната макросистема е?";
                button1.Text = "Клетката"; 
                button2.Text = "Организмът";
                button3.Text = "Вида";
                button4.Text = "Биосферата"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои кръвни клетки имат защитна функция?")
            {
                player.Play();


                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct;
                frm79.Show();
                Hide();

            }
            if (button5.Text == "Кръвни клетки, образуващи се в костния мозък?")
            {
                player.Play();

                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct;
                frm79.Show();
                Hide();
            }
            if (button5.Text == "Биологичната макросистема е?")
            {
                player.Play();

                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct;
                frm79.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои кръвни клетки имат защитна функция?")
            {
                player1.Play();


                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct + 1;
                frm79.Show();
                Hide();

            }
            if (button5.Text == "Кръвни клетки, образуващи се в костния мозък?")
            {
                player.Play();

                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct;
                frm79.Show();
                Hide();
            }
            if (button5.Text == "Биологичната макросистема е?")
            {
                player.Play();

                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct;
                frm79.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои кръвни клетки имат защитна функция?")
            {
                player.Play();


                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct;
                frm79.Show();
                Hide();

            }
            if (button5.Text == "Кръвни клетки, образуващи се в костния мозък?")
            {
                player.Play();

                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct;
                frm79.Show();
                Hide();
            }
            if (button5.Text == "Биологичната макросистема е?")
            {
                player.Play();

                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct;
                frm79.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои кръвни клетки имат защитна функция?")
            {
                player.Play();


                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct;
                frm79.Show();
                Hide();

            }
            if (button5.Text == "Кръвни клетки, образуващи се в костния мозък?")
            {
                player1.Play();

                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct + 1;
                frm79.Show();
                Hide();
            }
            if (button5.Text == "Биологичната макросистема е?")
            {
                player1.Play();

                frm79 = new Form79();
                frm79.passTime1 = Time1;
                frm79.passTime2 = Time2;
                frm79.passTime3 = Time3;
                frm79.passTime4 = a;
                frm79.passCorrect = Correct + 1;
                frm79.Show();
                Hide();
            }
        }
    }
}
