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
    public partial class Form60 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form61 frm61;
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
        public Form60()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form60_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Нац. рекорд на България в маратона принадлежи на?";
                    button1.Text = "Станислав Ламбев";
                    button2.Text = "Евгени Игнатов";
                    button3.Text = "Красен Кралев";
                    button4.Text = "Христо Стефанов"; // Верният Отговор
                }
                if (q1 == 2)
                {
                    button5.Text = "Първа нац. плувна организация е създадена в?";
                    button1.Text = "САЩ";
                    button2.Text = "Англия";
                    button3.Text = "Япония";  // Верният Отговор
                    button4.Text = "Финландия";
                }
                if (q1 == 3)
                {
                    button5.Text = "С каква големина е едно баскетболно изгрище?";
                    button1.Text = "28 на 15м"; // Верният отговор
                    button2.Text = "30 на 15м";
                    button3.Text = "25 на 20 м";
                    button4.Text = "30 на 10м";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Нац. рекорд на България в маратона принадлежи на?")
            {
                player.Play();
                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct;
                frm61.Show();
                Hide();

            }
            if (button5.Text == "Първа нац. плувна организация е създадена в?")
            {
                player.Play();
                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct;
                frm61.Show();
                Hide();
            }
            if (button5.Text == "С каква големина е едно баскетболно изгрище?")
            {
                player1.Play();

                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct + 1;
                frm61.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Нац. рекорд на България в маратона принадлежи на?")
            {
                player.Play();
                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct;
                frm61.Show();
                Hide();

            }
            if (button5.Text == "Първа нац. плувна организация е създадена в?")
            {
                player.Play();
                
                frm61 = new Form61();
                frm61.Show();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct;
                Hide();
            }
            if (button5.Text == "С каква големина е едно баскетболно изгрище?")
            {
                player.Play();

                
                frm61 = new Form61();
                frm61.Show();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct;
                Hide();
            }
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Нац. рекорд на България в маратона принадлежи на?")
            {
                player.Play();
                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct;
                frm61.Show();
                Hide();

            }
            if (button5.Text == "Първа нац. плувна организация е създадена в?")
            {
                player1.Play();
                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct + 1;
                frm61.Show();
                Hide();
            }
            if (button5.Text == "С каква големина е едно баскетболно изгрище?")
            {
                player.Play();

                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct;
                frm61.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Нац. рекорд на България в маратона принадлежи на?")
            {
                player1.Play();
                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct + 1;
                frm61.Show();
                Hide();

            }
            if (button5.Text == "Първа нац. плувна организация е създадена в?")
            {
                player.Play();
                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct;
                frm61.Show();
                Hide();
            }
            if (button5.Text == "С каква големина е едно баскетболно изгрище?")
            {
                player.Play();

                
                frm61 = new Form61();
                frm61.passTime1 = Time1;
                frm61.passTime2 = Time2;
                frm61.passTime3 = Time3;
                frm61.passTime4 = Time4;
                frm61.passTime5 = Time5;
                frm61.passTime6 = a;
                frm61.passCorrect = Correct;
                frm61.Show();
                Hide();
            }
        }
    }
}
