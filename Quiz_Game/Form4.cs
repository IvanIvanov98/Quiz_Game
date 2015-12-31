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
    public partial class Form4 : Form
    {


        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // Greshen sound
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  //  Veren sound

        private Form5 frm5;
        int value;
        int Correct;
        

        private string N3;
        public string passValue
        {
            get
            {
                return N3;
            }
            set
            {
                N3 = value;
            }
        }
        public Form4()
        {
            InitializeComponent();
            

            player.SoundLocation = "wrong.wav"; // Greshen sound
            player1.SoundLocation = "right.wav"; // 2) Veren sound


        }
        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();

            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 2);
            if (q1 == 1)
            {
                button5.Text = "Коя е столицата на България?";
                button1.Text = "София";
                button2.Text = "Пловдив";
                button3.Text = "Варна";
                button4.Text = "Бургас";
            }
            if (q1 == 2)
            {
                button5.Text = "Коя е столицата на Бразилия?";
                button1.Text = "Москва";
                button2.Text = "Пекин";
                button3.Text = "Бразилия";
                button4.Text = "Токио";
            }
            if (q1 == 3)
            {
                button5.Text = "С кое море граничи България?";
                button1.Text = "Бяло море";
                button2.Text = "Червено море";
                button3.Text = "Черно море";
                button4.Text = "Егейско море";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (value++).ToString();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на България?")
            {
                player1.Play();
                
                Correct = 1;
                frm5 = new Form5();

                frm5.passTime1 = value; // Probvam da podam Int
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
                
            }
            if (button5.Text == "Коя е столицата на Бразилия?")
            {
                player.Play(); // Greshen sound


                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
            }
            if (button5.Text == "С кое море граничи България?")
            {
                player.Play(); // Greshen sound

                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на България?")
            {
                player.Play(); // Greshen sound

                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
            }
            if (button5.Text == "Коя е столицата на Бразилия?")
            {

                player.Play(); // Greshen sound


                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
            }
            if (button5.Text == "С кое море граничи България?")
            {
                player.Play(); // Greshen sound

                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на България?")
            {
                player.Play(); // Greshen sound

                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
            }
            if (button5.Text == "Коя е столицата на Бразилия?")
            {
                player1.Play(); // Veren sound
                Correct = 1;


                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();


            }
            if (button5.Text == "С кое море граничи България?")
            {
                player1.Play(); // Veren sound
                Correct = 1;



                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на България?")
            {
                player.Play(); // Greshen sound

                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
            }
            if (button5.Text == "Коя е столицата на Бразилия?")
            {
                player.Play(); // Greshen sound

                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
            }
            if (button5.Text == "С кое море граничи България?")
            {
                player.Play(); // Greshen sound

                frm5 = new Form5();
                frm5.passTime1 = value;
                frm5.passCorrect = Correct;
                frm5.Show();
                Hide();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
