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
    public partial class Form55 : Form
    {
        private Form56 frm56;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        int a = 0;
        int Correct = 0;
        public Form55()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form55_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Колко са летните олимпйски спортове?";
                button1.Text = "25";
                button2.Text = "30";  // Верният Отговор
                button3.Text = "35";
                button4.Text = "40";
            }
            if (q1 == 2)
            {
                button5.Text = "Къде е създаден спорта джудо?";
                button1.Text = "Япония"; // Верният Отговор
                button2.Text = "Корея";
                button3.Text = "Виетнам";
                button4.Text = "Китай";
            }
            if (q1 == 3)
            {
                button5.Text = "В модерния петобой не е включено?";
                button1.Text = "Бягане";
                button2.Text = "Колоездене"; // Верният отговор
                button3.Text = "Фектовка";
                button4.Text = "Стрелба";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко са летните олимпйски спортове?")
            {
                player.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct;
                frm56.Show();
                Hide();

            }
            if (button5.Text == "Къде е създаден спорта джудо?")
            {
                player1.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct + 1;
                frm56.Show();
                Hide();
            }
            if (button5.Text == "В модерния петобой не е включено?")
            {
                player.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct;
                frm56.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко са летните олимпйски спортове?")
            {
                player1.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct + 1;
                frm56.Show();
                Hide();

            }
            if (button5.Text == "Къде е създаден спорта джудо?")
            {
                player.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct;
                frm56.Show();
                Hide();
            }
            if (button5.Text == "В модерния петобой не е включено?")
            {
                player1.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct + 1;
                frm56.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко са летните олимпйски спортове?")
            {
                player.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct;
                frm56.Show();
                Hide();

            }
            if (button5.Text == "Къде е създаден спорта джудо?")
            {
                player.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct;
                frm56.Show();
                Hide();
            }
            if (button5.Text == "В модерния петобой не е включено?")
            {
                player.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct;
                frm56.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко са летните олимпйски спортове?")
            {
                player.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct;
                frm56.Show();
                Hide();

            }
            if (button5.Text == "Къде е създаден спорта джудо?")
            {
                player.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct;
                frm56.Show();
                Hide();
            }
            if (button5.Text == "В модерния петобой не е включено?")
            {
                player.Play();
                
                frm56 = new Form56();
                frm56.passTime1 = a;
                frm56.passCorrect = Correct;
                frm56.Show();
                Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }
    }
}
