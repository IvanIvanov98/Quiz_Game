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
    public partial class Form7 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form8 frm8;
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
        public Form7()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Коя е столицата на Гърция?";
                button1.Text = "Берлин";
                button2.Text = "Атина"; // Верният Отговор
                button3.Text = "Париж";
                button4.Text = "Рим";
            }
            if (q1 == 2)
            {
                button5.Text = "Коя е столицата на Сърбия?";
                button1.Text = "Белград"; // Верният Отговор 
                button2.Text = "Будапеща";
                button3.Text = "Стокхолм";
                button4.Text = "Варшава";
            }
            if (q1 == 3)
            {
                button5.Text = "Коя е столицата на Италия?";
                button1.Text = "Неапол";
                button2.Text = "Рим"; // Верният отговор
                button3.Text = "Берн";  
                button4.Text = "Тунис";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на Гърция?")
            {
                player.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = Correct ;

                frm8.Show();
                Hide();

            }
            if (button5.Text == "Коя е столицата на Сърбия?")
            {
                player1.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = (Correct + 1);

                frm8.Show();
                Hide();
            }
            if (button5.Text == "Коя е столицата на Италия?")
            {
                player.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;
                frm8.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на Гърция?")
            {
                player1.Play();


                
                frm8 = new Form8();
                frm8.passTime1 = Time1; // PRashtaaaaaaaaaaaam
                frm8.passTime2 = Time2; // Prastham 2
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = (Correct + 1);

                frm8.Show();
                Hide();
                
            }
            if (button5.Text == "Коя е столицата на Сърбия?")
            {
                player.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = Correct;

                frm8.Show();
                Hide();
            }
            if (button5.Text == "Коя е столицата на Италия?")
            {
                player1.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = (Correct + 1);

                frm8.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на Гърция?")
            {
                player.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = Correct;

                frm8.Show();
                Hide();

            }
            if (button5.Text == "Коя е столицата на Сърбия?")
            {
                player.Play();
                
                frm8 = new Form8();
                frm8.Show();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = Correct;

                Hide();
            }
            if (button5.Text == "Коя е столицата на Италия?")
            {
                player.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = Correct;

                frm8.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е столицата на Гърция?")
            {
                player.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = Correct;

                frm8.Show();
                Hide();

            }
            if (button5.Text == "Коя е столицата на Сърбия?")
            {
                player.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = Correct;

                frm8.Show();
                Hide();
            }
            if (button5.Text == "Коя е столицата на Италия?")
            {
                player.Play();
                
                frm8 = new Form8();
                frm8.passTime1 = Time1;
                frm8.passTime2 = Time2;
                frm8.passTime3 = Time3;
                frm8.passTime4 = a;

                frm8.passCorrect = Correct;

                frm8.Show();
                Hide();
            }
        }
    }
}
