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
    public partial class Form43 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form44 frm44;
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
        public Form43()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form43_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Кой е вечният съперник на ПФК „Левски“?";
                    button1.Text = "Стойчо";
                    button2.Text = "Терориста";
                    button3.Text = "ПФК „ЦСКА“";  // Верният Отговор
                    button4.Text = "Треньора";
                }
                if (q1 == 2)
                {
                    button5.Text = "В кой спорт играчите местат фигури на дъска?";
                    button1.Text = "Шах"; // Верният Отговор
                    button2.Text = "Баскетбол";
                    button3.Text = "Футбол";
                    button4.Text = "Бокс"; 
                }
                if (q1 == 3)
                {
                    button5.Text = "Лионел Меси е?";
                    button1.Text = "Учител";
                    button2.Text = "ТВ водещ";
                    button3.Text = "Футболист"; // Верният отговор
                    button4.Text = "Магазинер";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е вечният съперник на ПФК „Левски“?")
            {

                player.Play();

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct;
                frm44.Show();
                Hide();

            }
            if (button5.Text == "В кой спорт играчите местат фигури на дъска?")
            {
                player1.Play();   //Верен отговор

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct + 1;
                frm44.Show();
                Hide();
            }
            if (button5.Text == "Лионел Меси е?")
            {
                player.Play();

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct;
                frm44.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е вечният съперник на ПФК „Левски“?")
            {
                player.Play();

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct;
                frm44.Show();
                Hide();

            }
            if (button5.Text == "В кой спорт играчите местат фигури на дъска?")
            {
                player.Play();

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct;
                frm44.Show();
                Hide();
            }
            if (button5.Text == "Лионел Меси е?")
            {
                player.Play();

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct;
                frm44.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е вечният съперник на ПФК „Левски“?")
            {
                player1.Play();   //Верен отговор

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct + 1;
                frm44.Show();
                Hide();

            }
            if (button5.Text == "В кой спорт играчите местат фигури на дъска?")
            {
                player.Play();

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct;
                frm44.Show();
                Hide();
            }
            if (button5.Text == "Лионел Меси е?")
            {
                player1.Play();   //Верен отговор

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct + 1;
                frm44.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е вечният съперник на ПФК „Левски“?")
            {
                player.Play();

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct;
                frm44.Show();
                Hide();

            }
            if (button5.Text == "В кой спорт играчите местат фигури на дъска?")
            {
                player.Play();

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct;
                frm44.Show();
                Hide();
            }
            if (button5.Text == "Лионел Меси е?")
            {
                player.Play();

                
                frm44 = new Form44();
                frm44.passTime1 = Time1;
                frm44.passTime2 = Time2;
                frm44.passTime3 = Time3;
                frm44.passTime4 = Time4;
                frm44.passTime5 = Time5;
                frm44.passTime6 = Time6;
                frm44.passTime7 = Time7;
                frm44.passTime8 = Time8;
                frm44.passTime9 = a;
                frm44.passCorrect = Correct;
                frm44.Show();
                Hide();
            }
        }
    }
}
