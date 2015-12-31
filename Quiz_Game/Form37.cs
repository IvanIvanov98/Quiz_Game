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
    public partial class Form37 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        
        private Form38 frm38;
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
        public Form37()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form37_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Ръгбито идва от коя страна?";
                    button1.Text = "Германия";
                    button2.Text = "Америка"; // Верният Отговор
                    button3.Text = "Франция"; 
                    button4.Text = "България";
                }
                if (q1 == 2)
                {
                    button5.Text = "Как се нарича играча, който пази футб. врата?";
                    button1.Text = "Пазител"; 
                    button2.Text = "Йордан";
                    button3.Text = "Вратар"; // Верният Отговор
                    button4.Text = "Гошо";
                }
                if (q1 == 3)
                {
                    button5.Text = "Колко футболисти от 1 отбор могат да играят на мач?";
                    button1.Text = "5";
                    button2.Text = "11"; // Верният отговор
                    button3.Text = "12";
                    button4.Text = "14";
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Ръгбито идва от коя страна?")
            {
                player.Play();

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct;
                frm38.Show();
                Hide();

            }
            if (button5.Text == "Как се нарича играча, който пази футб. врата?")
            {
                player.Play();

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct;
                frm38.Show();
                Hide();
            }
            if (button5.Text == "Колко футболисти от 1 отбор могат да играят на мач?")
            {
                player.Play();

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct;
                frm38.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Ръгбито идва от коя страна?")
            {
                player1.Play();   //Верен отговор

                
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct + 1;
                frm38 = new Form38();
                frm38.Show();
                Hide();

            }
            if (button5.Text == "Как се нарича играча, който пази футб. врата?")
            {
                player.Play();

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct;
                frm38.Show();
                Hide();
            }
            if (button5.Text == "Колко футболисти от 1 отбор могат да играят на мач?")
            {
                player1.Play();   //Верен отговор

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct + 1;
                frm38.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Ръгбито идва от коя страна?")
            {
                player.Play();

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct;
                frm38.Show();
                Hide();

            }
            if (button5.Text == "Как се нарича играча, който пази футб. врата?")
            {
                player1.Play();   //Верен отговор

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct  + 1;
                frm38.Show();
                Hide();
            }
            if (button5.Text == "Колко футболисти от 1 отбор могат да играят на мач?")
            {
                player.Play();

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct;
                frm38.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Ръгбито идва от коя страна?")
            {
                player.Play();

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct;
                frm38.Show();
                Hide();

            }
            if (button5.Text == "Как се нарича играча, който пази футб. врата?")
            {
                player.Play();

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct;
                frm38.Show();
                Hide();
            }
            if (button5.Text == "Колко футболисти от 1 отбор могат да играят на мач?")
            {
                player.Play();

                
                frm38 = new Form38();
                frm38.passTime1 = Time1;
                frm38.passTime2 = Time2;
                frm38.passTime3 = a;
                frm38.passCorrect = Correct;
                frm38.Show();
                Hide();
            }
        }
    }
}
