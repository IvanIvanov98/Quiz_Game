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
    public partial class Form66 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form67 frm67;
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
        public Form66()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form66_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кое животно е двуутробно?";
                button1.Text = "Жаба";
                button2.Text = "Куче";
                button3.Text = "Коала"; // Верният Отговор
                button4.Text = "Лъв";
            }
            if (q1 == 2)
            {

                button5.Text = "Кое животно е носител на болестта малария?";
                button1.Text = "Комар"; // Верният Отговор
                button2.Text = "Котка"; 
                button3.Text = "Калинка";
                button4.Text = "Пчела";
            }
            if (q1 == 3)
            {

                button5.Text = "Коя наука изучава животните?";
                button1.Text = "Екология"; 
                button2.Text = "Зоология"; // Верният отговор
                button3.Text = "Фитология";
                button4.Text = "Микробиология";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое животно е двуутробно?")
            {
                player.Play();


                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct;
                frm67.Show();
                Hide();

            }
            if (button5.Text == "Кое животно е носител на болестта малария?")
            {
                player1.Play(); // Верен отговор

                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct + 1;
                frm67.Show();
                Hide();
            }
            if (button5.Text == "Коя наука изучава животните?")
            {
                player.Play();

                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct;
                frm67.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое животно е двуутробно?")
            {
                player.Play();


                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct;
                frm67.Show();
                Hide();

            }
            if (button5.Text == "Кое животно е носител на болестта малария?")
            {
                player.Play();

                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct;
                frm67.Show();
                Hide();
            }
            if (button5.Text == "Коя наука изучава животните?")
            {
                player1.Play(); // Верен отговор


                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct + 1;
                frm67.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое животно е двуутробно?")
            {
                player1.Play(); // Верен отговор


                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct + 1;
                frm67.Show();
                Hide();

            }
            if (button5.Text == "Кое животно е носител на болестта малария?")
            {
                player.Play();


                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct;
                frm67.Show();
                Hide();
            }
            if (button5.Text == "Коя наука изучава животните?")
            {
                player.Play(); 

                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct;
                frm67.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое животно е двуутробно?")
            {
                player.Play();


                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct;
                frm67.Show();
                Hide();

            }
            if (button5.Text == "Кое животно е носител на болестта малария?")
            {
                player.Play();


                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct;
                frm67.Show();
                Hide();
            }
            if (button5.Text == "Коя наука изучава животните?")
            {
                player.Play(); 


                frm67 = new Form67();
                frm67.passTime1 = Time1;
                frm67.passTime2 = a;
                frm67.passCorrect = Correct;
                frm67.Show();
                Hide();
            }
        }
    }
}
