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
    public partial class Form91 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form92 frm92;
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
        public Form91()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form91_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "В процеса транслация участват?";
                button1.Text = "Трите вида РНК"; 
                button2.Text = "тРНК и рРНК";
                button3.Text = "тРНК и иРНК"; // Верният отговор
                button4.Text = "Само тРНК";
            }
            if (q1 == 2)
            {
                button5.Text = "Какво е Глицералдехид 3-фосфат?";
                button1.Text = "Белтък";
                button2.Text = "Липид";
                button3.Text = "Метаболит";  // Верният Отговор
                button4.Text = "Въглехидрат";  
            }
            if (q1 == 3)
            {

                button5.Text = "Какъв с средния диаметър на 1 кл.ядро в μm?";
                button1.Text = "11 до 22"; // Верният отговор
                button2.Text = "5 до 10";
                button3.Text = "40 до 64";
                button4.Text = "2 до 3";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В процеса транслация участват?")
            {
                player.Play();


                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct;
                frm92.Show();
                Hide();

            }
            if (button5.Text == "Какво е Глицералдехид 3-фосфат?")
            {
                player.Play();

                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct;
                frm92.Show();
                Hide();
            }
            if (button5.Text == "Какъв с средния диаметър на 1 кл.ядро в μm?")
            {
                player1.Play();

                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct + 1;
                frm92.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В процеса транслация участват?")
            {
                player.Play();


                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct;
                frm92.Show();
                Hide();

            }
            if (button5.Text == "Какво е Глицералдехид 3-фосфат?")
            {
                player.Play();

                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct;
                frm92.Show();
                Hide();
            }
            if (button5.Text == "Какъв с средния диаметър на 1 кл.ядро в μm?")
            {
                player.Play();

                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct;
                frm92.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В процеса транслация участват?")
            {
                player1.Play();


                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct + 1;
                frm92.Show();
                Hide();

            }
            if (button5.Text == "Какво е Глицералдехид 3-фосфат?")
            {
                player1.Play();

                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct + 1;
                frm92.Show();
                Hide();
            }
            if (button5.Text == "Какъв с средния диаметър на 1 кл.ядро в μm?")
            {
                player.Play();

                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct;
                frm92.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В процеса транслация участват?")
            {
                player.Play();


                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct;
                frm92.Show();
                Hide();

            }
            if (button5.Text == "Какво е Глицералдехид 3-фосфат?")
            {
                player.Play();

                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct;
                frm92.Show();
                Hide();
            }
            if (button5.Text == "Какъв с средния диаметър на 1 кл.ядро в μm?")
            {
                player.Play();

                frm92 = new Form92();
                frm92.passTime1 = Time1;
                frm92.passTime2 = Time2;
                frm92.passTime3 = Time3;
                frm92.passTime4 = Time4;
                frm92.passTime5 = Time5;
                frm92.passTime6 = Time6;
                frm92.passTime7 = a;
                frm92.passCorrect = Correct;
                frm92.Show();
                Hide();
            }
        }
    }
}
