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
    public partial class Form108 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form109 frm109;
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
        public Form108()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form108_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "При кой владетел Византия има най-голяма териториалност?";
                button1.Text = "Теодосий";
                button2.Text = "Ираклий";
                button3.Text = "Юстиниaн I"; // Верният отговор
                button4.Text = "Маврикий";
            }
            if (q1 == 2)
            {
                button5.Text = "В кой град Александър Македонски умира?";
                button1.Text = "Египет";
                button2.Text = "Вавилон"; // Верният Отговор
                button3.Text = "Никея";
                button4.Text = "Буцефалия";
            }
            if (q1 == 3)
            {

                button5.Text = "Прибл. колко роби участват в строежа на Константинопол?";
                button1.Text = "1млн";  // Верният отговор
                button2.Text = "2млн";
                button3.Text = "200 000";
                button4.Text = "650 000";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "При кой владетел Византия има най-голяма териториалност?")
            {
                player.Play();


                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct;
                frm109.Show();
                Hide();

            }
            if (button5.Text == "В кой град Александър Македонски умира?")
            {
                player.Play();

                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct;
                frm109.Show();
                Hide();
            }
            if (button5.Text == "Прибл. колко роби участват в строежа на Константинопол?")
            {
                player1.Play();

                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct + 1;
                frm109.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "При кой владетел Византия има най-голяма териториалност?")
            {
                player.Play();


                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct;
                frm109.Show();
                Hide();

            }
            if (button5.Text == "В кой град Александър Македонски умира?")
            {
                player1.Play();

                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct  + 1;
                frm109.Show();
                Hide();
            }
            if (button5.Text == "Прибл. колко роби участват в строежа на Константинопол?")
            {
                player.Play();

                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct;
                frm109.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "При кой владетел Византия има най-голяма териториалност?")
            {
                player1.Play();


                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct + 1;
                frm109.Show();
                Hide();

            }
            if (button5.Text == "В кой град Александър Македонски умира?")
            {
                player.Play();

                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct;
                frm109.Show();
                Hide();
            }
            if (button5.Text == "Прибл. колко роби участват в строежа на Константинопол?")
            {
                player.Play();

                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct;
                frm109.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "При кой владетел Византия има най-голяма териториалност?")
            {
                player.Play();


                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct;
                frm109.Show();
                Hide();

            }
            if (button5.Text == "В кой град Александър Македонски умира?")
            {
                player.Play();

                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct;
                frm109.Show();
                Hide();
            }
            if (button5.Text == "Прибл. колко роби участват в строежа на Константинопол?")
            {
                player.Play();


                frm109 = new Form109();
                frm109.passTime1 = Time1;
                frm109.passTime2 = Time2;
                frm109.passTime3 = Time3;
                frm109.passTime4 = a;
                frm109.passCorrect = Correct;
                frm109.Show();
                Hide();
            }
        }
    }
}
