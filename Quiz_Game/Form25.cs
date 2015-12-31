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
    public partial class Form25 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form26 frm26;
        int a = 0;
        int Correct;
        public Form25()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form25_Load(object sender, EventArgs e)
      

            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Колко са часовите зони в Русия?";
                    button1.Text = "6";
                    button2.Text = "2";
                    button3.Text = "9"; // Верният Отговор
                    button4.Text = "1";
                }
                if (q1 == 2)
                {
                    button5.Text = "Коя река е приток на Нил?";
                    button1.Text = "Ока";
                    button2.Text = "Кагера";  // Верният Отговор
                    button3.Text = "Шингу";
                    button4.Text = "Иса";
                }
                if (q1 == 3)
                {
                    button5.Text = "Столицата на Еритрея е?";
                    button1.Text = "Асмара";  // Верният Отговор
                    button2.Text = "Алофи"; 
                    button3.Text = "Нгерулмуд";
                    button4.Text = "Баку";
                }
            }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко са часовите зони в Русия?")
            {
                player.Play();
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();

            }
            if (button5.Text == "Коя река е приток на Нил?")
            {
                player.Play();
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();
            }
            if (button5.Text == "Столицата на Еритрея е?")
            {
                player1.Play();   //Верен отговор
                Correct = 1;

                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко са часовите зони в Русия?")
            {
                player.Play();
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();

            }
            if (button5.Text == "Коя река е приток на Нил?")
            {
                player1.Play();   //Верен отговор
                Correct = 1;
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();
            }
            if (button5.Text == "Столицата на Еритрея е?")
            {
                player.Play();
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко са часовите зони в Русия?")
            {
                player1.Play();   //Верен отговор
                Correct = 1;
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();

            }
            if (button5.Text == "Коя река е приток на Нил?")
            {
                player.Play();
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();
            }
            if (button5.Text == "Столицата на Еритрея е?")
            {
                player.Play();
                
                frm26 = new Form26();

                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко са часовите зони в Русия?")
            {
                player.Play();
                
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();

            }
            if (button5.Text == "Коя река е приток на Нил?")
            {
                player.Play();
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();
            }
            if (button5.Text == "Столицата на Еритрея е?")
            {
                player.Play();
                
                frm26 = new Form26();
                frm26.passTime1 = a;
                frm26.passCorrect = Correct;
                frm26.Show();
                Hide();
            }
        }
    }
}
