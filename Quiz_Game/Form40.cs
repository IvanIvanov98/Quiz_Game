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
    public partial class Form40 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        
        private Form41 frm41;
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

        public Form40()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form40_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "В кой от посочените спортове се носи каска?";
                    button1.Text = "Баскетбол";
                    button2.Text = "Ръгби"; // Верният Отговор
                    button3.Text = "Джитбол";
                    button4.Text = "Голф"; 
                }
                if (q1 == 2)
                {
                    button5.Text = "В кой спорт се играе с шайба?";
                    button1.Text = "Хокей на лед"; // Верният Отговор
                    button2.Text = "Плуване";
                    button3.Text = "Биатлон"; 
                    button4.Text = "Карате";
                }
                if (q1 == 3)
                {
                    button5.Text = "Рафаел Надал е?";
                    button1.Text = "Тенесист"; //Верен отговор
                    button2.Text = "Треньор";
                    button3.Text = "Бизнесмен";
                    button4.Text = "Ковач";  
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой от посочените спортове се носи каска?")
            {

                player.Play();

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct;
                frm41.Show();
                Hide();

            }
            if (button5.Text == "В кой спорт се играе с шайба?")
            {
                player1.Play();   //Верен отговор

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct + 1;
                frm41.Show();
                Hide();
            }
            if (button5.Text == "Рафаел Надал е?")
            {
                player1.Play();   //Верен отговор

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct + 1;
                frm41.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой от посочените спортове се носи каска?")
            {
                player1.Play(); //Верен отговор

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct + 1;
                frm41.Show();
                Hide();

            }
            if (button5.Text == "В кой спорт се играе с шайба?")
            {
                player.Play();   

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct;
                frm41.Show();
                Hide();
            }
            if (button5.Text == "Рафаел Надал е?")
            {
                player.Play();

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct;
                frm41.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой от посочените спортове се носи каска?")
            {
                player.Play();

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct;
                frm41.Show();
                Hide();

            }
            if (button5.Text == "В кой спорт се играе с шайба?")
            {
                player.Play();

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct;
                frm41.Show();
                Hide();
            }
            if (button5.Text == "Рафаел Надал е?")
            {
                player.Play();

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct;
                frm41.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой от посочените спортове се носи каска?")
            {
                player.Play();
                

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct;
                frm41.Show();
                Hide();

            }
            if (button5.Text == "В кой спорт се играе с шайба?")
            {
                player.Play();

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct;
                frm41.Show();
                Hide();
            }
            if (button5.Text == "Рафаел Надал е?")
            {
                player.Play();
                

                
                frm41 = new Form41();
                frm41.passTime1 = Time1;
                frm41.passTime2 = Time2;
                frm41.passTime3 = Time3;
                frm41.passTime4 = Time4;
                frm41.passTime5 = Time5;
                frm41.passTime6 = a;
                frm41.passCorrect = Correct;
                frm41.Show();
                Hide();
            }
        }
    }
}
