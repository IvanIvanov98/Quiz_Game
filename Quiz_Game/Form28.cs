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
    public partial class Form28 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form29 frm29;
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
        public Form28()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Град Турко се намира в?";
                    button1.Text = "Норвегия";
                    button2.Text = "Финландия"; // Верният Отговор
                    button3.Text = "Швейцария";
                    button4.Text = "Дания";
                }
                if (q1 == 2)
                {
                    button5.Text = "Река Саскачеван се намира в?";
                    button1.Text = "САЩ";
                    button2.Text = "Канада"; // Верният Отговор
                    button3.Text = "Мексико";
                    button4.Text = "Австрия"; 
                }
                if (q1 == 3)
                {
                    button5.Text = "Езерото Албърт се намира в?";
                    button1.Text = "Азия";
                    button2.Text = "Европа";
                    button3.Text = "Африка"; // Верният отговор
                    button4.Text = "Австралия";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Град Турко се намира в?")
            {
                player.Play();
                
                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct;
                frm29.Show();
                Hide();

            }
            if (button5.Text == "Река Саскачеван се намира в?")
            {
                player.Play();
                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct;
                frm29.Show();
                Hide();
            }
            if (button5.Text == "Езерото Албърт се намира в?")
            {
                player.Play();
                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct;
                frm29.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Град Турко се намира в?")
            {
                player1.Play();   //Верен отговор

                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct + 1;
                frm29.Show();
                Hide();

            }
            if (button5.Text == "Река Саскачеван се намира в?")
            {
                player1.Play();   //Верен отговор

                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct + 1;
                frm29.Show();
                Hide();
            }
            if (button5.Text == "Езерото Албърт се намира в?")
            {
                player.Play();
                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct;
                frm29.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Град Турко се намира в?")
            {
                player.Play();
                
                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct;
                frm29.Show();
                Hide();

            }
            if (button5.Text == "Река Саскачеван се намира в?")
            {
                player.Play();
                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct;
                frm29.Show();
                Hide();
            }
            if (button5.Text == "Езерото Албърт се намира в?")
            {
                player1.Play();   //Верен отговор

                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct + 1;
                frm29.Show();
                Hide();
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Град Турко се намира в?")
            {
                player.Play();
                
                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct;
                frm29.Show();
                Hide();

            }
            if (button5.Text == "Река Саскачеван се намира в?")
            {
                player.Play();
                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct;
                frm29.Show();
                Hide();
            }
            if (button5.Text == "Езерото Албърт се намира в?")
            {
                player.Play();
                
                frm29 = new Form29();
                frm29.passTime1 = Time1;
                frm29.passTime2 = Time2;
                frm29.passTime3 = Time3;
                frm29.passTime4 = a;
                frm29.passCorrect = Correct;
                frm29.Show();
                Hide();
            }
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
