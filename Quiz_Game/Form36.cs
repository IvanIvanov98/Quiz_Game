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
    public partial class Form36 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        
        private Form37 frm37;
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
        public Form36()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form36_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Бадминтона се играе с помощта на?";
                    button1.Text = "Щеки"; 
                    button2.Text = "Бухалки";
                    button3.Text = "Ракети"; // Верният Отговор
                    button4.Text = "Топка";
                }
                if (q1 == 2)
                {
                    button5.Text = "Какво бойно изкуство е Таекуон-До?";
                    button1.Text = "Корейско"; // Верният Отговор
                    button2.Text = "Сръбско";
                    button3.Text = "Мексиканско"; 
                    button4.Text = "Чилийско";
                }
                if (q1 == 3)
                {
                    button5.Text = "Световният женски рекорд на висок скок е на?";
                    button1.Text = "Димътър Василев";
                    button2.Text = "Стефка Костадинова"; // Верният отговор
                    button3.Text = "Теодора Башка";
                    button4.Text = "Лили Иванова";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Бадминтона се играе с помощта на?")
            {
                player.Play();

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct;
                frm37.Show();
                Hide();

            }
            if (button5.Text == "Какво бойно изкуство е Таекуон-До?")
            {
                player1.Play();   //Верен отговор

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct + 1;
                frm37.Show();
                Hide();
            }
            if (button5.Text == "Световният женски рекорд на висок скок е на?")
            {
                player.Play();

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct;
                frm37.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Бадминтона се играе с помощта на?")
            {
                player.Play();

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct;
                frm37.Show();
                Hide();

            }
            if (button5.Text == "Какво бойно изкуство е Таекуон-До?")
            {
                player.Play();

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct;
                frm37.Show();
                Hide();
            }
            if (button5.Text == "Световният женски рекорд на висок скок е на?")
            {
                player1.Play();   //Верен отговор

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct + 1;
                frm37.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Бадминтона се играе с помощта на?")
            {
                player1.Play();   //Верен отговор

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct + 1;
                frm37.Show();
                Hide();

            }
            if (button5.Text == "Какво бойно изкуство е Таекуон-До?")
            {
                player.Play();

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct;
                frm37.Show();
                Hide();
            }
            if (button5.Text == "Световният женски рекорд на висок скок е на?")
            {
                player.Play();

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct;
                frm37.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Бадминтона се играе с помощта на?")
            {
                player.Play();

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct;
                frm37.Show();
                Hide();

            }
            if (button5.Text == "Какво бойно изкуство е Таекуон-До?")
            {
                player.Play();

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct;
                frm37.Show();
                Hide();
            }
            if (button5.Text == "Световният женски рекорд на висок скок е на?")
            {
                player.Play();

                
                frm37 = new Form37();
                frm37.passTime1 = Time1;
                frm37.passTime2 = a;
                frm37.passCorrect = Correct;
                frm37.Show();
                Hide();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
