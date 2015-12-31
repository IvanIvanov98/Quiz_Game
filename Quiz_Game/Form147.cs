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
    public partial class Form147 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form148 frm148;
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
        public Form147()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form147_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой жанр възниква от танца менует?";
                button1.Text = "Сюита";
                button2.Text = "Вирле";
                button3.Text = "Скерцо";  // Верният отговор
                button4.Text = "Токата";
            }
            if (q1 == 2)
            {
                button5.Text = "Композиция базирана на фротолата и ренесансовите шансони е?";
                button1.Text = "Мадригал"; // Верният Отговор
                button2.Text = "Багатела";
                button3.Text = "Канцона";
                button4.Text = "Увертюра";
            }
            if (q1 == 3)
            {

                button5.Text = "Семейство тритактови танци от късния Ренесанс и Барока е?";
                button1.Text = "Гавот";
                button2.Text = "Куранта"; // Верният отговор
                button3.Text = "Менует";
                button4.Text = "Сарабанда";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой жанр възниква от танца менует?")
            {
                player.Play();


                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct;
                frm148.Show();
                Hide();

            }
            if (button5.Text == "Композиция базирана на фротолата и ренесансовите шансони е?")
            {
                player1.Play();

                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct + 1;
                frm148.Show();
                Hide();
            }
            if (button5.Text == "Семейство тритактови танци от късния Ренесанс и Барока е?")
            {
                player.Play();

                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct;
                frm148.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой жанр възниква от танца менует?")
            {
                player.Play();


                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct;
                frm148.Show();
                Hide();

            }
            if (button5.Text == "Композиция базирана на фротолата и ренесансовите шансони е?")
            {
                player.Play();

                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct;
                frm148.Show();
                Hide();
            }
            if (button5.Text == "Семейство тритактови танци от късния Ренесанс и Барока е?")
            {
                player1.Play();

                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct + 1;
                frm148.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой жанр възниква от танца менует?")
            {
                player1.Play();


                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct + 1;
                frm148.Show();
                Hide();

            }
            if (button5.Text == "Композиция базирана на фротолата и ренесансовите шансони е?")
            {
                player.Play();

                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct;
                frm148.Show();
                Hide();
            }
            if (button5.Text == "Семейство тритактови танци от късния Ренесанс и Барока е?")
            {
                player.Play();

                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct;
                frm148.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой жанр възниква от танца менует?")
            {
                player.Play();


                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct;
                frm148.Show();
                Hide();

            }
            if (button5.Text == "Композиция базирана на фротолата и ренесансовите шансони е?")
            {
                player.Play();

                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct;
                frm148.Show();
                Hide();
            }
            if (button5.Text == "Семейство тритактови танци от късния Ренесанс и Барока е?")
            {
                player.Play();

                frm148 = new Form148();
                frm148.passTime1 = Time1;
                frm148.passTime2 = Time2;
                frm148.passTime3 = a;
                frm148.passCorrect = Correct;
                frm148.Show();
                Hide();
            }
        }
    }
}
