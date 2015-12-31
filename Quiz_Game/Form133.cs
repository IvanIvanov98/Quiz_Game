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
    public partial class Form133 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form134 frm134;
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
        public Form133()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form133_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Как се наричали вождовете на славянските племена?";
                button1.Text = "Князе"; // Верният отговор
                button2.Text = "Ханове";
                button3.Text = "Царе";
                button4.Text = "Крале";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой управлява България през VІІІ век?";
                button1.Text = "Калоян";
                button2.Text = "Тервел"; // Верният Отговор
                button3.Text = "Омуртаг";
                button4.Text = "Петър";
            }
            if (q1 == 3)
            {

                button5.Text = "Крепостта Сердика била превзета от хан Крум през?";
                button1.Text = "5 век";
                button2.Text = "7 век";
                button3.Text = "9 век"; // Верният отговор
                button4.Text = "11 век"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Как се наричали вождовете на славянските племена?")
            {
                player1.Play();


                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct + 1;
                frm134.Show();
                Hide();

            }
            if (button5.Text == "Кой управлява България през VІІІ век?")
            {
                player.Play();

                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct;
                frm134.Show();
                Hide();
            }
            if (button5.Text == "Крепостта Сердика била превзета от хан Крум през?")
            {
                player.Play();

                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct;
                frm134.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Как се наричали вождовете на славянските племена?")
            {
                player.Play();


                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct;
                frm134.Show();
                Hide();

            }
            if (button5.Text == "Кой управлява България през VІІІ век?")
            {
                player1.Play();

                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct + 1;
                frm134.Show();
                Hide();
            }
            if (button5.Text == "Крепостта Сердика била превзета от хан Крум през?")
            {
                player.Play();

                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct;
                frm134.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Как се наричали вождовете на славянските племена?")
            {
                player.Play();


                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct;
                frm134.Show();
                Hide();

            }
            if (button5.Text == "Кой управлява България през VІІІ век?")
            {
                player.Play();

                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct;
                frm134.Show();
                Hide();
            }
            if (button5.Text == "Крепостта Сердика била превзета от хан Крум през?")
            {
                player1.Play();

                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct + 1;
                frm134.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Как се наричали вождовете на славянските племена?")
            {
                player.Play();


                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct;
                frm134.Show();
                Hide();

            }
            if (button5.Text == "Кой управлява България през VІІІ век?")
            {
                player.Play();

                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct;
                frm134.Show();
                Hide();
            }
            if (button5.Text == "Крепостта Сердика била превзета от хан Крум през?")
            {
                player.Play();

                frm134 = new Form134();
                frm134.passTime1 = Time1;
                frm134.passTime2 = Time2;
                frm134.passTime3 = Time3;
                frm134.passTime4 = Time4;
                frm134.passTime5 = Time5;
                frm134.passTime6 = Time6;
                frm134.passTime7 = Time7;
                frm134.passTime8 = Time8;
                frm134.passTime9 = a;
                frm134.passCorrect = Correct;
                frm134.Show();
                Hide();
            }
        }
    }
}
