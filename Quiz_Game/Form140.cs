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

    public partial class Form140 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form141 frm141;
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
        public Form140()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form140_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Протагонистът в творбата е?";
                button1.Text = "Авторът";
                button2.Text = "Читателят";
                button3.Text = "Основната част";  
                button4.Text = "Главният герой"; // Верният отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Кой автор е познат под псевдонима „Щастливеца“?";
                button1.Text = "Алеко Константинов"; // Верният Отговор
                button2.Text = "Иван Вазов";
                button3.Text = "Пенчо Славейков";
                button4.Text = "Христо Ботев";
            }
            if (q1 == 3)
            {

                button5.Text = "Кой е авторът на книгата „Вполите на Витоша“?";
                button1.Text = "Иван Вазов";
                button2.Text = "Пейо Яворов"; // Верният отговор
                button3.Text = "Петко Славейков";
                button4.Text = "Петко Каравелов";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Протагонистът в творбата е?")
            {
                player.Play();


                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct;
                frm141.Show();
                Hide();

            }
            if (button5.Text == "Кой автор е познат под псевдонима „Щастливеца“?")
            {
                player1.Play();

                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct + 1;
                frm141.Show();
                Hide();
            }
            if (button5.Text == "Кой е авторът на книгата „Вполите на Витоша“?")
            {
                player.Play();

                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct;
                frm141.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Протагонистът в творбата е?")
            {
                player.Play();


                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct;
                frm141.Show();
                Hide();

            }
            if (button5.Text == "Кой автор е познат под псевдонима „Щастливеца“?")
            {
                player.Play();

                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct;
                frm141.Show();
                Hide();
            }
            if (button5.Text == "Кой е авторът на книгата „Вполите на Витоша“?")
            {
                player1.Play();

                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct + 1;
                frm141.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Протагонистът в творбата е?")
            {
                player.Play();


                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct;
                frm141.Show();
                Hide();

            }
            if (button5.Text == "Кой автор е познат под псевдонима „Щастливеца“?")
            {
                player.Play();

                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct;
                frm141.Show();
                Hide();
            }
            if (button5.Text == "Кой е авторът на книгата „Вполите на Витоша“?")
            {
                player.Play();

                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct;
                frm141.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Протагонистът в творбата е?")
            {
                player1.Play();


                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct + 1;
                frm141.Show();
                Hide();

            }
            if (button5.Text == "Кой автор е познат под псевдонима „Щастливеца“?")
            {
                player.Play();

                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct;
                frm141.Show();
                Hide();
            }
            if (button5.Text == "Кой е авторът на книгата „Вполите на Витоша“?")
            {
                player.Play();

                frm141 = new Form141();
                frm141.passTime1 = Time1;
                frm141.passTime2 = Time2;
                frm141.passTime3 = Time3;
                frm141.passTime4 = Time4;
                frm141.passTime5 = Time5;
                frm141.passTime6 = a;
                frm141.passCorrect = Correct;
                frm141.Show();
                Hide();
            }
        }
    }
}
