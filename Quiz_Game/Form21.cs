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
    public partial class Form21 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form22 frm22;
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
        private int Time4;
        public int passTime4
        {
            get
            {
                return Time4;
            }
            set
            {
                Time4 = value;
            }
        }
        private int Time5;
        public int passTime5
        {
            get
            {
                return Time5;
            }
            set
            {
                Time5 = value;
            }
        }
        private int Time6;
        public int passTime6
        {
            get
            {
                return Time6;
            }
            set
            {
                Time6 = value;
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
        public Form21()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Конфуцианството е характерно за?";
                    button1.Text = "Китай"; // Верният Отговор
                    button2.Text = "САЩ";
                    button3.Text = "Тайван";
                    button4.Text = "Индонезия";
                }
                if (q1 == 2)
                {
                    button5.Text = "Коя река не е приток на Дунав?";
                    button1.Text = "Искър";
                    button2.Text = "Барата";
                    button3.Text = "Жиу"; 
                    button4.Text = "Марица"; // Верният Отговор
                }
                if (q1 == 3)
                {
                    button5.Text = "Най-дълбоката река в Света е?";
                    button1.Text = "Конго"; // Верният отговор
                    button2.Text = "Дунав";
                    button3.Text = "Меконг";
                    button4.Text = "Тунджа"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Конфуцианството е характерно за?")
            {

                player1.Play();   //Верен отговор
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = (Correct + 1);
                frm22.Show();
                Hide();

            }
            if (button5.Text == "Коя река не е приток на Дунав?")
            {
                player.Play();
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = Correct;
                frm22.Show();
                Hide();
            }
            if (button5.Text == "Най-дълбоката река в Света е?")
            {
                player1.Play();   //Верен отговор
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = (Correct + 1);
                frm22.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Конфуцианството е характерно за?")
            {
                player.Play();
                
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = Correct;
                frm22.Show();
                Hide();

            }
            if (button5.Text == "Коя река не е приток на Дунав?")
            {
                player.Play();
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = Correct;

                frm22.Show();
                Hide();
            }
            if (button5.Text == "Най-дълбоката река в Света е?")
            {
                player.Play();
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = Correct;
                frm22.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Конфуцианството е характерно за?")
            {
                player.Play();
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = Correct;
                frm22.Show();
                Hide();

            }
            if (button5.Text == "Коя река не е приток на Дунав?")
            {
                player.Play();
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = Correct;
                frm22.Show();
                Hide();
            }
            if (button5.Text == "Най-дълбоката река в Света е?")
            {
                player.Play();
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = Correct;
                frm22.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Конфуцианството е характерно за?")
            {
                player.Play();
                
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = Correct;
                frm22.Show();
                Hide();

            }
            if (button5.Text == "Коя река не е приток на Дунав?")
            {
                player1.Play();   //Верен отговор
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = (Correct + 1);
                frm22.Show();
                Hide();
            }
            if (button5.Text == "Най-дълбоката река в Света е?")
            {
                player.Play();
                
                
                frm22 = new Form22();
                frm22.passTime1 = Time1;
                frm22.passTime2 = Time2;
                frm22.passTime3 = Time3;
                frm22.passTime4 = Time4;
                frm22.passTime5 = Time5;
                frm22.passTime6 = Time6;
                frm22.passTime7 = a;
                frm22.passCorrect = Correct;
                frm22.Show();
                Hide();
            }
        }
    }
}
