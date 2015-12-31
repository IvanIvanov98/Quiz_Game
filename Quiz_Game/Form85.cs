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
    public partial class Form85 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form86 frm86;
        int a = 0;
        int Correct = 0;
        public Form85()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form85_Load(object sender, EventArgs e)
        {

            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "На колко групи се разделя царство Монера?";
                button1.Text = "2"; // Верният Отговор
                button2.Text = "3";
                button3.Text = "4"; 
                button4.Text = "5";
            }
            if (q1 == 2)
            {
                button5.Text = "От кое царство е групата на еубактериите?";
                button1.Text = "Протиста";
                button2.Text = "Монера"; // Верният Отговор
                button3.Text = "Растения"; 
                button4.Text = "Гъби";
            }
            if (q1 == 3)
            {

                button5.Text = "От кого е въведен терминът протисти?";
                button1.Text = "Ернст Хекел"; // Верният отговор
                button2.Text = "Чарлз Дарвин";
                button3.Text = "Мигула";
                button4.Text = "Даусон";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "На колко групи се разделя царство Монера?")
            {
                player1.Play();


                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct + 1;
                frm86.Show();
                Hide();

            }
            if (button5.Text == "От кое царство е групата на еубактериите?")
            {
                player.Play();

                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct;
                frm86.Show();
                Hide();
            }
            if (button5.Text == "От кого е въведен терминът протисти?")
            {
                player1.Play();

                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct + 1;
                frm86.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "На колко групи се разделя царство Монера?")
            {
                player.Play();


                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct;
                frm86.Show();
                Hide();

            }
            if (button5.Text == "От кое царство е групата на еубактериите?")
            {
                player1.Play();

                frm86 = new Form86(); frm86.passTime1 = a;
                frm86.passCorrect = Correct + 1;
                frm86.Show();
                Hide();
            }
            if (button5.Text == "От кого е въведен терминът протисти?")
            {
                player.Play();

                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct;
                frm86.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "На колко групи се разделя царство Монера?")
            {
                player.Play();


                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct;
                frm86.Show();
                Hide();

            }
            if (button5.Text == "От кое царство е групата на еубактериите?")
            {
                player.Play();

                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct;
                frm86.Show();
                Hide();
            }
            if (button5.Text == "От кого е въведен терминът протисти?")
            {
                player.Play();

                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct;
                frm86.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "На колко групи се разделя царство Монера?")
            {
                player.Play();


                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct;
                frm86.Show();
                Hide();

            }
            if (button5.Text == "От кое царство е групата на еубактериите?")
            {
                player.Play();

                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct;
                frm86.Show();
                Hide();
            }
            if (button5.Text == "От кого е въведен терминът протисти?")
            {
                player.Play();

                frm86 = new Form86();
                frm86.passTime1 = a;
                frm86.passCorrect = Correct;
                frm86.Show();
                Hide();
            }
        }
    }
}
