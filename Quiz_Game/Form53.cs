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
    public partial class Form53 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form54 frm54;
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
        public Form53()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form53_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Световен шампион във Формула 1 за 2014 е?";
                    button1.Text = "Кими Райконен";
                    button2.Text = "Луис Хамилтън"; // Верният Отговор
                    button3.Text = "Мика Хакинен";
                    button4.Text = "Себастиан Фетел"; 
                }
                if (q1 == 2)
                {
                    button5.Text = "Тенисистът с най-много титли от големия шлем е?";
                    button1.Text = "Новак Джокович"; 
                    button2.Text = "Джони Иснър";
                    button3.Text = "Роджър Федерер"; // Верният Отговор
                    button4.Text = "Давид Ферер";
                }
                if (q1 == 3)
                {
                    button5.Text = "С каква националност е Новак Джокович?";
                    button1.Text = "Американска";
                    button2.Text = "Македонска";
                    button3.Text = "Словашка";
                    button4.Text = "Сръбска"; // Верният отговор
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Световен шампион във Формула 1 за 2014 е?")
            {

                player.Play();

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct;
                frm54.Show();
                Hide();

            }
            if (button5.Text == "Тенисистът с най-много титли от големия шлем е?")
            {
                player.Play();   

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct;
                frm54.Show();
                Hide();
            }
            if (button5.Text == "С каква националност е Новак Джокович?")
            {

                player.Play();

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct;
                frm54.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Световен шампион във Формула 1 за 2014 е?")
            {

                player1.Play();   //Верен отговор

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct + 1;
                frm54.Show();
                Hide();

            }
            if (button5.Text == "Тенисистът с най-много титли от големия шлем е?")
            {
                player.Play();   

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct;
                frm54.Show();
                Hide();
            }
            if (button5.Text == "С каква националност е Новак Джокович?")
            {

                player.Play();

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct;
                frm54.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Световен шампион във Формула 1 за 2014 е?")
            {

                player.Play();

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct + 1;
                frm54.Show();
                Hide();

            }
            if (button5.Text == "Тенисистът с най-много титли от големия шлем е?")
            {
                player1.Play();   //Верен отговор

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct;
                frm54.Show();
                Hide();
            }
            if (button5.Text == "С каква националност е Новак Джокович?")
            {

                player.Play();

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct;
                frm54.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Световен шампион във Формула 1 за 2014 е?")
            {

                player.Play();

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct;
                frm54.Show();
                Hide();

            }
            if (button5.Text == "Тенисистът с най-много титли от големия шлем е?")
            {
                player.Play();  

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct;
                frm54.Show();
                Hide();
            }
            if (button5.Text == "С каква националност е Новак Джокович?")
            {

                player1.Play();   //Верен отговор

                
                frm54 = new Form54();
                frm54.passTime1 = Time1;
                frm54.passTime2 = Time2;
                frm54.passTime3 = Time3;
                frm54.passTime4 = Time4;
                frm54.passTime5 = Time5;
                frm54.passTime6 = Time6;
                frm54.passTime7 = Time7;
                frm54.passTime8 = Time8;
                frm54.passTime9 = a;
                frm54.passCorrect = Correct + 1;
                frm54.Show();
                Hide();
            }
        }
    }
}
