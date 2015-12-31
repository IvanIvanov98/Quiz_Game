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
    public partial class Form118 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form119 frm119;
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
        public Form118()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form118_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Какво е изобразено в средата на картината „Тайната вечеря“?";
                button1.Text = "Иисус"; // Верният отговор
                button2.Text = "Слънчоглед";
                button3.Text = "Небосвод";
                button4.Text = "Документ";
            }
            if (q1 == 2)
            {
                button5.Text = "Кое е основното изразно средство при графиката?";
                button1.Text = "Цветни бои";
                button2.Text = "Линия и щрих"; // Верният Отговор
                button3.Text = "Силен звук";
                button4.Text = "Рими";
            }
            if (q1 == 3)
            {

                button5.Text = "Кое е изобразено чрез рисунки?";
                button1.Text = "Драма";
                button2.Text = "Комедия";
                button3.Text = "Екшън";
                button4.Text = "Анимация"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво е изобразено в средата на картината „Тайната вечеря“?")
            {
                player1.Play();


                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct + 1;
                frm119.Show();
                Hide();

            }
            if (button5.Text == "Кое е основното изразно средство при графиката?")
            {
                player.Play();

                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct;
                frm119.Show();
                Hide();
            }
            if (button5.Text == "Кое е изобразено чрез рисунки?")
            {
                player.Play();

                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct;
                frm119.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво е изобразено в средата на картината „Тайната вечеря“?")
            {
                player.Play();


                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct;
                frm119.Show();
                Hide();

            }
            if (button5.Text == "Кое е основното изразно средство при графиката?")
            {
                player1.Play();

                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct + 1;
                frm119.Show();
                Hide();
            }
            if (button5.Text == "Кое е изобразено чрез рисунки?")
            {
                player.Play();

                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct;
                frm119.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво е изобразено в средата на картината „Тайната вечеря“?")
            {
                player.Play();


                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct;
                frm119.Show();
                Hide();

            }
            if (button5.Text == "Кое е основното изразно средство при графиката?")
            {
                player.Play();

                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct;
                frm119.Show();
                Hide();
            }
            if (button5.Text == "Кое е изобразено чрез рисунки?")
            {
                player.Play();

                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct;
                frm119.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво е изобразено в средата на картината „Тайната вечеря“?")
            {
                player.Play();


                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct;
                frm119.Show();
                Hide();

            }
            if (button5.Text == "Кое е основното изразно средство при графиката?")
            {
                player.Play();

                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct;
                frm119.Show();
                Hide();
            }
            if (button5.Text == "Кое е изобразено чрез рисунки?")
            {
                player1.Play();

                frm119 = new Form119();
                frm119.passTime1 = Time1;
                frm119.passTime2 = Time2;
                frm119.passTime3 = Time3;
                frm119.passTime4 = a;
                frm119.passCorrect = Correct + 1;
                frm119.Show();
                Hide();
            }
        }
    }
}
