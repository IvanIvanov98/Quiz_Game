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
    public partial class Form139 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form140 frm140;
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
        private int Time4;
        public int passTime4
        {
            get
            {
                return Time4;
            }
            set
            {
                Time4 = value;
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
        public Form139()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form139_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кой спечели Оскар за най-добра женска роля през 2015?";
                button1.Text = "Джулиан Мур"; // Верният отговор
                button2.Text = "Анджелина Джоли";
                button3.Text = "Натали Портман";  
                button4.Text = "Мерил Стрийп";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой спечели Оскар за най-добра мъжка роля през 2014?";
                button1.Text = "Жан Дюжарден"; 
                button2.Text = "Матю Макконъхи"; // Верният Отговор
                button3.Text = "Колин Фърт";
                button4.Text = "Крисчън Бейл";
            }
            if (q1 == 3)
            {

                button5.Text = "Епилог на творба се нарича?";
                button1.Text = "Началото";
                button2.Text = "Връхната точка"; 
                button3.Text = "Краят"; // Верният отговор
                button4.Text = "Коментарът";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой спечели Оскар за най-добра женска роля през 2015?")
            {
                player1.Play();


                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct + 1;
                frm140.Show();
                Hide();

            }
            if (button5.Text == "Кой спечели Оскар за най-добра мъжка роля през 2014?")
            {
                player.Play();

                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct;
                frm140.Show();
                Hide();
            }
            if (button5.Text == "Епилог на творба се нарича?")
            {
                player.Play();

                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct;
                frm140.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой спечели Оскар за най-добра женска роля през 2015?")
            {
                player.Play();


                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct;
                frm140.Show();
                Hide();

            }
            if (button5.Text == "Кой спечели Оскар за най-добра мъжка роля през 2014?")
            {
                player1.Play();

                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct + 1;
                frm140.Show();
                Hide();
            }
            if (button5.Text == "Епилог на творба се нарича?")
            {
                player.Play();

                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct;
                frm140.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой спечели Оскар за най-добра женска роля през 2015?")
            {
                player.Play();


                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct;
                frm140.Show();
                Hide();

            }
            if (button5.Text == "Кой спечели Оскар за най-добра мъжка роля през 2014?")
            {
                player.Play();

                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct;
                frm140.Show();
                Hide();
            }
            if (button5.Text == "Епилог на творба се нарича?")
            {
                player1.Play();

                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct + 1;
                frm140.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой спечели Оскар за най-добра женска роля през 2015?")
            {
                player.Play();


                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct;
                frm140.Show();
                Hide();

            }
            if (button5.Text == "Кой спечели Оскар за най-добра мъжка роля през 2014?")
            {
                player.Play();

                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct;
                frm140.Show();
                Hide();
            }
            if (button5.Text == "Епилог на творба се нарича?")
            {
                player.Play();

                frm140 = new Form140();
                frm140.passTime1 = Time1;
                frm140.passTime2 = Time2;
                frm140.passTime3 = Time3;
                frm140.passTime4 = Time4;
                frm140.passTime5 = a;
                frm140.passCorrect = Correct;
                frm140.Show();
                Hide();
            }
        }
    }
}
