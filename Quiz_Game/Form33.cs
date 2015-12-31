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
    public partial class Form33 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form34 frm34;
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
        private int Time7;
        public int passTime7
        {
            get
            {
                return Time7;
            }
            set
            {
                Time7 = value;
            }
        }
        private int Time8;
        public int passTime8
        {
            get
            {
                return Time8;
            }
            set
            {
                Time8 = value;
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
        public Form33()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form33_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Страна, пионер в производство на фъстъци?";
                    button1.Text = "Испания"; // Верният Отговор
                    button2.Text = "Египет"; 
                    button3.Text = "Паргвай";
                    button4.Text = "Боливия";
                }
                if (q1 == 2)
                {
                    button5.Text = "От около колко души се състои монголската армия?";
                    button1.Text = "9900"; // Верният Отговор
                    button2.Text = "3,800";
                    button3.Text = "14,500";
                    button4.Text = "7,800"; 
                }
                if (q1 == 3)
                {
                    button5.Text = "На кое място по площ в света е Киргистан?";
                    button1.Text = "80";
                    button2.Text = "84"; // Верният отговор
                    button3.Text = "90";
                    button4.Text = "73";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Страна, пионер в производство на фъстъци?")
            {
                player1.Play();   //Верен отговор
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct + 1;
                frm34.Show();
                Hide();

            }
            if (button5.Text == "От около колко души се състои монголската армия?")
            {
                player1.Play();   //Верен отговор
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct + 1;
                frm34.Show();
                Hide();
            }
            if (button5.Text == "На кое място по площ в света е Киргистан?")
            {
                player.Play();
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct;
                frm34.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Страна, пионер в производство на фъстъци?")
            {
                player1.Play();   //Верен отговор
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct + 1;
                frm34.Show();
                Hide();

            }
            if (button5.Text == "От около колко души се състои монголската армия?")
            {
                player.Play();
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct;
                frm34.Show();
                Hide();
            }
            if (button5.Text == "На кое място по площ в света е Киргистан?")
            {
                player.Play();
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct;
                frm34.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Страна, пионер в производство на фъстъци?")
            {
                player.Play();
                
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct;
                frm34.Show();
                Hide();

            }
            if (button5.Text == "От около колко души се състои монголската армия?")
            {
                player.Play();
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct;
                frm34.Show();
                Hide();
            }
            if (button5.Text == "На кое място по площ в света е Киргистан?")
            {
                player.Play();
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct;
                frm34.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Страна, пионер в производство на фъстъци?")
            {
                player.Play();
               
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct;
                frm34.Show();
                Hide();

            }
            if (button5.Text == "От около колко души се състои монголската армия?")
            {
                player.Play();
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct;
                frm34.Show();
                Hide();
            }
            if (button5.Text == "На кое място по площ в света е Киргистан?")
            {
                player.Play();
                
                frm34 = new Form34();
                frm34.passTime1 = Time1;
                frm34.passTime2 = Time2;
                frm34.passTime3 = Time3;
                frm34.passTime4 = Time4;
                frm34.passTime5 = Time5;
                frm34.passTime6 = Time6;
                frm34.passTime7 = Time7;
                frm34.passTime8 = Time8;
                frm34.passTime9 = a;
                frm34.passCorrect = Correct;
                frm34.Show();
                Hide();
            }
        }
    }
}
