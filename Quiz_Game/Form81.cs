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
    public partial class Form81 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form82 frm82;
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

        public Form81()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой процес осигурява кислорода в атмосферата?")
            {
                player.Play();


                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct;
                frm82.Show();
                Hide();

            }
            if (button5.Text == "Кой от хим. елемнти е макроелемент за клетката?")
            {
                player.Play();

                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct;
                frm82.Show();
                Hide();
            }
            if (button5.Text == "През светлинната фаза на фотосинт. се образува?")
            {
                player1.Play();

                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct + 1;
                frm82.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой процес осигурява кислорода в атмосферата?")
            {
                player.Play();


                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct;
                frm82.Show();
                Hide();

            }
            if (button5.Text == "Кой от хим. елемнти е макроелемент за клетката?")
            {
                player.Play();

                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct;
                frm82.Show();
                Hide();
            }
            if (button5.Text == "През светлинната фаза на фотосинт. се образува?")
            {
                player.Play();

                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct;
                frm82.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой процес осигурява кислорода в атмосферата?")
            {
                player1.Play();


                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct + 1;
                frm82.Show();
                Hide();

            }
            if (button5.Text == "Кой от хим. елемнти е макроелемент за клетката?")
            {
                player1.Play();

                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct + 1;
                frm82.Show();
                Hide();
            }
            if (button5.Text == "През светлинната фаза на фотосинт. се образува?")
            {
                player.Play();

                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct;
                frm82.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой процес осигурява кислорода в атмосферата?")
            {
                player.Play();


                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct;
                frm82.Show();
                Hide();

            }
            if (button5.Text == "Кой от хим. елемнти е макроелемент за клетката?")
            {
                player.Play();

                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct;
                frm82.Show();
                Hide();
            }
            if (button5.Text == "През светлинната фаза на фотосинт. се образува?")
            {
                player.Play();

                frm82 = new Form82();
                frm82.passTime1 = Time1;
                frm82.passTime2 = Time2;
                frm82.passTime3 = Time3;
                frm82.passTime4 = Time4;
                frm82.passTime5 = Time5;
                frm82.passTime6 = Time6;
                frm82.passTime7 = a;
                frm82.passCorrect = Correct;
                frm82.Show();
                Hide();
            }
        }

        private void Form81_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кой процес осигурява кислорода в атмосферата?";
                button1.Text = "Дишането";
                button2.Text = "Горенето";
                button3.Text = "Фотосинтезата"; // Верният Отговор
                button4.Text = "Разможаването";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой от хим. елемнти е макроелемент за клетката?";
                button1.Text = "Цинк";
                button2.Text = "Мед";
                button3.Text = "Азот"; // Верният Отговор
                button4.Text = "Флуор";
            }
            if (q1 == 3)
            {

                button5.Text = "През светлинната фаза на фотосинт. се образува?";
                button1.Text = "Кислород"; // Верният отговор
                button2.Text = "Въгл.диоксид";
                button3.Text = "Вода";
                button4.Text = "Глюкоза";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }
    }
}
