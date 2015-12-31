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
    public partial class Form18 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        Form19 frm19;
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
        public Form18()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
               
                button5.Text = "Най-западната европейска точка е в?";
                button1.Text = "Норвегия"; 
                button2.Text = "Испания";
                button3.Text = "Англия";
                button4.Text = "Потругалия"; // Верният Отговор
            }
            if (q1 == 2)
            {
                button5.Text = "Най-населената страна е ЕС е?";
                button1.Text = "Великобритания";
                button2.Text = "Франция"; // Верният Отговор
                button3.Text = "Германия"; 
                button4.Text = "Италия";
            }
            if (q1 == 3)
            {
                button5.Text = "Дингото е животно, характерно за?";
                button1.Text = "Африка";
                button2.Text = "Южна Америка";
                button3.Text = "Австралия"; // Верният отговор
                button4.Text = "Европа"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-западната европейска точка е в?")
            {
                player.Play();
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = Correct;
                frm19.Show();
                Hide();

            }
            if (button5.Text == "Най-населената страна е ЕС е?")
            {
                player.Play();
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = Correct;
                frm19.Show();
                Hide();
            }
            if (button5.Text == "Дингото е животно, характерно за?")
            {
                player.Play();
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = Correct;
                frm19.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-западната европейска точка е в?")
            {
                player.Play();
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = Correct;
                frm19.Show();
                Hide();

            }
            if (button5.Text == "Най-населената страна е ЕС е?")
            {
                player1.Play();   //Верен отговор
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = (Correct + 1);
                frm19.Show();
                Hide();
            }
            if (button5.Text == "Дингото е животно, характерно за?")
            {
                player.Play();
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = Correct;
                frm19.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button5.Text == "Най-западната европейска точка е в?")
            {
                player.Play();
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = Correct;
                frm19.Show();
                Hide();

            }
            if (button5.Text == "Най-населената страна е ЕС е?")
            {
                player.Play();
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = Correct;
                frm19.Show();
                Hide();
            }
            if (button5.Text == "Дингото е животно, характерно за?")
            {
                player1.Play();   //Верен отговор
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = (Correct + 1);
                frm19.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-западната европейска точка е в?")
            {
                player1.Play();  // Верен оттговор
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = (Correct + 1);
                frm19.Show();
                Hide();

            }
            if (button5.Text == "Най-населената страна е ЕС е?")
            {
                player.Play();
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = Correct;
                frm19.Show();
                Hide();
            }
            if (button5.Text == "Дингото е животно, характерно за?")
            {
                player.Play();
                
                frm19 = new Form19();
                frm19.passTime1 = Time1;
                frm19.passTime2 = Time2;
                frm19.passTime3 = Time3;
                frm19.passTime4 = a;
                frm19.passCorrect = Correct;
                frm19.Show();
                Hide();
            }
        }
    }
}
