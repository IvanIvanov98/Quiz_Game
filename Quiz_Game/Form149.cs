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
    public partial class Form149 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form150 frm150;
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
        public Form149()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form149_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "От кого е композирана музиката в „Титаник“?";
                button1.Text = "Джон Уилямс";
                button2.Text = "Голдсмит";
                button3.Text = "Джеймс Хорнър";  // Верният отговор
                button4.Text = "Ханс Цимер";
            }
            if (q1 == 2)
            {
                button5.Text = "В кое направление твори Караваджо?";
                button1.Text = "Импресиознизъм"; 
                button2.Text = "Барок"; // Верният Отговор
                button3.Text = "Кубизъм";
                button4.Text = "Постимпресионизъм";
            }
            if (q1 == 3)
            {

                button5.Text = "Кога започват да се изобразяват човешки форми?";
                button1.Text = "7 век пр.Хр."; // Верният отговор
                button2.Text = "2 век пр.Хр.";  
                button3.Text = "1 век";
                button4.Text = "5 век";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "От кого е композирана музиката в „Титаник“?")
            {
                player.Play();


                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct;
                frm150.Show();
                Hide();

            }
            if (button5.Text == "В кое направление твори Караваджо?")
            {
                player.Play();

                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct;
                frm150.Show();
                Hide();
            }
            if (button5.Text == "Кога започват да се изобразяват човешки форми?")
            {
                player1.Play();

                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct + 1;
                frm150.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "От кого е композирана музиката в „Титаник“?")
            {
                player.Play();


                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct;
                frm150.Show();
                Hide();

            }
            if (button5.Text == "В кое направление твори Караваджо?")
            {
                player1.Play();

                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct + 1;
                frm150.Show();
                Hide();
            }
            if (button5.Text == "Кога започват да се изобразяват човешки форми?")
            {
                player.Play();

                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct;
                frm150.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "От кого е композирана музиката в „Титаник“?")
            {
                player1.Play();


                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct + 1;
                frm150.Show();
                Hide();

            }
            if (button5.Text == "В кое направление твори Караваджо?")
            {
                player.Play();

                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct;
                frm150.Show();
                Hide();
            }
            if (button5.Text == "Кога започват да се изобразяват човешки форми?")
            {
                player.Play();

                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct;
                frm150.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "От кого е композирана музиката в „Титаник“?")
            {
                player.Play();


                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct;
                frm150.Show();
                Hide();

            }
            if (button5.Text == "В кое направление твори Караваджо?")
            {
                player.Play();

                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct;
                frm150.Show();
                Hide();
            }
            if (button5.Text == "Кога започват да се изобразяват човешки форми?")
            {
                player.Play();

                frm150 = new Form150();
                frm150.passTime1 = Time1;
                frm150.passTime2 = Time2;
                frm150.passTime3 = Time3;
                frm150.passTime4 = Time4;
                frm150.passTime5 = a;
                frm150.passCorrect = Correct;
                frm150.Show();
                Hide();
            }
        }
    }
}
