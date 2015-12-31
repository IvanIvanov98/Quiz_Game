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
    public partial class Form150 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form151 frm151;
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
        public Form150()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form150_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            { 
                button5.Text = "Холандски майстор на библейски сцени от 17 в.е?";
                button1.Text = "Вермеер";
                button2.Text = "Рембранд"; // Верният отговор
                button3.Text = "Рафаело";  
                button4.Text = "Пол Сезан";
            }
            if (q1 == 2)
            {
                button5.Text = "Кога Робърт Олтмън получава награда за цялостно творчество?";
                button1.Text = "2000"; 
                button2.Text = "2003";
                button3.Text = "2006"; // Верният Отговор
                button4.Text = "2009";
            }
            if (q1 == 3)
            {

                button5.Text = "„Великият диктатор“ е първият звуков филм на?";
                button1.Text = "Чарли Чаплин"; // Верният отговор
                button2.Text = "Бъстър Кийтън"; 
                button3.Text = "Адолф Хитлер";
                button4.Text = "Граучо Маркс";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Холандски майстор на библейски сцени от 17 в.е?")
            {
                player.Play();


                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct;
                frm151.Show();
                Hide();

            }
            if (button5.Text == "Кога Робърт Олтмън получава награда за цялостно творчество?")
            {
                player.Play();

                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct;
                frm151.Show();
                Hide();
            }
            if (button5.Text == "„Великият диктатор“ е първият звуков филм на?")
            {
                player1.Play();

                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct + 1;
                frm151.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Холандски майстор на библейски сцени от 17 в.е?")
            {
                player1.Play();


                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct + 1;
                frm151.Show();
                Hide();

            }
            if (button5.Text == "Кога Робърт Олтмън получава награда за цялостно творчество?")
            {
                player.Play();

                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct;
                frm151.Show();
                Hide();
            }
            if (button5.Text == "„Великият диктатор“ е първият звуков филм на?")
            {
                player.Play();

                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct;
                frm151.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Холандски майстор на библейски сцени от 17 в.е?")
            {
                player.Play();


                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct;
                frm151.Show();
                Hide();

            }
            if (button5.Text == "Кога Робърт Олтмън получава награда за цялостно творчество?")
            {
                player1.Play();

                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct + 1;
                frm151.Show();
                Hide();
            }
            if (button5.Text == "„Великият диктатор“ е първият звуков филм на?")
            {
                player.Play();

                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct;
                frm151.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Холандски майстор на библейски сцени от 17 в.е?")
            {
                player.Play();


                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct;
                frm151.Show();
                Hide();

            }
            if (button5.Text == "Кога Робърт Олтмън получава награда за цялостно творчество?")
            {
                player.Play();

                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct;
                frm151.Show();
                Hide();
            }
            if (button5.Text == "„Великият диктатор“ е първият звуков филм на?")
            {
                player.Play();

                frm151 = new Form151();
                frm151.passTime1 = Time1;
                frm151.passTime2 = Time2;
                frm151.passTime3 = Time3;
                frm151.passTime4 = Time4;
                frm151.passTime5 = Time5;
                frm151.passTime6 = a;
                frm151.passCorrect = Correct;
                frm151.Show();
                Hide();
            }
        }
    }
}
