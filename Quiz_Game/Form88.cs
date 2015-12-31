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
    public partial class Form88 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form89 frm89;
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

        public Form88()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form88_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Изучаването на стволовите клетки е започнало през?";
                button1.Text = "1860";
                button2.Text = "1960"; // Верният Отговор
                button3.Text = "1920";
                button4.Text = "1830"; 
            }
            if (q1 == 2)
            {
                button5.Text = "Модиф. и нагъване на протеини и липиди е хар. за?";
                button1.Text = "Ендоплазмен ретикулум";
                button2.Text = "Митохондрия"; // Верният Отговор
                button3.Text = "Вакуола";
                button4.Text = "Пластид";
            }
            if (q1 == 3)
            {

                button5.Text = "Взаимодействие с  появява на междинен белег?";
                button1.Text = "Непълното доминиране";
                button2.Text = "Комплементарно";
                button3.Text = "Епистатично"; // Верният отговор
                button4.Text = "Полимерно";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Изучаването на стволовите клетки е започнало през?")
            {
                player.Play();


                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct;
                frm89.Show();
                Hide();

            }
            if (button5.Text == "Модиф. и нагъване на протеини и липиди е хар. за?")
            {
                player.Play();

                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct;
                frm89.Show();
                Hide();
            }
            if (button5.Text == "Взаимодействие с  появява на междинен белег?")
            {
                player.Play();

                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct;
                frm89.Show();
                Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Изучаването на стволовите клетки е започнало през?")
            {
                player1.Play();


                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct + 1;
                frm89.Show();
                Hide();

            }
            if (button5.Text == "Модиф. и нагъване на протеини и липиди е хар. за?")
            {
                player1.Play();

                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct + 1;
                frm89.Show();
                Hide();
            }
            if (button5.Text == "Взаимодействие с  появява на междинен белег?")
            {
                player.Play();

                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct;
                frm89.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Изучаването на стволовите клетки е започнало през?")
            {
                player.Play();


                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct;
                frm89.Show();
                Hide();

            }
            if (button5.Text == "Модиф. и нагъване на протеини и липиди е хар. за?")
            {
                player.Play();

                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct;
                frm89.Show();
                Hide();
            }
            if (button5.Text == "Взаимодействие с  появява на междинен белег?")
            {
                player1.Play();

                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct + 1;
                frm89.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Изучаването на стволовите клетки е започнало през?")
            {
                player.Play();


                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct;
                frm89.Show();
                Hide();

            }
            if (button5.Text == "Модиф. и нагъване на протеини и липиди е хар. за?")
            {
                player.Play();

                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct;
                frm89.Show();
                Hide();
            }
            if (button5.Text == "Взаимодействие с  появява на междинен белег?")
            {
                player.Play();

                frm89 = new Form89();
                frm89.passTime1 = Time1;
                frm89.passTime2 = Time2;
                frm89.passTime3 = Time3;
                frm89.passTime4 = a;
                frm89.passCorrect = Correct;
                frm89.Show();
                Hide();
            }
        }
    }
}
