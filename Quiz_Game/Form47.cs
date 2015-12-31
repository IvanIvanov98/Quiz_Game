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
    public partial class Form47 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form48 frm48;
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
        public Form47()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form47_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "С каква националност е Виталий Кличко?";
                    button1.Text = "Руска";
                    button2.Text = "Немска";
                    button3.Text = "Украинска"; // Верният Отговор
                    button4.Text = "Чешка"; 
                }
                if (q1 == 2)
                {
                    button5.Text = "Най-голямите успехи на МАН Ю са при?";
                    button1.Text = "Алекс Фъргюсън"; // Верният Отговор
                    button2.Text = "Дейвид Мойс";
                    button3.Text = "ван Гал";
                    button4.Text = "Райън Гигс";
                }
                if (q1 == 3)
                {
                    button5.Text = "Коя българка първа прескача 1.94м?";
                    button1.Text = "Венелина Венева";
                    button2.Text = "Стефка Костадионова";
                    button3.Text = "Йорданка Благоева"; // Верният отговор
                    button4.Text = "Людмила Андонова"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С каква националност е Виталий Кличко?")
            {

                player.Play();

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct;
                frm48.Show();
                Hide();

            }
            if (button5.Text == "Най-голямите успехи на МАН Ю са при?")
            {
                player1.Play();   //Верен отговор

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct + 1;
                frm48.Show();
                Hide();
            }
            if (button5.Text == "Коя българка първа прескача 1.94м?")
            {

                player.Play();

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct;
                frm48.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С каква националност е Виталий Кличко?")
            {

                player.Play();

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct;
                frm48.Show();
                Hide();

            }
            if (button5.Text == "Най-голямите успехи на МАН Ю са при?")
            {
                player.Play();   

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct;
                frm48.Show();
                Hide();
            }
            if (button5.Text == "Коя българка първа прескача 1.94м?")
            {

                player.Play();

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct;
                frm48.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С каква националност е Виталий Кличко?")
            {

                player1.Play();   //Верен отговор

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct + 1;
                frm48.Show();
                Hide();

            }
            if (button5.Text == "Най-голямите успехи на МАН Ю са при?")
            {
                player.Play();   

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct;
                frm48.Show();
                Hide();
            }
            if (button5.Text == "Коя българка първа прескача 1.94м?")
            {

                player1.Play();   //Верен отговор

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct + 1;
                frm48.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С каква националност е Виталий Кличко?")
            {

                player.Play();

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct;
                frm48.Show();
                Hide();

            }
            if (button5.Text == "Най-голямите успехи на МАН Ю са при?")
            {
                player.Play();   

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct;
                frm48.Show();
                Hide();
            }
            if (button5.Text == "Коя българка първа прескача 1.94м?")
            {

                player.Play();

                
                frm48 = new Form48();
                frm48.passTime1 = Time1;
                frm48.passTime2 = Time2;
                frm48.passTime3 = a;
                frm48.passCorrect = Correct;
                frm48.Show();
                Hide();
            }
        }
    }
}
