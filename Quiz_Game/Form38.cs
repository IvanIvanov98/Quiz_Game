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
    public partial class Form38 : Form
    {

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        
        private Form39 frm39;
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
        public Form38()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form38_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Бадминтона произла от?";
                    button1.Text = "Германия";
                    button2.Text = "Франция";
                    button3.Text = "Египет"; // Верният Отговор
                    button4.Text = "Търция";
                }
                if (q1 == 2)
                {
                    button5.Text = "Футболистът Роналдо е какъв по националност?";
                    button1.Text = "Бразилец"; // Верният Отговор
                    button2.Text = "Българин";
                    button3.Text = "Грък"; 
                    button4.Text = "Сърбин";
                }
                if (q1 == 3)
                {
                    button5.Text = "Жоузе Мауриньо е треньор по какво?";
                    button1.Text = "Баскетбол";
                    button2.Text = "Футбол"; // Верният отговор
                    button3.Text = "Волейбол";
                    button4.Text = "Шах";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Бадминтона произла от?")
            {
                player.Play();

                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct;
                frm39.Show();
                Hide();

            }
            if (button5.Text == "Футболистът Роналдо е какъв по националност?")
            {
                player1.Play(); // Верен отговор

                

                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct + 1;
                frm39.Show();
                Hide();
            }
            if (button5.Text == "Жоузе Мауриньо е треньор по какво?")
            {
                player.Play();

                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct;
                frm39.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Бадминтона произла от?")
            {
                player.Play();

                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct;
                frm39.Show();
                Hide();

            }
            if (button5.Text == "Футболистът Роналдо е какъв по националност?")
            {
                player.Play();   
                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct;
                frm39.Show();
                Hide();
            }
            if (button5.Text == "Жоузе Мауриньо е треньор по какво?")
            {
                player1.Play();   //Верен отговор

                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct + 1;
                frm39.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Бадминтона произла от?")
            {
                player1.Play();   //Верен отговор

                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct + 1;
                frm39.Show();
                Hide();

            }
            if (button5.Text == "Футболистът Роналдо е какъв по националност?")
            {
                player.Play();

                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct;
                frm39.Show();
                Hide();
            }
            if (button5.Text == "Жоузе Мауриньо е треньор по какво?")
            {
                player.Play();

                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct;
                frm39.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Бадминтона произла от?")
            {
                player.Play();

                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct;
                frm39.Show();
                Hide();

            }
            if (button5.Text == "Футболистът Роналдо е какъв по националност?")
            {
                player.Play();
                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct;
                frm39.Show();
                Hide();
            }
            if (button5.Text == "Жоузе Мауриньо е треньор по какво?")
            {
                player.Play();

                
                frm39 = new Form39();
                frm39.passTime1 = Time1;
                frm39.passTime2 = Time2;
                frm39.passTime3 = Time3;
                frm39.passTime4 = a;
                frm39.passCorrect = Correct;
                frm39.Show();
                Hide();
            }
        }
    }
}
