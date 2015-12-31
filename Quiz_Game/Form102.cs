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
    public partial class Form102 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form103 frm103;
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
        public Form102()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form102_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой от изброените не е управлявал България?";
                button1.Text = "Симеон"; 
                button2.Text = "Самуил";
                button3.Text = "Тодор Живков";
                button4.Text = "Роси"; // Верният отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Коя от следните държави е воювала с Германия?";
                button1.Text = "Италия"; 
                button2.Text = "България";
                button3.Text = "ЮАР";
                button4.Text = "Англия"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "През II световна война Англия е в съюз с?";
                button1.Text = "Америка"; // Верният отговор
                button2.Text = "Италия";
                button3.Text = "Германия"; 
                button4.Text = "Бразилия";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от изброените не е управлявал България?")
            {
                player.Play();


                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct;
                frm103.Show();
                Hide();

            }
            if (button5.Text == "Коя от следните държави е воювала с Германия?")
            {
                player.Play();

                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct;
                frm103.Show();
                Hide();
            }
            if (button5.Text == "През II световна война Англия е в съюз с?")
            {
                player1.Play(); // Верният отговор

                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct + 1;
                frm103.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от изброените не е управлявал България?")
            {
                player.Play();


                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct;
                frm103.Show();
                Hide();

            }
            if (button5.Text == "Коя от следните държави е воювала с Германия?")
            {
                player.Play();

                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct;
                frm103.Show();
                Hide();
            }
            if (button5.Text == "През II световна война Англия е в съюз с?")
            {
                player.Play();

                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct;
                frm103.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от изброените не е управлявал България?")
            {
                player.Play();


                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct;
                frm103.Show();
                Hide();

            }
            if (button5.Text == "Коя от следните държави е воювала с Германия?")
            {
                player.Play();

                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct;
                frm103.Show();
                Hide();
            }
            if (button5.Text == "През II световна война Англия е в съюз с?")
            {
                player.Play();

                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct;
                frm103.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от изброените не е управлявал България?")
            {
                player1.Play(); // Верният отговор


                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct + 1;
                frm103.Show();
                Hide();

            }
            if (button5.Text == "Коя от следните държави е воювала с Германия?")
            {
                player1.Play(); // Верният отговор

                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct + 1;
                frm103.Show();
                Hide();
            }
            if (button5.Text == "През II световна война Англия е в съюз с?")
            {
                player.Play();

                frm103 = new Form103();
                frm103.passTime1 = Time1;
                frm103.passTime2 = Time2;
                frm103.passTime3 = Time3;
                frm103.passTime4 = Time4;
                frm103.passTime5 = Time5;
                frm103.passTime6 = Time6;
                frm103.passTime7 = Time7;
                frm103.passTime8 = a;
                frm103.passCorrect = Correct;
                frm103.Show();
                Hide();
            }
        }
    }
}
