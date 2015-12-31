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
    public partial class Form101 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form102 frm102;
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
        public Form101()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form101_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Йосив Сталин е управлявал коя държава?";
                button1.Text = "Русия"; // Верният отговор
                button2.Text = "Германия";
                button3.Text = "Турция";
                button4.Text = "България";
            }
            if (q1 == 2)
            {
                button5.Text = "Коя е била първата столица на българската?";
                button1.Text = "София"; 
                button2.Text = "Плиска"; // Верният Отговор
                button3.Text = "Варна";
                button4.Text = "Бургас";
            }
            if (q1 == 3)
            {

                button5.Text = "Кой е създал българските закони?";
                button1.Text = "Крум";  // Верният отговор
                button2.Text = "Тервел";
                button3.Text = "Аспарух";
                button4.Text = "Извънземно";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Йосив Сталин е управлявал коя държава?")
            {
                player1.Play(); // Верният отговор


                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct + 1;
                frm102.Show();
                Hide();

            }
            if (button5.Text == "Коя е била първата столица на българската?")
            {
                player.Play();

                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct;
                frm102.Show();
                Hide();
            }
            if (button5.Text == "Кой е създал българските закони?")
            {
                player1.Play(); // Верният отговор

                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct + 1;
                frm102.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Йосив Сталин е управлявал коя държава?")
            {
                player.Play();


                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct;
                frm102.Show();
                Hide();

            }
            if (button5.Text == "Коя е била първата столица на българската?")
            {
                player1.Play(); // Верният отговор

                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct + 1;
                frm102.Show();
                Hide();
            }
            if (button5.Text == "Кой е създал българските закони?")
            {
                player.Play();

                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct;
                frm102.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Йосив Сталин е управлявал коя държава?")
            {
                player.Play();


                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct;
                frm102.Show();
                Hide();

            }
            if (button5.Text == "Коя е била първата столица на българската?")
            {
                player.Play();

                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct;
                frm102.Show();
                Hide();
            }
            if (button5.Text == "Кой е създал българските закони?")
            {
                player.Play();

                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct;
                frm102.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Йосив Сталин е управлявал коя държава?")
            {
                player.Play();


                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct;
                frm102.Show();
                Hide();

            }
            if (button5.Text == "Коя е била първата столица на българската?")
            {
                player.Play();

                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct;
                frm102.Show();
                Hide();
            }
            if (button5.Text == "Кой е създал българските закони?")
            {
                player.Play();

                frm102 = new Form102();
                frm102.passTime1 = Time1;
                frm102.passTime2 = Time2;
                frm102.passTime3 = Time3;
                frm102.passTime4 = Time4;
                frm102.passTime5 = Time5;
                frm102.passTime6 = Time6;
                frm102.passTime7 = a;
                frm102.passCorrect = Correct;
                frm102.Show();
                Hide();
            }
        }
    }
}
