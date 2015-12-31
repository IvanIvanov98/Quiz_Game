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
    public partial class Form80 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form81 frm81;
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
        public Form80()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor


        }

        private void Form80_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Какво се получава при гликолизата?";
                button1.Text = "Кислород";
                button2.Text = "Глюкоза"; 
                button3.Text = "Лимонена к-на";
                button4.Text = "Пирогроздена к-на"; // Верният Отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Половите жлези при животните са пример за?";
                button1.Text = "Клетка";
                button2.Text = "Тъкан";
                button3.Text = "Орган"; // Верният Отговор
                button4.Text = "С-ма от органи";
            }
            if (q1 == 3)
            {

                button5.Text = "Индивид с еднакви алели на даден ген е?";
                button1.Text = "Хемизиготен";
                button2.Text = "Хомозиготен"; // Верният отговор
                button3.Text = "Хетерозиготен";
                button4.Text = "Хетерогаметен";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво се получава при гликолизата?")
            {
                player.Play();


                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct;
                frm81.Show();
                Hide();

            }
            if (button5.Text == "Половите жлези при животните са пример за?")
            {
                player.Play();

                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct;
                frm81.Show();
                Hide();
            }
            if (button5.Text == "Индивид с еднакви алели на даден ген е?")
            {
                player.Play();

                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct;
                frm81.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво се получава при гликолизата?")
            {
                player.Play();


                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct;
                frm81.Show();
                Hide();

            }
            if (button5.Text == "Половите жлези при животните са пример за?")
            {
                player.Play();

                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct;
                frm81.Show();
                Hide();
            }
            if (button5.Text == "Индивид с еднакви алели на даден ген е?")
            {
                player1.Play();

                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct + 1;
                frm81.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво се получава при гликолизата?")
            {
                player.Play();


                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct;
                frm81.Show();
                Hide();

            }
            if (button5.Text == "Половите жлези при животните са пример за?")
            {
                player1.Play();

                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct + 1;
                frm81.Show();
                Hide();
            }
            if (button5.Text == "Индивид с еднакви алели на даден ген е?")
            {
                player.Play();

                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct;
                frm81.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво се получава при гликолизата?")
            {
                player1.Play();


                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct + 1;
                frm81.Show();
                Hide();

            }
            if (button5.Text == "Половите жлези при животните са пример за?")
            {
                player.Play();

                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct;
                frm81.Show();
                Hide();
            }
            if (button5.Text == "Индивид с еднакви алели на даден ген е?")
            {
                player.Play();

                frm81 = new Form81();
                frm81.passTime1 = Time1;
                frm81.passTime2 = Time2;
                frm81.passTime3 = Time3;
                frm81.passTime4 = Time4;
                frm81.passTime5 = Time5;
                frm81.passTime6 = a;
                frm81.passCorrect = Correct;
                frm81.Show();
                Hide();
            }
        }
    }
}
