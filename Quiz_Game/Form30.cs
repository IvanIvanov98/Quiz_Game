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
    public partial class Form30 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form31 frm31;
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
        public Form30()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form30_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Най-голям залив в западна Африка?";
                    button1.Text = "Суецки";
                    button2.Text = "Гвинейски"; // Верният Отговор
                    button3.Text = "Панамски";
                    button4.Text = "Северен";
                }
                if (q1 == 2)
                {
                    button5.Text = "Пристанището Харама принадлежи на страната?";
                    button1.Text = "Япония"; // Верният Отговор
                    button2.Text = "Китай";
                    button3.Text = "Индия";
                    button4.Text = "Тузбекистан"; 
                }
                if (q1 == 3)
                {
                    button5.Text = "На кой о-в се намира вулкана Еребус?";
                    button1.Text = "Левкада";
                    button2.Text = "Рос"; // Верният отговор
                    button3.Text = "Корфу";
                    button4.Text = "Тасус";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-голям залив в западна Африка?")
            {
                player.Play();
                
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct;
                frm31.Show();
                Hide();

            }
            if (button5.Text == "Пристанището Харама принадлежи на страната?")
            {
                player1.Play();   //Верен отговор
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct +1;
                frm31.Show();
                Hide();
            }
            if (button5.Text == "На кой о-в се намира вулкана Еребус?")
            {
                player.Play();
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct;
                frm31.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-голям залив в западна Африка?")
            {
                player1.Play();   //Верен отговор
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct + 1;
                frm31.Show();
                Hide();

            }
            if (button5.Text == "Пристанището Харама принадлежи на страната?")
            {
                player.Play();
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct;
                frm31.Show();
                Hide();
            }
            if (button5.Text == "На кой о-в се намира вулкана Еребус?")
            {
                player1.Play();   //Верен отговор
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct + 1;
                frm31.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-голям залив в западна Африка?")
            {
                player.Play();
                
                
                frm31 = new Form31();
                    frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct;
                frm31.Show();
                Hide();

            }
            if (button5.Text == "Пристанището Харама принадлежи на страната?")
            {
                player.Play();
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct;
                frm31.Show();
                Hide();
            }
            if (button5.Text == "На кой о-в се намира вулкана Еребус?")
            {
                player.Play();
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct;
                frm31.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-голям залив в западна Африка?")
            {
                player.Play();
                
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct;
                frm31.Show();
                Hide();

            }
            if (button5.Text == "Пристанището Харама принадлежи на страната?")
            {
                player.Play();
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct;
                frm31.Show();
                Hide();
            }
            if (button5.Text == "На кой о-в се намира вулкана Еребус?")
            {
                player.Play();
                
                frm31 = new Form31();
                frm31.passTime1 = Time1;
                frm31.passTime2 = Time2;
                frm31.passTime3 = Time3;
                frm31.passTime4 = Time4;
                frm31.passTime5 = Time5;
                frm31.passTime6 = a;
                frm31.passCorrect = Correct;
                frm31.Show();
                Hide();
            }
        }
    }
}
