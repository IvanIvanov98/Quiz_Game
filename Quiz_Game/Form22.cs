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
    public partial class Form22 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form23 frm23;
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
        public Form22()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Най-благата на злато страна е?";
                    button1.Text = "Индия"; 
                    button2.Text = "Китай";
                    button3.Text = "Русия";
                    button4.Text = "САЩ"; // Верният Отговор
                }
                if (q1 == 2)
                {
                    button5.Text = "Най-студеното място в Света е в?";
                    button1.Text = "Сибир";
                    button2.Text = "Гренландия"; // Верният Отговор
                    button3.Text = "Аляска"; 
                    button4.Text = "Канада";
                }
                if (q1 == 3)
                {
                    button5.Text = "Най-топла страна в Света е?";
                    button1.Text = "Етиопия";
                    button2.Text = "Индонезия";
                    button3.Text = "Виетнам";
                    button4.Text = "Катар"; // Верният отговор
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-благата на злато страна е?")
            {
                player.Play();
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = Correct;
                frm23.Show();
                Hide();

            }
            if (button5.Text == "Най-студеното място в Света е в?")
            {
                player.Play();
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = Correct;
                frm23.Show();
                Hide();
            }
            if (button5.Text == "Най-топла страна в Света е?")
            {
                player.Play();
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = Correct;
                frm23.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-благата на злато страна е?")
            {
                player.Play();
                
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = Correct;
                frm23.Show();
                Hide();

            }
            if (button5.Text == "Най-студеното място в Света е в?")
            {
                player1.Play();   //Верен отговор
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = (Correct + 1);
                frm23.Show();
                Hide();
            }
            if (button5.Text == "Най-топла страна в Света е?")
            {
                player.Play();
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = Correct;
                frm23.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Най-благата на злато страна е?")
            {
                player.Play();
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = Correct;
                frm23.Show();
                Hide();

            }
            if (button5.Text == "Най-студеното място в Света е в?")
            {
                player.Play();
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = Correct;
                frm23.Show();
                Hide();
            }
            if (button5.Text == "Най-топла страна в Света е?")
            {
                player.Play();
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = Correct;
                frm23.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button5.Text == "Най-благата на злато страна е?")
            {
                player1.Play();   //Верен отговор
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = (Correct + 1);
                frm23.Show();
                Hide();

            }
            if (button5.Text == "Най-студеното място в Света е в?")
            {
                player.Play();
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = Correct;
                frm23.Show();
                Hide();
            }
            if (button5.Text == "Най-топла страна в Света е?")
            {
                player1.Play();   //Верен отговор
                
                frm23 = new Form23();
                frm23.passTime1 = Time1;
                frm23.passTime2 = Time2;
                frm23.passTime3 = Time3;
                frm23.passTime4 = Time4;
                frm23.passTime5 = Time5;
                frm23.passTime6 = Time6;
                frm23.passTime7 = Time7;
                frm23.passTime8 = a;
                frm23.passCorrect = (Correct + 1);
                frm23.Show();
                Hide();
            }
        }
    }
}
