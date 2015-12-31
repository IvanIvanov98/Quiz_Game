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
    public partial class Form6 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form7 frm7;
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
            public Form6()
        {
            InitializeComponent();

            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form6_Load(object sender, EventArgs e)
        {

            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кой е най-високия връх в България?";
                button1.Text = "Ботев";
                button2.Text = "Мусала"; // Верният Отговор
                button3.Text = "Вихрен";
                button4.Text = "Пирин";
            }
            if (q1 == 2)
            {
                button5.Text = "Къде се среща Тасманийският дявол?";
                button1.Text = "О-в Тасмания"; // Верният Отговор 
                button2.Text = "О-в Мадагаскар";
                button3.Text = "Китай";
                button4.Text = "Япония";
            }
            if (q1 == 3)
            {
                button5.Text = "Коя е най-голямата страна в света?";
                button1.Text = "Китай";
                button2.Text = "Канада";
                button3.Text = "Русия"; // Верния Отговор
                button4.Text = "Белгия";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е най-високия връх в България?")
            {
                player.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = Correct;

                frm7.Show();
                Hide();

            }
            if (button5.Text == "Къде се среща Тасманийският дявол?")
            {
                player1.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = (Correct + 1);

                frm7.Show();
                Hide();
            }
            if (button5.Text == "Коя е най-голямата страна в света?") 

            {
                player.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = Correct;

                frm7.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е най-високия връх в България?")
            {
                player1.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1; // prashtaaaaam
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;
                frm7.passCorrect = (Correct + 1);
                frm7.Show();
                Hide();
                
            }
            if (button5.Text == "Къде се среща Тасманийският дявол?")
            {
                player.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = Correct;

                frm7.Show();
                Hide();
            }
            if (button5.Text == "Коя е най-голямата страна в света?")
            {
                player.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = Correct;

                frm7.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е най-високия връх в България?")
            {
                player.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = Correct;

                frm7.Show();
                Hide();

            }
            if (button5.Text == "Къде се среща Тасманийският дявол?")
            {
                player.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = Correct;

                frm7.Show();
                Hide();
            }
            if (button5.Text == "Коя е най-голямата страна в света?")
            {
                player1.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = (Correct + 1);

                frm7.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е най-високия връх в България?")
            {
                player.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = Correct;

                frm7.Show();
                Hide();

            }
            if (button5.Text == "Къде се среща Тасманийският дявол?")
            {
                player.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = Correct;

                frm7.Show();
                Hide();
            }
            if (button5.Text == "Коя е най-голямата страна в света?")
            {
                player.Play();


                frm7 = new Form7();
                frm7.passTime1 = Time1;
                frm7.passTime2 = Time2;
                frm7.passTime3 = a;

                frm7.passCorrect = Correct;

                frm7.Show();
                Hide();
            }
        }
    }
}
