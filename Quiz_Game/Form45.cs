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
    public partial class Form45 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form46 frm46;
        int a = 0;
        int Correct = 0;
        public Form45()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form45_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Отборът спечелил свет. баск. титла през 2014 е?";
                    button1.Text = "САЩ"; // Верният Отговор
                    button2.Text = "Сърбия";
                    button3.Text = "Испания";
                    button4.Text = "Франция"; 
                }
                if (q1 == 2)
                {
                    button5.Text = "Кои отбори има равен брой свет. баск. титли?";
                    button1.Text = "САЩ и СССР"; 
                    button2.Text = "САЩ и Сърбия"; // Верният Отговор
                    button3.Text = "Франция и България";
                    button4.Text = "САЩ и Бразилия";
                }
                if (q1 == 3)
                {
                    button5.Text = "Летните олимпйски игри 2016 ще се проведат в?";
                    button1.Text = "Бразилия"; // Верният отговор
                    button2.Text = "Токио";
                    button3.Text = "Ню Йорк";
                    button4.Text = "Париж"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Отборът спечелил свет. баск. титла през 2014 е?")
            {

                player1.Play(); // Верен отговор

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct + 1;
                frm46.Show();
                Hide();

            }
            if (button5.Text == "Кои отбори има равен брой свет. баск. титли?")
            {
                player.Play();   

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct;
                frm46.Show();
                Hide();
            }
            if (button5.Text == "Летните олимпйски игри 2016 ще се проведат в?")
            {

                player1.Play(); // Верен Отговор

                
                frm46 = new Form46();
                frm46.passCorrect = Correct + 1;
                frm46.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Отборът спечелил свет. баск. титла през 2014 е?")
            {

                player.Play();

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct;
                frm46.Show();
                Hide();

            }
            if (button5.Text == "Кои отбори има равен брой свет. баск. титли?")
            {
                player1.Play();   //Верен отговор

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct + 1;
                frm46.Show();
                Hide();
            }
            if (button5.Text == "Летните олимпйски игри 2016 ще се проведат в?")
            {

                player.Play();

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct;
                frm46.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Отборът спечелил свет. баск. титла през 2014 е?")
            {

                player.Play();

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct;
                frm46.Show();
                Hide();

            }
            if (button5.Text == "Кои отбори има равен брой свет. баск. титли?")
            {
                player.Play();   

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct;
                frm46.Show();
                Hide();
            }
            if (button5.Text == "Летните олимпйски игри 2016 ще се проведат в?")
            {

                player.Play();

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct;
                frm46.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Отборът спечелил свет. баск. титла през 2014 е?")
            {

                player.Play();

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct;
                frm46.Show();
                Hide();

            }
            if (button5.Text == "Кои отбори има равен брой свет. баск. титли?")
            {
                player.Play();   

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct;
                frm46.Show();
                Hide();
            }
            if (button5.Text == "Летните олимпйски игри 2016 ще се проведат в?")
            {

                player.Play();

                
                frm46 = new Form46();
                frm46.passTime1 = a;
                frm46.passCorrect = Correct;
                frm46.Show();
                Hide();
            }
        }
    }
}
