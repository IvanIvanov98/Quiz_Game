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
    public partial class Form131 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form132 frm132;
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
        public Form131()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form131_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой бог почитали древните елини?";
                button1.Text = "Марс"; 
                button2.Text = "Аполон"; // Верният отговор
                button3.Text = "Енлил";
                button4.Text = "Яхве";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой от паметниците в България е включен в ЮНЕСКО?";
                button1.Text = "Александровската гробница";
                button2.Text = "Гробница край Мезек"; 
                button3.Text = "Гробницата край Старосел";
                button4.Text = "Казанлъшката гробница"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Каква е религията на египтяните, елините и римляните?";
                button1.Text = "Фетишизъм";
                button2.Text = "Политеизъм"; // Верният отговор
                button3.Text = "Монотеизъм";
                button4.Text = "Тотемизъм"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой бог почитали древните елини?")
            {
                player.Play();


                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct;
                frm132.Show();
                Hide();

            }
            if (button5.Text == "Кой от паметниците в България е включен в ЮНЕСКО?")
            {
                player.Play();

                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct;
                frm132.Show();
                Hide();
            }
            if (button5.Text == "Каква е религията на египтяните, елините и римляните?")
            {
                player.Play();

                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct;
                frm132.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой бог почитали древните елини?")
            {
                player1.Play();


                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct + 1;
                frm132.Show();
                Hide();

            }
            if (button5.Text == "Кой от паметниците в България е включен в ЮНЕСКО?")
            {
                player.Play();

                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct;
                frm132.Show();
                Hide();
            }
            if (button5.Text == "Каква е религията на египтяните, елините и римляните?")
            {
                player1.Play();

                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct + 1;
                frm132.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой бог почитали древните елини?")
            {
                player.Play();


                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct;
                frm132.Show();
                Hide();

            }
            if (button5.Text == "Кой от паметниците в България е включен в ЮНЕСКО?")
            {
                player.Play();

                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct;
                frm132.Show();
                Hide();
            }
            if (button5.Text == "Каква е религията на египтяните, елините и римляните?")
            {
                player.Play();

                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct;
                frm132.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой бог почитали древните елини?")
            {
                player.Play();


                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct;
                frm132.Show();
                Hide();

            }
            if (button5.Text == "Кой от паметниците в България е включен в ЮНЕСКО?")
            {
                player1.Play();

                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct + 1;
                frm132.Show();
                Hide();
            }
            if (button5.Text == "Каква е религията на египтяните, елините и римляните?")
            {
                player.Play();

                frm132 = new Form132();
                frm132.passTime1 = Time1;
                frm132.passTime2 = Time2;
                frm132.passTime3 = Time3;
                frm132.passTime4 = Time4;
                frm132.passTime5 = Time5;
                frm132.passTime6 = Time6;
                frm132.passTime7 = a;
                frm132.passCorrect = Correct;
                frm132.Show();
                Hide();
            }
        }
    }
}
