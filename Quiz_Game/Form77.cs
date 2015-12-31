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
    public partial class Form77 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form78 frm78;
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

        public Form77()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form77_Load(object sender, EventArgs e)
        {


            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Каква ф-ма имат глобуларните белтъци?";
                button1.Text = "Спираловидна";
                button2.Text = "Кълбовидна"; // Верният Отговор
                button3.Text = "Влакновидна";
                button4.Text = "Нишковидна";
            }
            if (q1 == 2)
            {
                button5.Text = "Кои органели имар малка и голяма частица?";
                button1.Text = "Хлоропластите";
                button2.Text = "Митохондрите";
                button3.Text = "Рибозомите"; // Верният Отговор
                button4.Text = "Лизозомите";
            }
            if (q1 == 3)
            {

                button5.Text = "Преноса на кислород се осеществява от?";
                button1.Text = "Лимфоцитите"; 
                button2.Text = "Гранулоцитите";
                button3.Text = "Еритороцитите"; // Верният отговор
                button4.Text = "Моноцитите";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Каква ф-ма имат глобуларните белтъци?")
            {
                player.Play();


                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct;
                frm78.Show();
                Hide();

            }
            if (button5.Text == "Кои органели имар малка и голяма частица?")
            {
                player.Play();

                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct;
                frm78.Show();
                Hide();
            }
            if (button5.Text == "Преноса на кислород се осеществява от?")
            {
                player.Play();

                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct;
                frm78.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Каква ф-ма имат глобуларните белтъци?")
            {
                player1.Play();


                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct + 1;
                frm78.Show();
                Hide();

            }
            if (button5.Text == "Кои органели имар малка и голяма частица?")
            {
                player.Play();

                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct;
                frm78.Show();
                Hide();
            }
            if (button5.Text == "Преноса на кислород се осеществява от?")
            {
                player.Play();

                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct;
                frm78.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Каква ф-ма имат глобуларните белтъци?")
            {
                player.Play();


                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct;
                frm78.Show();
                Hide();

            }
            if (button5.Text == "Кои органели имар малка и голяма частица?")
            {
                player1.Play();

                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct + 1;
                frm78.Show();
                Hide();
            }
            if (button5.Text == "Преноса на кислород се осеществява от?")
            {
                player1.Play();

                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct + 1;
                frm78.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Каква ф-ма имат глобуларните белтъци?")
            {
                player.Play();


                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct;
                frm78.Show();
                Hide();

            }
            if (button5.Text == "Кои органели имар малка и голяма частица?")
            {
                player.Play();

                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct;
                frm78.Show();
                Hide();
            }
            if (button5.Text == "Преноса на кислород се осеществява от?")
            {
                player.Play();

                frm78 = new Form78();
                frm78.passTime1 = Time1;
                frm78.passTime2 = Time2;
                frm78.passTime3 = a;
                frm78.passCorrect = Correct;
                frm78.Show();
                Hide();
            }
        }
    }
}
