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
    public partial class Form69 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form70 frm70;
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
        public Form69()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form69_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Какъв газ се отделя при горене?";
                button1.Text = "Въглероден диоксид"; // Верният Отговор
                button2.Text = "Природен газ"; 
                button3.Text = "Кислород";
                button4.Text = "Азот";
            }
            if (q1 == 2)
            {

                button5.Text = "От какво са съставени тъканите?";
                button1.Text = "Микроби";
                button2.Text = "Гъби";
                button3.Text = "Клетки"; // Верният Отговор
                button4.Text = "Органи";  
            }
            if (q1 == 3)
            {
                button5.Text = "Какъв вид животно е гущера?";
                button1.Text = "Бозайник";
                button2.Text = "Влечуго"; // Верният отговор
                button3.Text = "Членестоного";
                button4.Text = "Земноводно";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв газ се отделя при горене?")
            {
                player1.Play(); // Верният Отговор


                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct + 1;
                frm70.Show();
                Hide();

            }
            if (button5.Text == "От какво са съставени тъканите?")
            {
                player.Play();

                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct;
                frm70.Show();
                Hide();
            }
            if (button5.Text == "Какъв вид животно е гущера?")
            {
                player.Play();

                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct;
                frm70.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв газ се отделя при горене?")
            {
                player.Play();


                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct;
                frm70.Show();
                Hide();

            }
            if (button5.Text == "От какво са съставени тъканите?")
            {
                player.Play();

                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct;
                frm70.Show();
                Hide();
            }
            if (button5.Text == "Какъв вид животно е гущера?")
            {
                player1.Play(); // Верният Отговор

                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct + 1;
                frm70.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв газ се отделя при горене?")
            {
                player.Play();


                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct;
                frm70.Show();
                Hide();

            }
            if (button5.Text == "От какво са съставени тъканите?")
            {
                player1.Play(); // Верният Отговор

                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct + 1;
                frm70.Show();
                Hide();
            }
            if (button5.Text == "Какъв вид животно е гущера?")
            {
                player.Play();

                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct;
                frm70.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какъв газ се отделя при горене?")
            {
                player.Play();


                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct;
                frm70.Show();
                Hide();

            }
            if (button5.Text == "От какво са съставени тъканите?")
            {
                player.Play();

                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct;
                frm70.Show();
                Hide();
            }
            if (button5.Text == "Какъв вид животно е гущера?")
            {
                player.Play();

                frm70 = new Form70();
                frm70.passTime1 = Time1;
                frm70.passTime2 = Time2;
                frm70.passTime3 = Time3;
                frm70.passTime4 = Time4;
                frm70.passTime5 = a;
                frm70.passCorrect = Correct;
                frm70.Show();
                Hide();
            }
        }
    }
}
