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
    public partial class Form61 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form62 frm62;
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
        public Form61()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form61_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Най-скъпо платен спортис в Света е?";
                    button1.Text = "Леброн Джеймс";
                    button2.Text = "Тайгър Уудс";
                    button3.Text = "Флойд Мейуедър"; // Верният Отговор
                    button4.Text = "Роджър Федерер";
                }
                if (q1 == 2)
                {
                    button5.Text = "Най старият лекоатлетически рекорд е на?";
                    button1.Text = "Ярмила Кратохвилова";  // Верният Отговор
                    button2.Text = "Майкъл Джонсън";
                    button3.Text = "Кевин Йънг";
                    button4.Text = "Майк Паулъл";
                }
                if (q1 == 3)
                {
                    button5.Text = "Най-много вкарани точки в баскетболен мач има?";
                    button1.Text = "Майкъл Джордън";
                    button2.Text = "Уилт Чембърлейн"; // Верният отговор
                    button3.Text = "Коби Брйънт";
                    button4.Text = "Бил Ръсел";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-скъпо платен спортис в Света е?")
            {
                player.Play();
                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct;
                frm62.Show();
                Hide();

            }
            if (button5.Text == "Най старият лекоатлетически рекорд е на?")
            {
                player1.Play();
                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct + 1;
                frm62.Show();
                Hide();

            }
            if (button5.Text == "Най-много вкарани точки в баскетболен мач има?")
            {
                player.Play();

                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct;
                frm62.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-скъпо платен спортис в Света е?")
            {
                player.Play();
                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct;
                frm62.Show();
                Hide();
            }
            if (button5.Text == "Най старият лекоатлетически рекорд е на?")
            {
                player1.Play();
                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct + 1;
                frm62.Show();
                Hide();
            }
            if (button5.Text == "Най-много вкарани точки в баскетболен мач има?")
            {
                player.Play();

                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct;
                frm62.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-скъпо платен спортис в Света е?")
            {
                player1.Play();
                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct + 1;
                frm62.Show();
                Hide();

            }
            if (button5.Text == "Най старият лекоатлетически рекорд е на?")
            {
                player.Play();
                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct;
                frm62.Show();
                Hide();
            }
            if (button5.Text == "Най-много вкарани точки в баскетболен мач има?")
            {
                player.Play();

                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct;
                frm62.Show();
                Hide();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-скъпо платен спортис в Света е?")
            {
                player.Play();
                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct;
                frm62.Show();
                Hide();

            }
            if (button5.Text == "Най старият лекоатлетически рекорд е на?")
            {
                player.Play();
                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct;
                frm62.Show();
                Hide();
            }
            if (button5.Text == "Най-много вкарани точки в баскетболен мач има?")
            {
                player.Play();

                
                frm62 = new Form62();
                frm62.passTime1 = Time1;
                frm62.passTime2 = Time2;
                frm62.passTime3 = Time3;
                frm62.passTime4 = Time4;
                frm62.passTime5 = Time5;
                frm62.passTime6 = Time6;
                frm62.passTime7 = a;
                frm62.passCorrect = Correct;
                frm62.Show();
                Hide();
            }
        }
    }
}
