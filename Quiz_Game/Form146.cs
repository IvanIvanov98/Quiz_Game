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
    public partial class Form146 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form147 frm147;
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
        public Form146()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form146_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "„Никога не казвай „никога““ е цитат от?";
                button1.Text = "Дикенс"; // Верният отговор
                button2.Text = "Шекспир";
                button3.Text = "Марк Твен";  
                button4.Text = "Дарвин";
            }
            if (q1 == 2)
            {
                button5.Text = "Пиесата „Повест за два града“ е създадена от?";
                button1.Text = "Макиавели"; 
                button2.Text = "Дикенс"; // Верният Отговор
                button3.Text = "Алигиери";
                button4.Text = "Милтън";
            }
            if (q1 == 3)
            {

                button5.Text = "Кой е патриархът на чешката музикална култура?";
                button1.Text = "Бетховен";
                button2.Text = "Ивелин Глени";  
                button3.Text = "Антонин Дворжак";
                button4.Text = "Бедржих Сметана"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "„Никога не казвай „никога““ е цитат от?")
            {
                player1.Play();


                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct + 1;
                frm147.Show();
                Hide();

            }
            if (button5.Text == "Пиесата „Повест за два града“ е създадена от?")
            {
                player.Play();

                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct;
                frm147.Show();
                Hide();
            }
            if (button5.Text == "Кой е патриархът на чешката музикална култура?")
            {
                player.Play();

                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct;
                frm147.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "„Никога не казвай „никога““ е цитат от?")
            {
                player.Play();


                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct;
                frm147.Show();
                Hide();

            }
            if (button5.Text == "Пиесата „Повест за два града“ е създадена от?")
            {
                player1.Play();

                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct + 1;
                frm147.Show();
                Hide();
            }
            if (button5.Text == "Кой е патриархът на чешката музикална култура?")
            {
                player.Play();

                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct;
                frm147.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "„Никога не казвай „никога““ е цитат от?")
            {
                player.Play();


                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct;
                frm147.Show();
                Hide();

            }
            if (button5.Text == "Пиесата „Повест за два града“ е създадена от?")
            {
                player.Play();

                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct;
                frm147.Show();
                Hide();
            }
            if (button5.Text == "Кой е патриархът на чешката музикална култура?")
            {
                player.Play();

                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct;
                frm147.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "„Никога не казвай „никога““ е цитат от?")
            {
                player.Play();


                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct;
                frm147.Show();
                Hide();

            }
            if (button5.Text == "Пиесата „Повест за два града“ е създадена от?")
            {
                player.Play();

                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct;
                frm147.Show();
                Hide();
            }
            if (button5.Text == "Кой е патриархът на чешката музикална култура?")
            {
                player1.Play();

                frm147 = new Form147();
                frm147.passTime1 = Time1;
                frm147.passTime2 = a;
                frm147.passCorrect = Correct + 1;
                frm147.Show();
                Hide();
            }
        }
    }
}
