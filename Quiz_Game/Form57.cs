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
    public partial class Form57 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form58 frm58;
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
        public Form57()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form57_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Къде е основан първият тенис клуб?";
                button1.Text = "Франция"; // Верният Отговор
                button2.Text = "Англия";
                button3.Text = "Германия";
                button4.Text = "Швейцария";
            }
            if (q1 == 2)
            {
                button5.Text = "Дължината на тенис масата в метри е?";
                button1.Text = "2,83";
                button2.Text = "2,65";
                button3.Text = "2,74"; // Верният Отговор
                button4.Text = "2,51";
            }
            if (q1 == 3)
            {
                button5.Text = "Къде е измислен триатлонът?";
                button1.Text = "Австрия";
                button2.Text = "Италия";
                button3.Text = "Англия";
                button4.Text = "Франция"; // Верният отговор
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Къде е основан първият тенис клуб?")
            {
                player1.Play();
                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct + 1;
                frm58.Show();
                Hide();

            }
            if (button5.Text == "Дължината на тенис масата в метри е?")
            {
                player.Play();
                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct;
                frm58.Show();
                Hide();
            }
            if (button5.Text == "Къде е измислен триатлонът?")
            {
                player.Play();

                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct;
                frm58.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Къде е основан първият тенис клуб?")
            {
                player.Play();
                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct;
                frm58.Show();
                Hide();

            }
            if (button5.Text == "Дължината на тенис масата в метри е?")
            {
                player.Play();
                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct;
                frm58.Show();
                Hide();
            }
            if (button5.Text == "Къде е измислен триатлонът?")
            {
                player.Play();

                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct;
                frm58.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Къде е основан първият тенис клуб?")
            {
                player.Play();
                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct;
                frm58.Show();
                Hide();

            }
            if (button5.Text == "Дължината на тенис масата в метри е?")
            {
                player1.Play();
                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct + 1;
                frm58.Show();
                Hide();
            }
            if (button5.Text == "Къде е измислен триатлонът?")
            {
                player.Play();

                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct;
                frm58.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Къде е основан първият тенис клуб?")
            {
                player.Play();
                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct;
                frm58.Show();
                Hide();

            }
            if (button5.Text == "Дължината на тенис масата в метри е?")
            {
                player.Play();
                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct;
                frm58.Show();
                Hide();
            }
            if (button5.Text == "Къде е измислен триатлонът?")
            {
                player1.Play();

                
                frm58 = new Form58();
                frm58.passTime1 = Time1;
                frm58.passTime2 = Time2;
                frm58.passTime3 = a;
                frm58.passCorrect = Correct + 1;
                frm58.Show();
                Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }
    }
}
