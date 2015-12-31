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
    public partial class Form65 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form66 frm66;
        int a = 0;
        int Correct = 0;
        public Form65()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form65_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кое от изброените е бозайник?";
                button1.Text = "Шаран";
                button2.Text = "Акула";
                button3.Text = "Делфин"; // Верният Отговор
                button4.Text = "Сом";
            }
            if (q1 == 2)
            {
                button5.Text = "Кое е най-голямото животно в света?";
                button1.Text = "Слон";
                button2.Text = "Син кит"; // Верният Отговор
                button3.Text = "Акула"; 
                button4.Text = "Мишка";
            }
            if (q1 == 3)
            {
                button5.Text = "Кое от изброените е влечуго?";
                button1.Text = "7Змия"; // Верният отговор
                button2.Text = "Хамстер";
                button3.Text = "Мравка";
                button4.Text = "Хипопотам";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое от изброените е бозайник?")
            {
                player.Play();

                
                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct; 
                frm66.Show();
                Hide();

            }
            if (button5.Text == "Кое е най-голямото животно в света?")
            {
                player.Play();

                
                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct;
                frm66.Show();
                Hide();
            }
            if (button5.Text == "Кое от изброените е влечуго?")
            {
                player1.Play(); // Верен отговор

                
                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct + 1;
                frm66.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое от изброените е бозайник?")
            {
                player.Play();

                
                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct;
                frm66.Show();
                Hide();

            }
            if (button5.Text == "Кое е най-голямото животно в света?")
            {
                player1.Play(); // Верен отговор

                
                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct + 1;
                frm66.Show();
                Hide();
            }
            if (button5.Text == "Кое от изброените е влечуго?")
            {
                player.Play();

                
                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct;
                frm66.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое от изброените е бозайник?")
            {
                player1.Play(); // Верен отговор


                frm66 = new Form66();
                frm66.Show();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct + 1;
                Hide();

            }
            if (button5.Text == "Кое е най-голямото животно в света?")
            {
                player.Play();

                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct;
                frm66.Show();
                Hide();
            }
            if (button5.Text == "Кое от изброените е влечуго?")
            {
                player.Play();


                frm66 = new Form66();
                frm66.Show();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct;
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое от изброените е бозайник?")
            {
                player.Play();

                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct;
                frm66.Show();
                Hide();

            }
            if (button5.Text == "Кое е най-голямото животно в света?")
            {
                player.Play();

                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct;
                frm66.Show();
                Hide();
            }
            if (button5.Text == "Кое от изброените е влечуго?")
            {
                player.Play();

              
                frm66 = new Form66();
                frm66.passTime1 = a;
                frm66.passCorrect = Correct;
                frm66.Show();
                Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }
    }
}
