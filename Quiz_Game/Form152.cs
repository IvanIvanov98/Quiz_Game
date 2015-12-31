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
    public partial class Form152 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form153 frm153;
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
        public Form152()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form152_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            { 
                button5.Text = "Въведение към музикално-сценично произведение се нарича?";
                button1.Text = "Увертюра"; // Верният отговор
                button2.Text = "Резюме";
                button3.Text = "Епилог";  
                button4.Text = "Муз. преход";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой изгражда Байройтския фестивален театър?";
                button1.Text = "Моцарт";  
                button2.Text = "Бетховен";
                button3.Text = "Вагнер"; // Верният Отговор
                button4.Text = "Росини";
            }
            if (q1 == 3)
            {

                button5.Text = "Густав Малер е композитор от?";
                button1.Text = "Полша";
                button2.Text = "Австрия"; // Верният отговор
                button3.Text = "Холандия";
                button4.Text = "Чехия";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Въведение към музикално-сценично произведение се нарича?")
            {
                player1.Play();


                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct + 1;
                frm153.Show();
                Hide();

            }
            if (button5.Text == "Кой изгражда Байройтския фестивален театър?")
            {
                player.Play();

                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct;
                frm153.Show();
                Hide();
            }
            if (button5.Text == "Густав Малер е композитор от?")
            {
                player.Play();

                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct;
                frm153.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Въведение към музикално-сценично произведение се нарича?")
            {
                player.Play();


                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct;
                frm153.Show();
                Hide();

            }
            if (button5.Text == "Кой изгражда Байройтския фестивален театър?")
            {
                player.Play();

                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct;
                frm153.Show();
                Hide();
            }
            if (button5.Text == "Густав Малер е композитор от?")
            {
                player1.Play();

                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct + 1;
                frm153.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Въведение към музикално-сценично произведение се нарича?")
            {
                player.Play();


                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct;
                frm153.Show();
                Hide();

            }
            if (button5.Text == "Кой изгражда Байройтския фестивален театър?")
            {
                player1.Play();

                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct + 1;
                frm153.Show();
                Hide();
            }
            if (button5.Text == "Густав Малер е композитор от?")
            {
                player.Play();

                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct;
                frm153.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Въведение към музикално-сценично произведение се нарича?")
            {
                player.Play();


                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct;
                frm153.Show();
                Hide();

            }
            if (button5.Text == "Кой изгражда Байройтския фестивален театър?")
            {
                player.Play();

                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct;
                frm153.Show();
                Hide();
            }
            if (button5.Text == "Густав Малер е композитор от?")
            {
                player.Play();

                frm153 = new Form153();
                frm153.passTime1 = Time1;
                frm153.passTime2 = Time2;
                frm153.passTime3 = Time3;
                frm153.passTime4 = Time4;
                frm153.passTime5 = Time5;
                frm153.passTime6 = Time6;
                frm153.passTime7 = Time7;
                frm153.passTime8 = a;
                frm153.passCorrect = Correct;
                frm153.Show();
                Hide();
            }
        }
    }
}
