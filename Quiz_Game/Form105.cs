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
    public partial class Form105 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form106 frm106;
        int a = 0;
        int Correct = 0;
        public Form105()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form105_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "През I св. война Русия нападе първо?";
                button1.Text = "Прусия";  // Верният отговор
                button2.Text = "Германия";
                button3.Text = "Белгия";
                button4.Text = "Полша";
            }
            if (q1 == 2)
            {
                button5.Text = "Според версайския договор Германия дължи?";
                button1.Text = "18 млр. марки";
                button2.Text = "132 млр. марки";  // Верният Отговор
                button3.Text = "5 млр. марки";
                button4.Text = "24 млр.марки";
            }
            if (q1 == 3)
            {

                button5.Text = "През кой месец на 1848г. избухва Френ. революция?";
                button1.Text = "Март";
                button2.Text = "Април";
                button3.Text = "Февруари";  // Верният отговор
                button4.Text = "Януари";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През I св. война Русия нападе първо?")
            {
                player1.Play();


                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct + 1;
                frm106.Show();
                Hide();

            }
            if (button5.Text == "Според версайския договор Германия дължи?")
            {
                player.Play();

                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct;
                frm106.Show();
                Hide();
            }
            if (button5.Text == "През кой месец на 1848г. избухва Френ. революция?")
            {
                player.Play();

                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct;
                frm106.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През I св. война Русия нападе първо?")
            {
                player.Play();


                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct;
                frm106.Show();
                Hide();

            }
            if (button5.Text == "Според версайския договор Германия дължи?")
            {
                player1.Play();

                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct + 1;
                frm106.Show();
                Hide();
            }
            if (button5.Text == "През кой месец на 1848г. избухва Френ. революция?")
            {
                player.Play();

                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct;
                frm106.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През I св. война Русия нападе първо?")
            {
                player.Play();


                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct;
                frm106.Show();
                Hide();

            }
            if (button5.Text == "Според версайския договор Германия дължи?")
            {
                player.Play();

                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct;
                frm106.Show();
                Hide();
            }
            if (button5.Text == "През кой месец на 1848г. избухва Френ. революция?")
            {
                player1.Play();

                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct + 1;
                frm106.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "През I св. война Русия нападе първо?")
            {
                player.Play();


                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct;
                frm106.Show();
                Hide();

            }
            if (button5.Text == "Според версайския договор Германия дължи?")
            {
                player.Play();

                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct;
                frm106.Show();
                Hide();
            }
            if (button5.Text == "През кой месец на 1848г. избухва Френ. революция?")
            {
                player.Play();

                frm106 = new Form106();
                frm106.passTime1 = a;
                frm106.passCorrect = Correct;
                frm106.Show();
                Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString(); 
        }
    }
}
