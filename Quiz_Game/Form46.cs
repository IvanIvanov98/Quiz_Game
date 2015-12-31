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
    public partial class Form46 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form47 frm47;
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
        public Form46()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form46_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Олимпийските игри произлизат от?";
                    button1.Text = "Древна Гърция"; // Верният Отговор
                    button2.Text = "Римската империя";
                    button3.Text = "Латинска Америка";
                    button4.Text = "Северна Америка"; 
                }
                if (q1 == 2)
                {
                    button5.Text = "Магдалена Малеева е?";
                    button1.Text = "лекоатлетка";
                    button2.Text = "скиорка";
                    button3.Text = "биатлонистка";
                    button4.Text = "тенесистка";  // Верният Отговор
                }
                if (q1 == 3)
                {
                    button5.Text = "В коя категория се състезава Кубрат Пулев?";
                    button1.Text = "До 75кг";
                    button2.Text = "До 69кг";
                    button3.Text = "До 91кг"; // Верният отговор
                    button4.Text = "До 81кг"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Олимпийските игри произлизат от?")
            {

                player1.Play();   //Верен отговор

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct + 1;
                frm47.Show();
                Hide();

            }
            if (button5.Text == "Магдалена Малеева е?")
            {
                player.Play();   

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct;
                frm47.Show();
                Hide();
            }
            if (button5.Text == "В коя категория се състезава Кубрат Пулев?")
            {

                player.Play();

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct;
                frm47.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Олимпийските игри произлизат от?")
            {

                player.Play();

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct;
                frm47.Show();
                Hide();

            }
            if (button5.Text == "Магдалена Малеева е?")
            {
                player.Play();   

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct;
                frm47.Show();
                Hide();
            }
            if (button5.Text == "В коя категория се състезава Кубрат Пулев?")
            {

                player.Play();

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct;
                frm47.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Олимпийските игри произлизат от?")
            {

                player.Play();

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct;
                frm47.Show();
                Hide();

            }
            if (button5.Text == "Магдалена Малеева е?")
            {
                player.Play();   

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct;
                frm47.Show();
                Hide();
            }
            if (button5.Text == "В коя категория се състезава Кубрат Пулев?")
            {

                player1.Play();   //Верен отговор

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct + 1;
                frm47.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Олимпийските игри произлизат от?")
            {

                player.Play();

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct;
                frm47.Show();
                Hide();

            }
            if (button5.Text == "Магдалена Малеева е?")
            {
                player1.Play();   //Верен отговор

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct + 1;
                frm47.Show();
                Hide();
            }
            if (button5.Text == "В коя категория се състезава Кубрат Пулев?")
            {

                player.Play();

                
                frm47 = new Form47();
                frm47.passTime1 = Time1;
                frm47.passTime2 = a;
                frm47.passCorrect = Correct;
                frm47.Show();
                Hide();
            }
        }
    }
}
