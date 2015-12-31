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

    public partial class Form137 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form138 frm138;
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
        public Form137()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form137_Load(object sender, EventArgs e)
        {

            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кои се наричат „крилати изрази“?";
                button1.Text = "Метафори";
                button2.Text = "Афоризми"; // Верният отговор
                button3.Text = "Народни песни";   
                button4.Text = "Басни";
            }
            if (q1 == 2)
            {
                button5.Text = "Най - влиятелни за формиране на дадена култура са?";
                button1.Text = "Приказките"; 
                button2.Text = "Романите";
                button3.Text = "Каноните";   // Верният Отговор
                button4.Text = "Басните";
            }
            if (q1 == 3)
            {
                button5.Text = "Кой е един от основните литературни рода?";
                button1.Text = "Епос";  // Верният Отговор
                button2.Text = "Комедия"; 
                button3.Text = "Трагедия";
                button4.Text = "Белетристика";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои се наричат „крилати изрази“?")
            {
                player.Play();


                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct;
                frm138.Show();
                Hide();

            }
            if (button5.Text == "Най - влиятелни за формиране на дадена култура са?")
            {
                player.Play();

                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct;
                frm138.Show();
                Hide();
            }
            if (button5.Text == "Кой е един от основните литературни рода?")
            {
                player1.Play();

                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct + 1;
                frm138.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои се наричат „крилати изрази“?")
            {
                player1.Play();


                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct + 1;
                frm138.Show();
                Hide();

            }
            if (button5.Text == "Най - влиятелни за формиране на дадена култура са?")
            {
                player.Play();

                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct;
                frm138.Show();
                Hide();
            }
            if (button5.Text == "Кой е един от основните литературни рода?")
            {
                player.Play();

                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct;
                frm138.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои се наричат „крилати изрази“?")
            {
                player.Play();


                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct;
                frm138.Show();
                Hide();

            }
            if (button5.Text == "Най - влиятелни за формиране на дадена култура са?")
            {
                player1.Play();

                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct + 1;
                frm138.Show();
                Hide();
            }
            if (button5.Text == "Кой е един от основните литературни рода?")
            {
                player.Play();

                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct;
                frm138.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кои се наричат „крилати изрази“?")
            {
                player.Play();


                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct;
                frm138.Show();
                Hide();

            }
            if (button5.Text == "Най - влиятелни за формиране на дадена култура са?")
            {
                player.Play();

                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct;
                frm138.Show();
                Hide();
            }
            if (button5.Text == "Кой е един от основните литературни рода?")
            {
                player.Play();

                frm138 = new Form138();
                frm138.passTime1 = Time1;
                frm138.passTime2 = Time2;
                frm138.passTime3 = a;
                frm138.passCorrect = Correct;
                frm138.Show();
                Hide();
            }
        }
    }
}
