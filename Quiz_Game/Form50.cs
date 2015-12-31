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
    public partial class Form50 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form51 frm51;
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
        public Form50()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form50_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "С каква националност е Диего Марадона?";
                    button1.Text = "Уругвайска";
                    button2.Text = "Мексиканска";
                    button3.Text = "Бразилска";
                    button4.Text = "Аржентинска"; // Верният Отговор
                }
                if (q1 == 2)
                {
                    button5.Text = "Кой отбор от НБА има най-много поредни победи?";
                    button1.Text = "ЛА Лейкърс"; // Верният Отговор
                    button2.Text = "Чикаго Булс";
                    button3.Text = "Бостън Селтикс";
                    button4.Text = "Маями Хийт";
                }
                if (q1 == 3)
                {
                    button5.Text = "Най-много победи в редовен сезон има?";
                    button1.Text = "Чикаго Булс"; // Верният отговор
                    button2.Text = "Атланта Хоукс";
                    button3.Text = "Бруклин Нетс";
                    button4.Text = "Маями Хийт"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С каква националност е Диего Марадона?")
            {

                player.Play();

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct;
                frm51.Show();
                Hide();

            }
            if (button5.Text == "Кой отбор от НБА има най-много поредни победи?")
            {
                player1.Play();   //Верен отговор

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct + 1;
                frm51.Show();
                Hide();
            }
            if (button5.Text == "Най-много победи в редовен сезон има?")
            {

                player1.Play();   //Верен отговор

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct + 1;
                frm51.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С каква националност е Диего Марадона?")
            {

                player.Play();

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct;
                frm51.Show();
                Hide();

            }
            if (button5.Text == "Кой отбор от НБА има най-много поредни победи?")
            {
                player1.Play();  

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct;
                frm51.Show();
                Hide();
            }
            if (button5.Text == "Най-много победи в редовен сезон има?")
            {

                player.Play();

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct;
                frm51.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С каква националност е Диего Марадона?")
            {

                player.Play();

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct;
                frm51.Show();
                Hide();

            }
            if (button5.Text == "Кой отбор от НБА има най-много поредни победи?")
            {
                player.Play(); 

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct;
                frm51.Show();
                Hide();
            }
            if (button5.Text == "Най-много победи в редовен сезон има?")
            {

                player.Play();

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct;
                frm51.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "С каква националност е Диего Марадона?")
            {

                player1.Play();   //Верен отговор

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct + 1;
                frm51.Show();
                Hide();

            }
            if (button5.Text == "Кой отбор от НБА има най-много поредни победи?")
            {
                player.Play(); 

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct;
                frm51.Show();
                Hide();
            }
            if (button5.Text == "Най-много победи в редовен сезон има?")
            {

                player.Play();

                
                frm51 = new Form51();
                frm51.passTime1 = Time1;
                frm51.passTime2 = Time2;
                frm51.passTime3 = Time3;
                frm51.passTime4 = Time4;
                frm51.passTime5 = Time5;
                frm51.passTime6 = a;
                frm51.passCorrect = Correct;
                frm51.Show();
                Hide();
            }
        }
    }
}
