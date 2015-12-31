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
    public partial class Form143 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form144 frm144;
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
        private int Time8;
        public int passTime8
        {
            get
            {
                return Time8;
            }
            set
            {
                Time8 = value;
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
        public Form143()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form143_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Авторът на „Пътешествията на Гъливер“ е?";
                button1.Text = "Чарлс Дикенс";
                button2.Text = "Джонатан Суифт"; // Верният отговор
                button3.Text = "Марк Твен";  
                button4.Text = "Джон Милтън";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой е авторът на „Пипи Дългото чорапче“?";
                button1.Text = "Джани Родари"; 
                button2.Text = "Борис Заходер";
                button3.Text = "Астрид Линдгрен"; // Верният Отговор
                button4.Text = "Шарл Перо";
            }
            if (q1 == 3)
            {

                button5.Text = "Съотношението между отделните части на даден обект се нарича?";
                button1.Text = "Пропорция"; // Верният отговор
                button2.Text = "Графика"; 
                button3.Text = "Рисунка";
                button4.Text = "Портрет";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Авторът на „Пътешествията на Гъливер“ е?")
            {
                player.Play();


                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct;
                frm144.Show();
                Hide();

            }
            if (button5.Text == "Кой е авторът на „Пипи Дългото чорапче“?")
            {
                player.Play();

                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct;
                frm144.Show();
                Hide();
            }
            if (button5.Text == "Съотношението между отделните части на даден обект се нарича?")
            {
                player1.Play();

                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct + 1;
                frm144.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Авторът на „Пътешествията на Гъливер“ е?")
            {
                player1.Play();


                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct + 1;
                frm144.Show();
                Hide();

            }
            if (button5.Text == "Кой е авторът на „Пипи Дългото чорапче“?")
            {
                player.Play();

                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct;
                frm144.Show();
                Hide();
            }
            if (button5.Text == "Съотношението между отделните части на даден обект се нарича?")
            {
                player.Play();

                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct;
                frm144.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Авторът на „Пътешествията на Гъливер“ е?")
            {
                player.Play();


                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct;
                frm144.Show();
                Hide();

            }
            if (button5.Text == "Кой е авторът на „Пипи Дългото чорапче“?")
            {
                player1.Play();

                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct + 1;
                frm144.Show();
                Hide();
            }
            if (button5.Text == "Съотношението между отделните части на даден обект се нарича?")
            {
                player.Play();

                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct;
                frm144.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Авторът на „Пътешествията на Гъливер“ е?")
            {
                player.Play();


                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct;
                frm144.Show();
                Hide();

            }
            if (button5.Text == "Кой е авторът на „Пипи Дългото чорапче“?")
            {
                player.Play();

                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct;
                frm144.Show();
                Hide();
            }
            if (button5.Text == "Съотношението между отделните части на даден обект се нарича?")
            {
                player.Play();

                frm144 = new Form144();
                frm144.passTime1 = Time1;
                frm144.passTime2 = Time2;
                frm144.passTime3 = Time3;
                frm144.passTime4 = Time4;
                frm144.passTime5 = Time5;
                frm144.passTime6 = Time6;
                frm144.passTime7 = Time7;
                frm144.passTime8 = Time8;
                frm144.passTime9 = a;
                frm144.passCorrect = Correct;
                frm144.Show();
                Hide();
            }
        }
    }
}
