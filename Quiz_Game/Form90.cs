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
    public partial class Form90 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form91 frm91;
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

        public Form90()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form90_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Какво е делението на половите клетки?";
                button1.Text = "Мейоза"; // Верният отговор
                button2.Text = "Митоза";
                button3.Text = "Амитоза";
                button4.Text = "Безполово";
            }
            if (q1 == 2)
            {
                button5.Text = "Крайни продукти на транслацията са?";
                button1.Text = "Белтъци";
                button2.Text = "ДНК";
                button3.Text = "Аминокислеини";
                button4.Text = "РНК";   // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Къде се пренася инф. за синтез на белтъци?";
                button1.Text = "Рибозомите";
                button2.Text = "иРНК"; // Верният отговор
                button3.Text = "тРНК";
                button4.Text = "Лизозомите"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво е делението на половите клетки?")
            {
                player1.Play();


                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct + 1;
                frm91.Show();
                Hide();

            }
            if (button5.Text == "Крайни продукти на транслацията са?")
            {
                player.Play();

                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct;
                frm91.Show();
                Hide();
            }
            if (button5.Text == "Къде се пренася инф. за синтез на белтъци?")
            {
                player.Play();

                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct;
                frm91.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво е делението на половите клетки?")
            {
                player.Play();


                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct;
                frm91.Show();
                Hide();

            }
            if (button5.Text == "Крайни продукти на транслацията са?")
            {
                player.Play();

                frm91 = new Form91();
                    frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct;
                frm91.Show();
                Hide();
            }
            if (button5.Text == "Къде се пренася инф. за синтез на белтъци?")
            {
                player1.Play();

                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct + 1;
                frm91.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво е делението на половите клетки?")
            {
                player.Play();


                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct;
                frm91.Show();
                Hide();

            }
            if (button5.Text == "Крайни продукти на транслацията са?")
            {
                player.Play();

                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct;
                frm91.Show();
                Hide();
            }
            if (button5.Text == "Къде се пренася инф. за синтез на белтъци?")
            {
                player.Play();

                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct;
                frm91.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво е делението на половите клетки?")
            {
                player.Play();


                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct;
                frm91.Show();
                Hide();

            }
            if (button5.Text == "Крайни продукти на транслацията са?")
            {
                player1.Play();

                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct + 1;
                frm91.Show();
                Hide();
            }
            if (button5.Text == "Къде се пренася инф. за синтез на белтъци?")
            {
                player.Play();

                frm91 = new Form91();
                frm91.passTime1 = Time1;
                frm91.passTime2 = Time2;
                frm91.passTime3 = Time3;
                frm91.passTime4 = Time4;
                frm91.passTime5 = Time5;
                frm91.passTime6 = a;
                frm91.passCorrect = Correct;
                frm91.Show();
                Hide();
            }
        }
    }
}
