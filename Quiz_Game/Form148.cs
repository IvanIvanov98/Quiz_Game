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
    public partial class Form148 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form149 frm149;
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
        public Form148()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form148_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Коя от пиесите е танцувална?";
                button1.Text = "Прелюдия";
                button2.Text = "Токата";
                button3.Text = "Чакона";  // Верният отговор
                button4.Text = "Ария";
            }
            if (q1 == 2)
            {
                button5.Text = "През кой век сюитата се превръща в самостоятелно произведение?";
                button1.Text = "11 век"; 
                button2.Text = "13 век";
                button3.Text = "16 век";
                button4.Text = "18 век"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Сюита съставена по едноименната опера на Жорж Бизе е?";
                button1.Text = "„Кармен“"; // Верният отговор
                button2.Text = "„Детски кът“"; 
                button3.Text = "„Бергамска сюита“";
                button4.Text = "„Пер Гинт“";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от пиесите е танцувална?")
            {
                player.Play();


                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct;
                frm149.Show();
                Hide();

            }
            if (button5.Text == "През кой век сюитата се превръща в самостоятелно произведение?")
            {
                player.Play();

                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct;
                frm149.Show();
                Hide();
            }
            if (button5.Text == "Сюита съставена по едноименната опера на Жорж Бизе е?")
            {
                player1.Play();

                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct + 1;
                frm149.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от пиесите е танцувална?")
            {
                player.Play();


                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct;
                frm149.Show();
                Hide();

            }
            if (button5.Text == "През кой век сюитата се превръща в самостоятелно произведение?")
            {
                player.Play();

                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct;
                frm149.Show();
                Hide();
            }
            if (button5.Text == "Сюита съставена по едноименната опера на Жорж Бизе е?")
            {
                player.Play();

                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct;
                frm149.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от пиесите е танцувална?")
            {
                player1.Play();


                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct + 1;
                frm149.Show();
                Hide();

            }
            if (button5.Text == "През кой век сюитата се превръща в самостоятелно произведение?")
            {
                player.Play();

                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct;
                frm149.Show();
                Hide();
            }
            if (button5.Text == "Сюита съставена по едноименната опера на Жорж Бизе е?")
            {
                player.Play();

                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct;
                frm149.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Коя от пиесите е танцувална?")
            {
                player.Play();


                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct;
                frm149.Show();
                Hide();

            }
            if (button5.Text == "През кой век сюитата се превръща в самостоятелно произведение?")
            {
                player1.Play();

                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct + 1;
                frm149.Show();
                Hide();
            }
            if (button5.Text == "Сюита съставена по едноименната опера на Жорж Бизе е?")
            {
                player.Play();

                frm149 = new Form149();
                frm149.passTime1 = Time1;
                frm149.passTime2 = Time2;
                frm149.passTime3 = Time3;
                frm149.passTime4 = a;
                frm149.passCorrect = Correct;
                frm149.Show();
                Hide();
            }
        }
    }
}
