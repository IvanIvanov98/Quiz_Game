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
    public partial class Form63 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form64 frm64;
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
        public Form63()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form63_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Вторите олимпйски игри се проведени в?";
                    button1.Text = "Лондон";
                    button2.Text = "Атина";
                    button3.Text = "Париж"; // Верният Отговор
                    button4.Text = "Берлин";
                }
                if (q1 == 2)
                {
                    button5.Text = "Най-доброто класиране на Б-ия в ски бягането е?";
                    button1.Text = "Пето място";
                    button2.Text = "Първо място";
                    button3.Text = "Трето място"; // Верният Отговор
                    button4.Text = "Десето място";
                }
                if (q1 == 3)
                {
                    button5.Text = "Какъв е диаметъра на шайбата в хокея на лед?";
                    button1.Text = "76,2 мм"; // Верният отговор
                    button2.Text = "82,3мм";
                    button3.Text = "67,3мм";
                    button4.Text = "79,7мм";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Вторите олимпйски игри се проведени в?")
            {
                player.Play();
                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct;
                frm64.Show();
                Hide();

            }
            if (button5.Text == "Най-доброто класиране на Б-ия в ски бягането е?")
            {
                player.Play();
                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct;
                frm64.Show();
                Hide();
            }
            if (button5.Text == "Какъв е диаметъра на шайбата в хокея на лед?")
            {
                player1.Play();

                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct + 1;
                frm64.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Вторите олимпйски игри се проведени в?")
            {
                player.Play();
                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct;
                frm64.Show();
                Hide();

            }
            if (button5.Text == "Най-доброто класиране на Б-ия в ски бягането е?")
            {
                player.Play();
                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct;
                frm64.Show();
                Hide();
            }
            if (button5.Text == "Какъв е диаметъра на шайбата в хокея на лед?")
            {
                player.Play();

                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct;
                frm64.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Вторите олимпйски игри се проведени в?")
            {
                player1.Play();
                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct + 1;
                frm64.Show();
                Hide();

            }
            if (button5.Text == "Най-доброто класиране на Б-ия в ски бягането е?")
            {
                player1.Play();
                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct + 1;
                frm64.Show();
                Hide();
            }
            if (button5.Text == "Какъв е диаметъра на шайбата в хокея на лед?")
            {
                player.Play();

                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct;
                frm64.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Вторите олимпйски игри се проведени в?")
            {
                player.Play();
                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct;
                frm64.Show();
                Hide();

            }
            if (button5.Text == "Най-доброто класиране на Б-ия в ски бягането е?")
            {
                player.Play();
                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct;
                frm64.Show();
                Hide();
            }
            if (button5.Text == "Какъв е диаметъра на шайбата в хокея на лед?")
            {
                player.Play();

                
                frm64 = new Form64();
                frm64.passTime1 = Time1;
                frm64.passTime2 = Time2;
                frm64.passTime3 = Time3;
                frm64.passTime4 = Time4;
                frm64.passTime5 = Time5;
                frm64.passTime6 = Time6;
                frm64.passTime7 = Time7;
                frm64.passTime8 = Time8;
                frm64.passTime9 = a;
                frm64.passCorrect = Correct;
                frm64.Show();
                Hide();
            }
        }
    }
}
