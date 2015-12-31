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
    public partial class Form130 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form131 frm131;
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
        public Form130()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form130_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Коя е най - скъпата валута след края на ПСВ?";
                button1.Text = "Герм.марка"; 
                button2.Text = "Амер.долър"; // Верният отговор
                button3.Text = "Френс.франк";
                button4.Text = "Брит.паунт";
            }
            if (q1 == 2)
            {

                button5.Text = "Страната с най - голяма войска през Бал.война е?";
                button1.Text = "Осман.империя"; // Верният Отговор
                button2.Text = "България"; 
                button3.Text = "Сърбия";
                button4.Text = "Гърция";
            }
            if (q1 == 3)
            {
                button5.Text = "Страната с най - много пораж.след Бал. война е?";
                button1.Text = "България";
                button2.Text = "Гърция";
                button3.Text = "Сърбия";
                button4.Text = "Осман.империя"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е най - скъпата валута след края на ПСВ?")
            {
                player.Play();


                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct;
                frm131.Show();
                Hide();

            }
            if (button5.Text == "Страната с най - голяма войска през Бал.война е?")
            {
                player1.Play();

                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct + 1;
                frm131.Show();
                Hide();
            }
            if (button5.Text == "Страната с най - много пораж.след Бал. война е?")
            {
                player.Play();

                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct;
                frm131.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е най - скъпата валута след края на ПСВ?")
            {
                player1.Play();


                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct + 1;
                frm131.Show();
                Hide();

            }
            if (button5.Text == "Страната с най - голяма войска през Бал.война е?")
            {
                player.Play();

                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct;
                frm131.Show();
                Hide();
            }
            if (button5.Text == "Страната с най - много пораж.след Бал. война е?")
            {
                player.Play();

                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct;
                frm131.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е най - скъпата валута след края на ПСВ?")
            {
                player.Play();


                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct;
                frm131.Show();
                Hide();

            }
            if (button5.Text == "Страната с най - голяма войска през Бал.война е?")
            {
                player.Play();

                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct;
                frm131.Show();
                Hide();
            }
            if (button5.Text == "Страната с най - много пораж.след Бал. война е?")
            {
                player.Play();

                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct;
                frm131.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя е най - скъпата валута след края на ПСВ?")
            {
                player.Play();


                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct;
                frm131.Show();
                Hide();

            }
            if (button5.Text == "Страната с най - голяма войска през Бал.война е?")
            {
                player.Play();

                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct;
                frm131.Show();
                Hide();
            }
            if (button5.Text == "Страната с най - много пораж.след Бал. война е?")
            {
                player1.Play();

                frm131 = new Form131();
                frm131.passTime1 = Time1;
                frm131.passTime2 = Time2;
                frm131.passTime3 = Time3;
                frm131.passTime4 = Time4;
                frm131.passTime5 = Time5;
                frm131.passTime6 = a;
                frm131.passCorrect = Correct + 1;
                frm131.Show();
                Hide();
            }
        }
    }
}
