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
    public partial class Form153 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form154 frm154;
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
        public Form153()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form153_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Къде е роден Верди?";
                button1.Text = "Милано";
                button2.Text = "Париж";
                button3.Text = "Ронколе";  // Верният отговор
                button4.Text = "Залцбург";
            }
            if (q1 == 2)
            {
                button5.Text = "Улрих Конрад разкрива системата за писане на произведения на?";
                button1.Text = "Бетховен"; 
                button2.Text = "Моцарт"; // Верният Отговор
                button3.Text = "Доницети";
                button4.Text = "Росини";
            }
            if (q1 == 3)
            {

                button5.Text = "Коя е първата опера на Шарл Гуно?";
                button1.Text = "„Сафо“"; // Верният отговор
                button2.Text = "„Орфеон“"; 
                button3.Text = "„Фауст“";
                button4.Text = "„Лекар“";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Къде е роден Верди?")
            {
                player.Play();


                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct;
                frm154.Show();
                Hide();

            }
            if (button5.Text == "Улрих Конрад разкрива системата за писане на произведения на?")
            {
                player.Play();

                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct;
                frm154.Show();
                Hide();
            }
            if (button5.Text == "Коя е първата опера на Шарл Гуно?")
            {
                player1.Play();

                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct + 1;
                frm154.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Къде е роден Верди?")
            {
                player.Play();


                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct;
                frm154.Show();
                Hide();

            }
            if (button5.Text == "Улрих Конрад разкрива системата за писане на произведения на?")
            {
                player1.Play();

                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct + 1;
                frm154.Show();
                Hide();
            }
            if (button5.Text == "Коя е първата опера на Шарл Гуно?")
            {
                player.Play();

                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct;
                frm154.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Къде е роден Верди?")
            {
                player1.Play();


                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct + 1;
                frm154.Show();
                Hide();

            }
            if (button5.Text == "Улрих Конрад разкрива системата за писане на произведения на?")
            {
                player.Play();

                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct;
                frm154.Show();
                Hide();
            }
            if (button5.Text == "Коя е първата опера на Шарл Гуно?")
            {
                player.Play();

                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct;
                frm154.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Къде е роден Верди?")
            {
                player.Play();


                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct;
                frm154.Show();
                Hide();

            }
            if (button5.Text == "Улрих Конрад разкрива системата за писане на произведения на?")
            {
                player.Play();

                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct;
                frm154.Show();
                Hide();
            }
            if (button5.Text == "Коя е първата опера на Шарл Гуно?")
            {
                player.Play();

                frm154 = new Form154();
                frm154.passTime1 = Time1;
                frm154.passTime2 = Time2;
                frm154.passTime3 = Time3;
                frm154.passTime4 = Time4;
                frm154.passTime5 = Time5;
                frm154.passTime6 = Time6;
                frm154.passTime7 = Time7;
                frm154.passTime8 = Time8;
                frm154.passTime9 = a;
                frm154.passCorrect = Correct;
                frm154.Show();
                Hide();
            }
        }
    }
}
