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
    public partial class Form128 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form129 frm129;
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
        public Form128()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form128_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Договорът, който Австрия приема е?";
                button1.Text = "Трианонски договор"; 
                button2.Text = "Севърски договор";
                button3.Text = "Сен-Жерменски договор"; // Верният отговор
                button4.Text = "Ньойски договор";
            }
            if (q1 == 2)
            {
                button5.Text = "Кога започва Втората Световна Война?";
                button1.Text = "1939"; // Верният Отговор
                button2.Text = "1940"; 
                button3.Text = "1945";
                button4.Text = "1935"; 
            }
            if (q1 == 3)
            {
                

                button5.Text = "С нахлуването на коя страна в Пол.започва ВСВ?";
                button1.Text = "Австрия";
                button2.Text = "Германия"; // Верният отговор
                button3.Text = "СССР";
                button4.Text = "Англия"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Договорът, който Австрия приема е?")
            {
                player.Play();


                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct;
                frm129.Show();
                Hide();

            }
            if (button5.Text == "Кога започва Втората Световна Война?")
            {
                player1.Play();

                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct + 1;
                frm129.Show();
                Hide();
            }
            if (button5.Text == "С нахлуването на коя страна в Пол.започва ВСВ?")
            {
                player.Play();

                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct;
                frm129.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Договорът, който Австрия приема е?")
            {
                player.Play();


                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct;
                frm129.Show();
                Hide();

            }
            if (button5.Text == "Кога започва Втората Световна Война?")
            {
                player.Play();

                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct;
                frm129.Show();
                Hide();
            }
            if (button5.Text == "С нахлуването на коя страна в Пол.започва ВСВ?")
            {
                player1.Play();

                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct + 1;
                frm129.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Договорът, който Австрия приема е?")
            {
                player1.Play();


                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct + 1;
                frm129.Show();
                Hide();

            }
            if (button5.Text == "Кога започва Втората Световна Война?")
            {
                player.Play();

                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct;
                frm129.Show();
                Hide();
            }
            if (button5.Text == "С нахлуването на коя страна в Пол.започва ВСВ?")
            {
                player.Play();

                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct;
                frm129.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Договорът, който Австрия приема е?")
            {
                player.Play();


                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct;
                frm129.Show();
                Hide();

            }
            if (button5.Text == "Кога започва Втората Световна Война?")
            {
                player.Play();

                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct;
                frm129.Show();
                Hide();
            }
            if (button5.Text == "С нахлуването на коя страна в Пол.започва ВСВ?")
            {
                player.Play();

                frm129 = new Form129();
                frm129.passTime1 = Time1;
                frm129.passTime2 = Time2;
                frm129.passTime3 = Time3;
                frm129.passTime4 = a;
                frm129.passCorrect = Correct;
                frm129.Show();
                Hide();
            }
        }
    }
}
