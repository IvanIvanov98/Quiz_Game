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
    public partial class Form15 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form17 frm17;
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
        public Form15()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                
                button5.Text = "Най-населеният щат в Америка е?";
                button1.Text = "Мичиган"; 
                button2.Text = "Охайдо";
                button3.Text = "Тексас";
                button4.Text = "Калифорния"; // Верният Отговор
            }
            if (q1 == 2)
            {
                
                button5.Text = "Най-голяма пустиния на Земята е?";
                button1.Text = "Антарктида";
                button2.Text = "Сахара"; // Верният Отговор
                button3.Text = "Калахари"; 
                button4.Text = "Гоби";
            }
            if (q1 == 3)
            {
                button5.Text = "Коя държава има формата на чушка?";
                button1.Text = "Чили"; // Верният отговор
                button2.Text = "Перу";
                button3.Text = "Виетнам";
                button4.Text = "Индия"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-населеният щат в Америка е?")
            {
                player.Play(); 
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = Correct;
                frm17.Show();
                Hide();

            }
            if (button5.Text == "Най-голяма пустиния на Земята е?")
            {
                player.Play();
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = Correct;
                frm17.Show();
                Hide();
            }
            if (button5.Text == "Коя държава има формата на чушка?")
            {
                player1.Play();   //Верен отговор
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = (Correct + 1);
                frm17.Show();
                Hide();
            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-населеният щат в Америка е?")
            {
                player.Play();
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = Correct;
                frm17.Show();
                Hide();

            }
            if (button5.Text == "Най-голяма пустиния на Земята е?")
            {
                player1.Play();   //Верен отговор
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = (Correct + 1);
                frm17.Show();
                Hide();
            }
            if (button5.Text == "Коя държава има формата на чушка?")
            {
                player.Play();
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = Correct;
                frm17.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-населеният щат в Америка е?")
            {
                player.Play();
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = Correct;
                frm17.Show();
                Hide();

            }
            if (button5.Text == "Най-голяма пустиния на Земята е?")
            {
                player.Play();
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = Correct;
                frm17.Show();
                Hide();
            }
            if (button5.Text == "Коя държава има формата на чушка?")
            {
                player.Play();
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = Correct;
                frm17.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-населеният щат в Америка е?")
            {
                player1.Play();   //Верен отговор
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = (Correct + 1);
                frm17.Show();
                Hide();

            }
            if (button5.Text == "Най-голяма пустиния на Земята е?")
            {
                player.Play();
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = Correct;
                frm17.Show();
                Hide();
            }
            if (button5.Text == "Коя държава има формата на чушка?")
            {
                player.Play();
                
                frm17 = new Form17();
                frm17.passTime1 = Time1;
                frm17.passTime2 = a;
                frm17.passCorrect = Correct;
                frm17.Show();
                Hide();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
