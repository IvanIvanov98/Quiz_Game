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
    public partial class Form135 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form136 frm136;
        int a = 0;
        int Correct = 0;

        public Form135()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form135_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кое определя мелодията и хармонията?";
                button1.Text = "Ритъмът";
                button2.Text = "Тонът"; // Верният отговор
                button3.Text = "Динамиката";  
                button4.Text = "Тембърът";
            }
            if (q1 == 2)
            {
                button5.Text = "Темпо, размер и артикулация са свързани с?";
                button1.Text = "Тонът"; 
                button2.Text = "Динамиката";
                button3.Text = "Ритъмът"; // Верният Отговор
                button4.Text = "Текстурата";
            }
            if (q1 == 3)
            {

                button5.Text = "Триизмерно произведение на изкуството е?";
                button1.Text = "Скулптура"; // Верният отговор
                button2.Text = "Рисунка"; 
                button3.Text = "Графика";
                button4.Text = "Чертеж";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое определя мелодията и хармонията?")
            {
                player.Play();


                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct;
                frm136.Show();
                Hide();

            }
            if (button5.Text == "Темпо, размер и артикулация са свързани с?")
            {
                player.Play();

                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct;
                frm136.Show();
                Hide();
            }
            if (button5.Text == "Триизмерно произведение на изкуството е?")
            {
                player1.Play();

                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct + 1;
                frm136.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое определя мелодията и хармонията?")
            {
                player1.Play();


                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct + 1;
                frm136.Show();
                Hide();

            }
            if (button5.Text == "Темпо, размер и артикулация са свързани с?")
            {
                player.Play();

                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct;
                frm136.Show();
                Hide();
            }
            if (button5.Text == "Триизмерно произведение на изкуството е?")
            {
                player.Play();

                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct;
                frm136.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое определя мелодията и хармонията?")
            {
                player.Play();


                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct;
                frm136.Show();
                Hide();

            }
            if (button5.Text == "Темпо, размер и артикулация са свързани с?")
            {
                player1.Play();

                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct + 1;
                frm136.Show();
                Hide();
            }
            if (button5.Text == "Триизмерно произведение на изкуството е?")
            {
                player.Play();

                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct;
                frm136.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое определя мелодията и хармонията?")
            {
                player.Play();


                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct;
                frm136.Show();
                Hide();

            }
            if (button5.Text == "Темпо, размер и артикулация са свързани с?")
            {
                player.Play();

                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct;
                frm136.Show();
                Hide();
            }
            if (button5.Text == "Триизмерно произведение на изкуството е?")
            {
                player.Play();

                frm136 = new Form136();
                frm136.passTime1 = a;
                frm136.passCorrect = Correct;
                frm136.Show();
                Hide();
            }
        }
    }
}
