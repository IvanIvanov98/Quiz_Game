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
    public partial class Form96 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form97 frm97;
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
        public Form96()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form96_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Предмета в училище е история и...?";
                button1.Text = "наука"; 
                button2.Text = "околната среда";
                button3.Text = "здравеопазване";
                button4.Text = "цивилизация"; // Верният отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Адолф Хитлер е бил управник на коя държава?";
                button1.Text = "Франция";
                button2.Text = "Германия"; // Верният Отговор
                button3.Text = "Русия"; 
                button4.Text = "Турция";
            }
            if (q1 == 3)
            {

                button5.Text = "Колко века България е била под турско робство?";
                button1.Text = "5"; // Верният отговор
                button2.Text = "10"; 
                button3.Text = "не е била";
                button4.Text = "2";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Предмета в училище е история и...?")
            {
                player.Play();


                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct;
                frm97.Show();
                Hide();

            }
            if (button5.Text == "Адолф Хитлер е бил управник на коя държава?")
            {
                player.Play();

                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct;
                frm97.Show();
                Hide();
            }
            if (button5.Text == "Колко века България е била под турско робство?")
            {
                player1.Play(); // Верният отговор

                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct + 1;
                frm97.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Предмета в училище е история и...?")
            {
                player.Play();


                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct;
                frm97.Show();
                Hide();

            }
            if (button5.Text == "Адолф Хитлер е бил управник на коя държава?")
            {
                player1.Play(); // Верният отговор

                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct + 1;
                frm97.Show();
                Hide();
            }
            if (button5.Text == "Колко века България е била под турско робство?")
            {
                player.Play();

                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct;
                frm97.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Предмета в училище е история и...?")
            {
                player.Play();


                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct;
                frm97.Show();
                Hide();

            }
            if (button5.Text == "Адолф Хитлер е бил управник на коя държава?")
            {
                player.Play();

                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct;
                frm97.Show();
                Hide();
            }
            if (button5.Text == "Колко века България е била под турско робство?")
            {
                player.Play();

                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct;
                frm97.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Предмета в училище е история и...?")
            {
                player1.Play(); // Верният отговор


                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct + 1;
                frm97.Show();
                Hide();

            }
            if (button5.Text == "Адолф Хитлер е бил управник на коя държава?")
            {
                player.Play();

                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct;
                frm97.Show();
                Hide();
            }
            if (button5.Text == "Колко века България е била под турско робство?")
            {
                player.Play();

                frm97 = new Form97();
                frm97.passTime1 = Time1;
                frm97.passTime2 = a;
                frm97.passCorrect = Correct;
                frm97.Show();
                Hide();
            }
        }
    }
}
