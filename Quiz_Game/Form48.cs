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
    public partial class Form48 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form49 frm49;
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
        public Form48()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form48_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Колко пъти С. Костадинова подобрява рекорда си?";
                    button1.Text = "3"; // Верният Отговор
                    button2.Text = "10";
                    button3.Text = "0";
                    button4.Text = "7"; 
                }
                if (q1 == 2)
                {
                    button5.Text = "Кой футбол. отбор печели ШЛ през 2013/14?";
                    button1.Text = "Барселона"; 
                    button2.Text = "Атл. Мадрид";
                    button3.Text = "Реал Мадрид"; // Верният Отговор
                    button4.Text = "Челси";
                }
                if (q1 == 3)
                {
                    button5.Text = "Отборът с най-много финали в ШЛ е?";
                    button1.Text = "Реал Мадрид"; // Верният отговор
                    button2.Text = "Милан";
                    button3.Text = "Ман Ю";
                    button4.Text = "Порто"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко пъти С. Костадинова подобрява рекорда си?")
            {

                player1.Play();   //Верен отговор

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct + 1;
                frm49.Show();
                Hide();

            }
            if (button5.Text == "Кой футбол. отбор печели ШЛ през 2013/14?")
            {
                player.Play();   

                
                frm49 = new Form49();
                 frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct;
                frm49.Show();
                Hide();
            }
            if (button5.Text == "Отборът с най-много финали в ШЛ е?")
            {

                player1.Play();   //Верен отговор

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct + 1;
                frm49.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко пъти С. Костадинова подобрява рекорда си?")
            {

                player.Play();

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct;
                frm49.Show();
                Hide();

            }
            if (button5.Text == "Кой футбол. отбор печели ШЛ през 2013/14?")
            {
                player.Play();   

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct;
                frm49.Show();
                Hide();
            }
            if (button5.Text == "Отборът с най-много финали в ШЛ е?")
            {

                player.Play();

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct;
                frm49.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко пъти С. Костадинова подобрява рекорда си?")
            {

                player.Play();

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct;
                frm49.Show();
                Hide();

            }
            if (button5.Text == "Кой футбол. отбор печели ШЛ през 2013/14?")
            {
                player1.Play();   //Верен отговор

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct + 1;
                frm49.Show();
                Hide();
            }
            if (button5.Text == "Отборът с най-много финали в ШЛ е?")
            {

                player.Play();

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct;
                frm49.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Колко пъти С. Костадинова подобрява рекорда си?")
            {

                player.Play();

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct;
                frm49.Show();
                Hide();

            }
            if (button5.Text == "Кой футбол. отбор печели ШЛ през 2013/14?")
            {
                player.Play();   

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct;
                frm49.Show();
                Hide();
            }
            if (button5.Text == "Отборът с най-много финали в ШЛ е?")
            {

                player.Play();

                
                frm49 = new Form49();
                frm49.passTime1 = Time1;
                frm49.passTime2 = Time2;
                frm49.passTime3 = Time3;
                frm49.passTime4 = a;
                frm49.passCorrect = Correct;
                frm49.Show();
                Hide();
            }
        }
    }
}
