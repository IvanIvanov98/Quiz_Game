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

    public partial class Form112 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form113 frm113;
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
        private int Time7;
        public int passTime7
        {
            get
            {
                return Time7;
            }
            set
            {
                Time7 = value;
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
        public Form112()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Първото римско нашествие в Бриания е през?")
            {
                player.Play();


                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct;
                frm113.Show();
                Hide();

            }
            if (button5.Text == "Колко сенатори участват в преврата с/у Юлий Цезар?")
            {
                player.Play();

                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct;
                frm113.Show();
                Hide();
            }
            if (button5.Text == "Кой е бил главен-апостол на IV револ. окръг?")
            {
                player.Play();

                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct;
                frm113.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button5.Text == "Първото римско нашествие в Бриания е през?")
            {
                player1.Play();


                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct + 1;
                frm113.Show();
                Hide();

            }
            if (button5.Text == "Колко сенатори участват в преврата с/у Юлий Цезар?")
            {
                player1.Play();

                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct + 1;
                frm113.Show();
                Hide();
            }
            if (button5.Text == "Кой е бил главен-апостол на IV револ. окръг?")
            {
                player.Play();

                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct;
                frm113.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Първото римско нашествие в Бриания е през?")
            {
                player.Play();


                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct;
                frm113.Show();
                Hide();

            }
            if (button5.Text == "Колко сенатори участват в преврата с/у Юлий Цезар?")
            {
                player.Play();

                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct;
                frm113.Show();
                Hide();
            }
            if (button5.Text == "Кой е бил главен-апостол на IV револ. окръг?")
            {
                player1.Play();

                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct + 1;
                frm113.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Първото римско нашествие в Бриания е през?")
            {
                player.Play();


                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct;
                frm113.Show();
                Hide();

            }
            if (button5.Text == "Колко сенатори участват в преврата с/у Юлий Цезар?")
            {
                player.Play();

                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct;
                frm113.Show();
                Hide();
            }
            if (button5.Text == "Кой е бил главен-апостол на IV револ. окръг?")
            {
                player.Play();

                frm113 = new Form113();
                frm113.passTime1 = Time1;
                frm113.passTime2 = Time2;
                frm113.passTime3 = Time3;
                frm113.passTime4 = Time4;
                frm113.passTime5 = Time5;
                frm113.passTime6 = Time6;
                frm113.passTime7 = Time7;
                frm113.passTime8 = a;
                frm113.passCorrect = Correct;
                frm113.Show();
                Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form112_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Първото римско нашествие в Бриания е през?";
                button1.Text = "49г.пр.н.е";
                button2.Text = "52г.пр.н.е";
                button3.Text = "55г.пр.н.е";  // Верният отговор
                button4.Text = "61г.пр.н.е";
            }
            if (q1 == 2)
            {
                button5.Text = "Колко сенатори участват в преврата с/у Юлий Цезар?";
                button1.Text = "2";
                button2.Text = "5";
                button3.Text = "60"; // Верният Отговор
                button4.Text = "10";
            }
            if (q1 == 3)
            {

                button5.Text = "Кой е бил главен-апостол на IV револ. окръг?";
                button1.Text = "Георги Бенковски";
                button2.Text = "Панайот Волов"; // Верният отговор
                button3.Text = "Георги Раковски";
                button4.Text = "Христо Ботев";
            }
        }
    }
}
