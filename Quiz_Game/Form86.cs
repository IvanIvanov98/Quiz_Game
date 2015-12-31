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
    public partial class Form86 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form87 frm87;
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
        public Form86()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form86_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "От какво се състоят микрокапсулите?";
                button1.Text = "хомополизахарид"; 
                button2.Text = "олигозахарид";
                button3.Text = "монозахарид";
                button4.Text = "хетерополизахарид"; // Верният Отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Кое е причинител на холерата?";
                button1.Text = "Спирили";
                button2.Text = "Вибриони"; // Верният Отговор
                button3.Text = "Спирохети";
                button4.Text = "Нито едно";
            }
            if (q1 == 3)
            {

                button5.Text = "Кое е причинител на сифилиса?";
                button1.Text = "Спирохети"; // Верният отговор
                button2.Text = "Вибриони";
                button3.Text = "Спирили";
                button4.Text = "Нито едно";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "От какво се състоят микрокапсулите?")
            {
                player.Play();


                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct;
                frm87.Show();
                Hide();

            }
            if (button5.Text == "Кое е причинител на холерата?")
            {
                player.Play();

                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct;
                frm87.Show();
                Hide();
            }
            if (button5.Text == "Кое е причинител на сифилиса?")
            {
                player1.Play();

                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct + 1;
                frm87.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "От какво се състоят микрокапсулите?")
            {
                player.Play();


                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct;
                frm87.Show();
                Hide();

            }
            if (button5.Text == "Кое е причинител на холерата?")
            {
                player1.Play();

                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct + 1;
                frm87.Show();
                Hide();
            }
            if (button5.Text == "Кое е причинител на сифилиса?")
            {
                player.Play();

                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct;
                frm87.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "От какво се състоят микрокапсулите?")
            {
                player.Play();


                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct;
                frm87.Show();
                Hide();

            }
            if (button5.Text == "Кое е причинител на холерата?")
            {
                player.Play();

                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct;
                frm87.Show();
                Hide();
            }
            if (button5.Text == "Кое е причинител на сифилиса?")
            {
                player.Play();

                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct;
                frm87.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "От какво се състоят микрокапсулите?")
            {
                player1.Play();


                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct + 1;
                frm87.Show();
                Hide();

            }
            if (button5.Text == "Кое е причинител на холерата?")
            {
                player.Play();

                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct;
                frm87.Show();
                Hide();
            }
            if (button5.Text == "Кое е причинител на сифилиса?")
            {
                player.Play();

                frm87 = new Form87();
                frm87.passTime1 = Time1;
                frm87.passTime2 = a;
                frm87.passCorrect = Correct;
                frm87.Show();
                Hide();
            }
        }
    }
}
