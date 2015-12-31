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
    public partial class Form106 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form107 frm107;
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
        public Form106()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form106_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Коя година Борис I детронира първородния си син?";
                button1.Text = "892";
                button2.Text = "891";
                button3.Text = "889";
                button4.Text = "893";  // Верният отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Коя год. Русия е обявена за империя?";
                button1.Text = "1721"; // Верният Отговор
                button2.Text = "1715";
                button3.Text = "1730";
                button4.Text = "1728";
            }
            if (q1 == 3)
            {

                button5.Text = "Кой е считан за пол. наследник на Т. Живков?";
                button1.Text = "Антон Югов";
                button2.Text = "Станко Тодоров"; // Верният отговор
                button3.Text = "Людмила Живкова";
                button4.Text = "Намя такъв";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя година Борис I детронира първородния си син?")
            {
                player1.Play();


                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct + 1;
                frm107.Show();
                Hide();

            }
            if (button5.Text == "Коя год. Русия е обявена за империя?")
            {
                player.Play();

                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct;
                frm107.Show();
                Hide();
            }
            if (button5.Text == "Кой е считан за пол. наследник на Т. Живков?")
            {
                player.Play();

                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct;
                frm107.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя година Борис I детронира първородния си син?")
            {
                player.Play();


                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct;
                frm107.Show();
                Hide();

            }
            if (button5.Text == "Коя год. Русия е обявена за империя?")
            {
                player.Play();

                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct;
                frm107.Show();
                Hide();
            }
            if (button5.Text == "Кой е считан за пол. наследник на Т. Живков?")
            {
                player1.Play();

                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct + 1;
                frm107.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя година Борис I детронира първородния си син?")
            {
                player.Play();


                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct;
                frm107.Show();
                Hide();

            }
            if (button5.Text == "Коя год. Русия е обявена за империя?")
            {
                player.Play();

                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct;
                frm107.Show();
                Hide();
            }
            if (button5.Text == "Кой е считан за пол. наследник на Т. Живков?")
            {
                player.Play();

                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct;
                frm107.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя година Борис I детронира първородния си син?")
            {
                player1.Play();


                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct + 1;
                frm107.Show();
                Hide();

            }
            if (button5.Text == "Коя год. Русия е обявена за империя?")
            {
                player.Play();

                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct;
                frm107.Show();
                Hide();
            }
            if (button5.Text == "Кой е считан за пол. наследник на Т. Живков?")
            {
                player.Play();

                frm107 = new Form107();
                frm107.passTime1 = Time1;
                frm107.passTime2 = a;
                frm107.passCorrect = Correct;
                frm107.Show();
                Hide();
            }
        }
    }
}

