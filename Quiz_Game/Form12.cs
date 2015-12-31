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
    public partial class Form12 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste


        private Form13 frm13;
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
        private int Time7;
        public int passTime7
        {
            get
            {
                return Time7;
            }
            set
            {
                Time7 = value;
            }
        }
        private int Time8;
        public int passTime8
        {
            get
            {
                return Time8;
            }
            set
            {
                Time8 = value;
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
        public Form12()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Коя е най-населената държава?";
                button1.Text = "Индия";
                button2.Text = "Русия"; 
                button3.Text = "Япония";
                button4.Text = "Китай"; //ерният Отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Къде се намира о-в Крит?";
                button1.Text = "Черно море";
                button2.Text = "Средиземно море"; // Верният Отговор
                button3.Text = "Арабско море";
                button4.Text = "Бяло море"; 
            }
            if (q1 == 3)
            {
                button5.Text = "Къде се намира Айфеловата кула?";
                button1.Text = "Рим"; 
                button2.Text = "Лондон";
                button3.Text = "Париж"; // Верният отговор
                button4.Text = "София";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е най-населената държава?")
            {
                player.Play();
                
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = Correct;

                frm13.Show();
                Hide();

            }
            if (button5.Text == "Къде се намира о-в Крит?")
            {
                player.Play();
                
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = Correct;

                frm13.Show();
                Hide();
            }
            if (button5.Text == "Къде се намира Айфеловата кула?")
            {
                player.Play();
                
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = Correct;

                frm13.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е най-населената държава?")
            {
                player.Play();

                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = Correct;

                frm13.Show();
                Hide();

            }
            if (button5.Text == "Къде се намира о-в Крит?")
            {
                
                player1.Play();   //Верен отговор
                
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = (Correct + 1);

                frm13.Show();
                Hide();
            }
            if (button5.Text == "Къде се намира Айфеловата кула?")
            {
                player.Play();
                
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = Correct;

                frm13.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е най-населената държава?")
            {
                player.Play();
                
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = Correct;

                frm13.Show();
                Hide();

            }
            if (button5.Text == "Къде се намира о-в Крит?")
            {
                player.Play();
                
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = Correct;

                frm13.Show();
                Hide();
            }
            if (button5.Text == "Къде се намира Айфеловата кула?")
            {
                player1.Play();   //Верен отговор
                
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = (Correct + 1);

                frm13.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е най-населената държава?")
            {
                player1.Play();   //Верен отговор
                
                frm13 = new Form13();
                frm13.passTime1 = Time1; // prashtaaaaaam
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = (Correct + 1);

                frm13.Show();
                Hide();
                
            }
            if (button5.Text == "Къде се намира о-в Крит?")
            {
                player.Play();
               
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = Correct;

                frm13.Show();
                Hide();
            }
            if (button5.Text == "Къде се намира Айфеловата кула?")
            {
                player.Play();
                
                frm13 = new Form13();
                frm13.passTime1 = Time1;
                frm13.passTime2 = Time2;
                frm13.passTime3 = Time3;
                frm13.passTime4 = Time4;
                frm13.passTime5 = Time5;
                frm13.passTime6 = Time6;
                frm13.passTime7 = Time7;
                frm13.passTime8 = Time8;
                frm13.passTime9 = a;

                frm13.passCorrect = Correct;

                frm13.Show();
                Hide();
            }
        }
    }
}
