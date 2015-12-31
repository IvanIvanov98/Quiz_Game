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
    public partial class Form71 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form72 frm72;
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
        public Form71()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form71_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Според Дарвин човек произлиза от?";
                button1.Text = "Рибите"; 
                button2.Text = "Маймуните"; // Верният Отговор
                button3.Text = "Драконите";
                button4.Text = "Птиците";
            }
            if (q1 == 2)
            {
                button5.Text = "Най - малката птица на света е?";
                button1.Text = "Орел"; 
                button2.Text = "Ястреб";
                button3.Text = "Лебед";
                button4.Text = "Колибри"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "От какво е съставен главно пъпеша?";
                button1.Text = "Мазнини"; 
                button2.Text = "Въглехидрати";
                button3.Text = "Аминокиселини";
                button4.Text = "Вода"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Според Дарвин човек произлиза от?")
            {
                player.Play();


                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct;
                frm72.Show();
                Hide();

            }
            if (button5.Text == "Най - малката птица на света е?")
            {
                player.Play();
                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct;
                frm72.Show();
                Hide();
            }
            if (button5.Text == "От какво е съставен главно пъпеша?")
            {
                player.Play();

                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct;
                frm72.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Според Дарвин човек произлиза от?")
            {
                player1.Play(); // Верният Отговор


                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct + 1;
                frm72.Show();
                Hide();

            }
            if (button5.Text == "Най - малката птица на света е?")
            {
                player.Play();
                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct;
                frm72.Show();
                Hide();
            }
            if (button5.Text == "От какво е съставен главно пъпеша?")
            {
                player.Play();

                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct;
                frm72.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Според Дарвин човек произлиза от?")
            {
                player.Play();


                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct;
                frm72.Show();
                Hide();

            }
            if (button5.Text == "Най - малката птица на света е?")
            {
                player.Play();
                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct;
                frm72.Show();
                Hide();
            }
            if (button5.Text == "От какво е съставен главно пъпеша?")
            {
                player.Play();

                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct;
                frm72.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Според Дарвин човек произлиза от?")
            {
                player.Play();


                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct;
                frm72.Show();
                Hide();

            }
            if (button5.Text == "Най - малката птица на света е?")
            {
                player1.Play(); // Верният Отговор
                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct + 1;
                frm72.Show();
                Hide();
            }
            if (button5.Text == "От какво е съставен главно пъпеша?")
            {
                player1.Play(); // Верният Отговор

                frm72 = new Form72();
                frm72.passTime1 = Time1;
                frm72.passTime2 = Time2;
                frm72.passTime3 = Time3;
                frm72.passTime4 = Time4;
                frm72.passTime5 = Time5;
                frm72.passTime6 = Time6;
                frm72.passTime7 = a;
                frm72.passCorrect = Correct + 1;
                frm72.Show();
                Hide();
            }
        }
    }
}
