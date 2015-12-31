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
    public partial class Form10 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form11 frm11;
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
        public Form10()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кое животно е символ на Австралия?";
                button1.Text = "Змия";
                button2.Text = "Коза";
                button3.Text = "Делфин"; 
                button4.Text = "Кенгуру";  //Vерният Отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Коя е държавата с форма на ботуш?";
                button1.Text = "Италия"; // Верният Отговор
                button2.Text = "Испания"; 
                button3.Text = "Ботсуана";
                button4.Text = "Алжир";
            }
            if (q1 == 3)
            {
                button5.Text = "Къде се намират Хавайските острови?";
                button1.Text = "Индийски океан";
                button2.Text = "Южен океан";  
                button3.Text = "Тихи океан"; // Верният отговор
                button4.Text = "Атлантически океан";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое животно е символ на Австралия?")
            {
                player.Play();
               
                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = Correct ;

                frm11.Show();
                Hide();

            }
            if (button5.Text == "Коя е държавата с форма на ботуш?")
            {
                player1.Play();   //Верен отговор

                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = ( Correct + 1 );

                frm11.Show();
                Hide();
            }
            if (button5.Text == "Къде се намират Хавайските острови?")
            {
                player.Play();

                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = Correct;

                frm11.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое животно е символ на Австралия?")
            {
                player.Play();

                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = Correct;

                frm11.Show();
                Hide();

            }
            if (button5.Text == "Коя е държавата с форма на ботуш?")
            {
                player.Play();
                
                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = Correct;

                frm11.Show();
                Hide();
            }
            if (button5.Text == "Къде се намират Хавайските острови?")
            {
                player.Play();
                
                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = Correct;

                frm11.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое животно е символ на Австралия?")
            {
                player.Play();
                
                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = Correct;

                frm11.Show();
                Hide();

            }
            if (button5.Text == "Коя е държавата с форма на ботуш?")
            {
             
                player.Play();

                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = Correct;

                frm11.Show();
                Hide();
            }
            if (button5.Text == "Къде се намират Хавайските острови?")
            {
                player1.Play();
                
                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = (Correct + 1);

                frm11.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кое животно е символ на Австралия?")
            {
                player1.Play();

                frm11 = new Form11();
                frm11.passTime1 = Time1; // prashtaaaaaaaam
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = (Correct + 1);

                frm11.Show();
                Hide();
                
            }
            if (button5.Text == "Коя е държавата с форма на ботуш?")
            {
                player.Play();
                
                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = Correct;

                frm11.Show();
                Hide();
            }
            if (button5.Text == "Къде се намират Хавайските острови?")
            {
                player.Play();
                
                frm11 = new Form11();
                frm11.passTime1 = Time1;
                frm11.passTime2 = Time2;
                frm11.passTime3 = Time3;
                frm11.passTime4 = Time4;
                frm11.passTime5 = Time5;
                frm11.passTime6 = Time6;
                frm11.passTime7 = a;

                frm11.passCorrect = Correct;

                frm11.Show();
                Hide();
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
