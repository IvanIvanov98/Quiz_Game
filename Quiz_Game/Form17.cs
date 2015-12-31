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
    public partial class Form17 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form18 frm18;
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

        public Form17()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor



        }

        private void Form17_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
               
                button5.Text = "В кой континент се намира Сахара?";
                button1.Text = "Азия"; 
                button2.Text = "Европа"; 
                button3.Text = "Африка";   // Верният Отговор
                button4.Text = "Австралия";
            }
            if (q1 == 2)
            {
                button5.Text = "В кой град се намира Биг Бен?";
                button1.Text = "Ливърпул"; 
                button2.Text = "Челси";
                button3.Text = "Лондон";  // Верният Отговор
                button4.Text = "Лестър";
            }
            if (q1 == 3)
            {
                button5.Text = "Най-южна страна в Африка е?";
                button1.Text = "Мароко";
                button2.Text = "Кения";
                button3.Text = "Египет";
                button4.Text = "РЮА"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой континент се намира Сахара?")
            {
                player.Play();
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = Correct;
                frm18.Show();
                Hide();

            }
            if (button5.Text == "В кой град се намира Биг Бен?")
            {
                player.Play();
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = Correct;
                frm18.Show();
                Hide();
            }
            if (button5.Text == "Най-южна страна в Африка е?")
            {
                player.Play();
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = Correct;
                frm18.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой континент се намира Сахара?")
            {
                player.Play();
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = Correct;
                frm18.Show();
                Hide();

            }
            if (button5.Text == "В кой град се намира Биг Бен?")
            {
                player.Play();
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = Correct;
                frm18.Show();
                Hide();
            }
            if (button5.Text == "Най-южна страна в Африка е?")
            {
                player.Play();
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = Correct;
                frm18.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой континент се намира Сахара?")
            {
                player1.Play();   //Верен отговор
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = (Correct + 1);
                frm18.Show();
                Hide();

            }
            if (button5.Text == "В кой град се намира Биг Бен?")
            {
                player1.Play();   //Верен отговор
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = (Correct + 1);
                frm18.Show();
                Hide();
            }
            if (button5.Text == "Най-южна страна в Африка е?")
            {
                player.Play();
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = Correct;
                frm18.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой континент се намира Сахара?")
            {
                player.Play();
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = Correct;
                frm18.Show();
                Hide();

            }
            if (button5.Text == "В кой град се намира Биг Бен?")
            {
                player.Play();
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = Correct;
                frm18.Show();
                Hide();
            }
            if (button5.Text == "Най-южна страна в Африка е?")
            {
                player1.Play();   //Верен отговор
                
                frm18 = new Form18();
                frm18.passTime1 = Time1;
                frm18.passTime2 = Time2;
                frm18.passTime3 = a;
                frm18.passCorrect = (Correct + 1);
                frm18.Show();
                Hide();
            }
        }
    }
}
