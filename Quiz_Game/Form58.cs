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
    public partial class Form58 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form59 frm59;
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
        public Form58()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form58_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Кога фехтовката е включена в олимпйските игри?";
                    button1.Text = "1896"; // Верният Отговор
                    button2.Text = "1900";
                    button3.Text = "1892";
                    button4.Text = "1878";
                }
                if (q1 == 2)
                {
                    button5.Text = "Размерите на хандбал игрище в метри e?";
                    button1.Text = "20 на 40";  // Верният Отговор
                    button2.Text = "30 на 40";
                    button3.Text = "40 на 40";
                    button4.Text = "20 на 30";
                }
                if (q1 == 3)
                {
                    button5.Text = "От коя година хокея на трева е олимпийски спорт?";
                    button1.Text = "1912";
                    button2.Text = "1910";
                    button3.Text = "1908";
                    button4.Text = "1924"; // Верният отговор
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кога фехтовката е включена в олимпйските игри?")
            {
                player1.Play();
                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct + 1;
                frm59.Show();
                Hide();

            }
            if (button5.Text == "Размерите на хандбал игрище в метри e?")
            {
                player1.Play();
                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct + 1;
                frm59.Show();
                Hide();
            }
            if (button5.Text == "От коя година хокея на трева е олимпийски спорт?")
            {
                player.Play();

                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct;
                frm59.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кога фехтовката е включена в олимпйските игри?")
            {
                player.Play();
                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct;
                frm59.Show();
                Hide();

            }
            if (button5.Text == "Размерите на хандбал игрище в метри e?")
            {
                player.Play();
                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct;
                frm59.Show();
                Hide();
            }
            if (button5.Text == "От коя година хокея на трева е олимпийски спорт?")
            {
                player.Play();

                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct;
                frm59.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кога фехтовката е включена в олимпйските игри?")
            {
                player.Play();
                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct;
                frm59.Show();
                Hide();

            }
            if (button5.Text == "Размерите на хандбал игрище в метри e?")
            {
                player.Play();
                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct;
                frm59.Show();
                Hide();
            }
            if (button5.Text == "От коя година хокея на трева е олимпийски спорт?")
            {
                player.Play();

                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct;
                frm59.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (button5.Text == "Кога фехтовката е включена в олимпйските игри?")
            {
                player.Play();
                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct;
                frm59.Show();
                Hide();

            }
            if (button5.Text == "Размерите на хандбал игрище в метри e?")
            {
                player.Play();
                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct + 1;
                frm59.Show();
                Hide();
            }
            if (button5.Text == "От коя година хокея на трева е олимпийски спорт?")
            {
                player1.Play();

                
                frm59 = new Form59();
                frm59.passTime1 = Time1;
                frm59.passTime2 = Time2;
                frm59.passTime3 = Time3;
                frm59.passTime4 = a;
                frm59.passCorrect = Correct;
                frm59.Show();
                Hide();
            }
        }
    }
}
