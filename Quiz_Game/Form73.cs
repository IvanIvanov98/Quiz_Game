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
    public partial class Form73 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form74 frm74;
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
        public Form73()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form73_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Вътрешното ухо е част от?";
                button1.Text = "Окото";
                button2.Text = "Ухото"; // Верният Отговор
                button3.Text = "Ръката";
                button4.Text = "Крака";
            }
            if (q1 == 2)
            {
                button5.Text = "От какво е част зеницата?";
                button1.Text = "Окото"; // Верният Отговор
                button2.Text = "Ухото";
                button3.Text = "Мозъка";
                button4.Text = "Кожата"; 
            }
            if (q1 == 3)
            {

                button5.Text = "Стомаха е част от коя с - ма ?";
                button1.Text = "Сърдечната"; 
                button2.Text = "Дихателната";
                button3.Text = "Хранителната"; // Верният отговор
                button4.Text = "Отделителната";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Вътрешното ухо е част от?")
            {
                player.Play();


                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct;
                frm74.Show();
                Hide();

            }
            if (button5.Text == "От какво е част зеницата?")
            {
                player1.Play(); // Верният отговор

                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct + 1;
                frm74.Show();
                Hide();
            }
            if (button5.Text == "Стомаха е част от коя с - ма ?")
            {
                player.Play(); 

                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct;
                frm74.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Вътрешното ухо е част от?")
            {
                player1.Play(); // Верният отговор


                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct + 1;
                frm74.Show();
                Hide();

            }
            if (button5.Text == "От какво е част зеницата?")
            {
                player.Play();

                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct;
                frm74.Show();
                Hide();
            }
            if (button5.Text == "Стомаха е част от коя с - ма ?")
            {
                player.Play();

                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct;
                frm74.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Вътрешното ухо е част от?")
            {
                player.Play();


                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct;
                frm74.Show();
                Hide();

            }
            if (button5.Text == "От какво е част зеницата?")
            {
                player.Play();

                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct;
                frm74.Show();
                Hide();
            }
            if (button5.Text == "Стомаха е част от коя с - ма ?")
            {
                player1.Play(); // Верният отговор

                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct + 1;
                frm74.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Вътрешното ухо е част от?")
            {
                player.Play();


                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct;
                frm74.Show();
                Hide();

            }
            if (button5.Text == "От какво е част зеницата?")
            {
                player.Play();

                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct;
                frm74.Show();
                Hide();
            }
            if (button5.Text == "Стомаха е част от коя с - ма ?")
            {
                player.Play();

                frm74 = new Form74();
                frm74.passTime1 = Time1;
                frm74.passTime2 = Time2;
                frm74.passTime3 = Time3;
                frm74.passTime4 = Time4;
                frm74.passTime5 = Time5;
                frm74.passTime6 = Time6;
                frm74.passTime7 = Time7;
                frm74.passTime8 = Time8;
                frm74.passTime9 = a;
                frm74.passCorrect = Correct;
                frm74.Show();
                Hide();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
