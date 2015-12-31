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
    public partial class Form125 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form126 frm126;
        int a = 0;
        int Correct = 0;
        public Form125()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form125_Load(object sender, EventArgs e)
        {

             
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кога се извършва Съединението?";
                button1.Text = "1884";  
                button2.Text = "1886";
                button3.Text = "1885"; // Верният отговор
                button4.Text = "1887";
            }
            if (q1 == 2)
            {
                button5.Text = "След Берлинският договор Б-ия е разделена на?";
                button1.Text = "5 части";
                button2.Text = "3 части"; // Верният Отговор
                button3.Text = "2 части";
                button4.Text = "4 части";
            }
            if (q1 == 3)
            {
                button5.Text = "При кой цар се състои битката при Ахелой?";
                button1.Text = "„Петър I";
                button2.Text = "Борис I";
                button3.Text = "Симеон I"; // Верният отговор
                button4.Text = "Борис III";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кога се извършва Съединението?")
            {
                player.Play();


                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct;
                frm126.Show();
                Hide();

            }
            if (button5.Text == "След Берлинският договор Б-ия е разделена на?")
            {
                player.Play();

                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct;
                frm126.Show();
                Hide();
            }
            if (button5.Text == "При кой цар се състои битката при Ахелой?")
            {
                player.Play();

                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct;
                frm126.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кога се извършва Съединението?")
            {
                player.Play();


                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct;
                frm126.Show();
                Hide();

            }
            if (button5.Text == "След Берлинският договор Б-ия е разделена на?")
            {
                player1.Play();

                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct + 1;
                frm126.Show();
                Hide();
            }
            if (button5.Text == "При кой цар се състои битката при Ахелой?")
            {
                player.Play();

                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct;
                frm126.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button5.Text == "Кога се извършва Съединението?")
            {
                player1.Play();


                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct + 1;
                frm126.Show();
                Hide();

            }
            if (button5.Text == "След Берлинският договор Б-ия е разделена на?")
            {
                player.Play();

                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct;
                frm126.Show();
                Hide();
            }
            if (button5.Text == "При кой цар се състои битката при Ахелой?")
            {
                player1.Play();

                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct + 1;
                frm126.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кога се извършва Съединението?")
            {
                player.Play();


                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct;
                frm126.Show();
                Hide();

            }
            if (button5.Text == "След Берлинският договор Б-ия е разделена на?")
            {
                player.Play();

                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct;
                frm126.Show();
                Hide();
            }
            if (button5.Text == "При кой цар се състои битката при Ахелой?")
            {
                player.Play();

                frm126 = new Form126();
                frm126.passTime1 = a;
                frm126.passCorrect = Correct;
                frm126.Show();
                Hide();
            }
        }
    }
}
