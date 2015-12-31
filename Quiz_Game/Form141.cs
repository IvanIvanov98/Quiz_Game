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
    public partial class Form141 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form142 frm142;
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
        private int Time5;
        public int passTime5
        {
            get
            {
                return Time5;
            }
            set
            {
                Time5 = value;
            }
        }
        private int Time6;
        public int passTime6
        {
            get
            {
                return Time6;
            }
            set
            {
                Time6 = value;
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
        public Form141()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form141_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            { 
                button5.Text = "На кого основна тема в творчеството е социалната несправедливост?";
                button1.Text = "Иван Вазов";
                button2.Text = "Димчо Дебелянов";
                button3.Text = "Христо Смирненски";  // Верният отговор
                button4.Text = "Пейо Яворов";
            }
            if (q1 == 2)
            {
                button5.Text = "Какъв вид инструмент е шофарът?";
                button1.Text = "Духов"; // Верният Отговор
                button2.Text = "Струнен";
                button3.Text = "Ударен";
                button4.Text = "Клавишен";
            }
            if (q1 == 3)
            {

                button5.Text = "Кой е първият пълнометражен анимационен филм?";
                button1.Text = "Спящата красавица";
                button2.Text = "Снежанка"; // Верният отговор
                button3.Text = "Мики Маус";
                button4.Text = "Пинокио";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "На кого основна тема в творчеството е социалната несправедливост?")
            {
                player.Play();


                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct;
                frm142.Show();
                Hide();

            }
            if (button5.Text == "Какъв вид инструмент е шофарът?")
            {
                player1.Play();

                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct + 1;
                frm142.Show();
                Hide();
            }
            if (button5.Text == "Кой е първият пълнометражен анимационен филм?")
            {
                player.Play();

                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct;
                frm142.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "На кого основна тема в творчеството е социалната несправедливост?")
            {
                player.Play();


                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct;
                frm142.Show();
                Hide();

            }
            if (button5.Text == "Какъв вид инструмент е шофарът?")
            {
                player.Play();

                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct;
                frm142.Show();
                Hide();
            }
            if (button5.Text == "Кой е първият пълнометражен анимационен филм?")
            {
                player1.Play();

                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct + 1;
                frm142.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "На кого основна тема в творчеството е социалната несправедливост?")
            {
                player1.Play();


                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct + 1;
                frm142.Show();
                Hide();

            }
            if (button5.Text == "Какъв вид инструмент е шофарът?")
            {
                player.Play();

                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct;
                frm142.Show();
                Hide();
            }
            if (button5.Text == "Кой е първият пълнометражен анимационен филм?")
            {
                player.Play();

                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct;
                frm142.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "На кого основна тема в творчеството е социалната несправедливост?")
            {
                player.Play();


                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct;
                frm142.Show();
                Hide();

            }
            if (button5.Text == "Какъв вид инструмент е шофарът?")
            {
                player.Play();

                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct;
                frm142.Show();
                Hide();
            }
            if (button5.Text == "Кой е първият пълнометражен анимационен филм?")
            {
                player.Play();

                frm142 = new Form142();
                frm142.passTime1 = Time1;
                frm142.passTime2 = Time2;
                frm142.passTime3 = Time3;
                frm142.passTime4 = Time4;
                frm142.passTime5 = Time5;
                frm142.passTime6 = Time6;
                frm142.passTime7 = a;
                frm142.passCorrect = Correct;
                frm142.Show();
                Hide();
            }
        }
    }
}
