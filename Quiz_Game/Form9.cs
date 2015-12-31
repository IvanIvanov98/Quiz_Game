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
    public partial class Form9 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form10 frm10;
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
        public Form9()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кой е най-големия континент в света?";
                button1.Text = "Европа"; 
                button2.Text = "Австралия";
                button3.Text = "Азия"; // Верният Отговор
                button4.Text = "Африка";
            }
            if (q1 == 2)
            {
                button5.Text = "Къде се намират Сейшелските острови?";
                button1.Text = "Тихи океан";
                button2.Text = "Индийски океан"; // Верният Отговор
                button3.Text = "Атлантически океан"; 
                button4.Text = "Южен океан";
            }
            if (q1 == 3)
            {
                button5.Text = "Кой е най-големия град в Австралия?";
                button1.Text = "Канбера";
                button2.Text = "Сидни";  // Верният отговор
                button3.Text = "Мелбърн";
                button4.Text = "Тайван";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е най-големия континент в света?")
            {
                player.Play();
 
                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = Correct ;

                frm10.Show();
                Hide();

            }
            if (button5.Text == "Къде се намират Сейшелските острови?")
            {
                player.Play();
                
                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = Correct;

                frm10.Show();
                Hide();
            }
            if (button5.Text == "Кой е най-големия град в Австралия?")
            {
                player.Play();
                
                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = Correct;

                frm10.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е най-големия континент в света?")
            {
                player.Play();

                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = Correct;

                frm10.Show();
                Hide();

            }
            if (button5.Text == "Къде се намират Сейшелските острови?")
            {
                player1.Play();

                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = (Correct + 1);

                frm10.Show();
                Hide();
            }
            if (button5.Text == "Кой е най-големия град в Австралия?")
            {
                player1.Play();

                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = (Correct + 1);

                frm10.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е най-големия континент в света?") 
            {
                player1.Play();

                frm10 = new Form10();
                frm10.passTime1 = Time1; // prashtaaaaaam
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = (Correct + 1);

                frm10.Show();
                Hide();
                
            }
            if (button5.Text == "Къде се намират Сейшелските острови?")
            {
                player.Play();
                
                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = Correct;

                frm10.Show();
                Hide();
            }
            if (button5.Text == "Кой е най-големия град в Австралия?")
            {
                player.Play();

                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = Correct;

                frm10.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е най-големия континент в света?")
            {
                player.Play();

                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = Correct;

                frm10.Show();
                Hide();

            }
            if (button5.Text == "Къде се намират Сейшелските острови?")
            {
                player.Play();

                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = Correct;

                frm10.Show();
                Hide();
            }
            if (button5.Text == "Кой е най-големия град в Австралия?")
            {
                player.Play();

                frm10 = new Form10();
                frm10.passTime1 = Time1;
                frm10.passTime2 = Time2;
                frm10.passTime3 = Time3;
                frm10.passTime4 = Time4;
                frm10.passTime5 = Time5;
                frm10.passTime6 = a;

                frm10.passCorrect = Correct;

                frm10.Show();
                Hide();
            }
        }
    }
}
