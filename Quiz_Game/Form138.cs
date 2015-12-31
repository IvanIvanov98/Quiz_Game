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
    public partial class Form138 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form139 frm139;
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
        public Form138()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form138_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Литературен похват, който осмива хора или явления е?";
                button1.Text = "Комедия"; // Верният отговор
                button2.Text = "Сатира";
                button3.Text = "Драма";  
                button4.Text = "Трагедия";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой е режисьорът на „Междузвездни войни“?";
                button1.Text = "Джейс Александър"; 
                button2.Text = "Пийт Зон";
                button3.Text = "Данис Танович";
                button4.Text = "Джей Джей Ейбръмс"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Коя е главната актриса в „Титаник“?";
                button1.Text = "Анджелина Джоли";
                button2.Text = "Кейт Уинслет"; // Верният отговор
                button3.Text = "Кати Бейтс";
                button4.Text = "Вивиан Лий";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Литературен похват, който осмива хора или явления е?")
            {
                player1.Play();


                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct + 1;
                frm139.Show();
                Hide();

            }
            if (button5.Text == "Кой е режисьорът на „Междузвездни войни“?")
            {
                player.Play();

                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct;
                frm139.Show();
                Hide();
            }
            if (button5.Text == "Коя е главната актриса в „Титаник“?")
            {
                player.Play();

                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct;
                frm139.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Литературен похват, който осмива хора или явления е?")
            {
                player.Play();


                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct;
                frm139.Show();
                Hide();

            }
            if (button5.Text == "Кой е режисьорът на „Междузвездни войни“?")
            {
                player.Play();

                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct;
                frm139.Show();
                Hide();
            }
            if (button5.Text == "Коя е главната актриса в „Титаник“?")
            {
                player1.Play();

                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct + 1;
                frm139.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Литературен похват, който осмива хора или явления е?")
            {
                player.Play();


                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct;
                frm139.Show();
                Hide();

            }
            if (button5.Text == "Кой е режисьорът на „Междузвездни войни“?")
            {
                player.Play();

                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct;
                frm139.Show();
                Hide();
            }
            if (button5.Text == "Коя е главната актриса в „Титаник“?")
            {
                player.Play();

                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct;
                frm139.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Литературен похват, който осмива хора или явления е?")
            {
                player.Play();


                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct;
                frm139.Show();
                Hide();

            }
            if (button5.Text == "Кой е режисьорът на „Междузвездни войни“?")
            {
                player1.Play();

                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct + 1;
                frm139.Show();
                Hide();
            }
            if (button5.Text == "Коя е главната актриса в „Титаник“?")
            {
                player.Play();

                frm139 = new Form139();
                frm139.passTime1 = Time1;
                frm139.passTime2 = Time2;
                frm139.passTime3 = Time3;
                frm139.passTime4 = a;
                frm139.passCorrect = Correct;
                frm139.Show();
                Hide();
            }
        }
    }
}
