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
    public partial class Form19 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form20 frm20;
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
        public Form19()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Столицата на Словения е?";
                    button1.Text = "Любляна"; // Верният Отговор
                    button2.Text = "Братислава";
                    button3.Text = "Прага";
                    button4.Text = "Сараево";
                }
                if (q1 == 2)
                {
                    
                    button5.Text = "Столицата на Словакия е?";
                    button1.Text = "Будапеща";
                    button2.Text = "Братислава"; // Верният Отговор
                    button3.Text = "Любляна"; 
                    button4.Text = "Берн";
                }
                if (q1 == 3)
                {
                    button5.Text = "Най-малката държава в Света е?";
                    button1.Text = "Андора";
                    button2.Text = "Монако";
                    button3.Text = "Ватикана"; // Верният отговор
                    button4.Text = "Малта";  
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столицата на Словения е?")
            {
                player1.Play();   //Верен отговор
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = (Correct + 1);
                frm20.Show();
                Hide();

            }
            if (button5.Text == "Столицата на Словакия е?")
            {
                player.Play();
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = Correct;
                frm20.Show();
                Hide();
            }
            if (button5.Text == "Най-малката държава в Света е?")
            {
                player.Play();
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = Correct;
                frm20.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столицата на Словения е?")
            {
                player.Play();
               
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = Correct;
                frm20.Show();
                Hide();

            }
            if (button5.Text == "Столицата на Словакия е?")
            {
                player1.Play();   //Верен отговор
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = (Correct + 1);
                frm20.Show();
                Hide();
            }
            if (button5.Text == "Най-малката държава в Света е?")
            {
                player.Play();
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = Correct;
                frm20.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столицата на Словения е?")
            {
                player.Play();
                
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = Correct;
                frm20.Show();
                Hide();

            }
            if (button5.Text == "Столицата на Словакия е?")
            {
                player.Play();
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = Correct;
                frm20.Show();
                Hide();
            }
            if (button5.Text == "Най-малката държава в Света е?")
            {
                player1.Play();   //Верен отговор
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = (Correct + 1);
                frm20.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столицата на Словения е?")
            {
                player.Play();
                
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = Correct;
                frm20.Show();
                Hide();

            }
            if (button5.Text == "Столицата на Словакия е?")
            {
                player.Play();
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = Correct;
                frm20.Show();
                Hide();
            }
            if (button5.Text == "Най-малката държава в Света е?")
            {
                player.Play();
                
                frm20 = new Form20();
                frm20.passTime1 = Time1;
                frm20.passTime2 = Time2;
                frm20.passTime3 = Time3;
                frm20.passTime4 = Time4;
                frm20.passTime5 = a;
                frm20.passCorrect = Correct;
                frm20.Show();
                Hide();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
