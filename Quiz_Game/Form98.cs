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
    public partial class Form98 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form99 frm99;
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
        public Form98()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form98_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой е основал славянската писменост?";
                button1.Text = "Кирил и Методий"; // Верният отговор
                button2.Text = "Борис"; 
                button3.Text = "Аспарух";
                button4.Text = "Теодосий";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой княз покръства българите?";
                button1.Text = "Борис"; // Верният Отговор
                button2.Text = "Крум";
                button3.Text = "Кубрат"; 
                button4.Text = "Омуртаг";
            }
            if (q1 == 3)
            {

                button5.Text = "В кой век попада 1878год.?";
                button1.Text = "18";
                button2.Text = "20";
                button3.Text = "19"; // Верният отговор
                button4.Text = "4"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е основал славянската писменост?")
            {
                player1.Play(); // Верният отговор


                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct + 1;
                frm99.Show();
                Hide();

            }
            if (button5.Text == "Кой княз покръства българите?")
            {
                player1.Play(); // Верният отговор

                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct + 1;
                frm99.Show();
                Hide();
            }
            if (button5.Text == "В кой век попада 1878год.?")
            {
                player.Play();

                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct;
                frm99.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е основал славянската писменост?")
            {
                player.Play();


                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct;
                frm99.Show();
                Hide();

            }
            if (button5.Text == "Кой княз покръства българите?")
            {
                player.Play();

                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct;
                frm99.Show();
                Hide();
            }
            if (button5.Text == "В кой век попада 1878год.?")
            {
                player.Play();

                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct;
                frm99.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е основал славянската писменост?")
            {
                player.Play();


                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct;
                frm99.Show();
                Hide();

            }
            if (button5.Text == "Кой княз покръства българите?")
            {
                player.Play();

                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct;
                frm99.Show();
                Hide();
            }
            if (button5.Text == "В кой век попада 1878год.?")
            {
                player1.Play(); // Верният отговор

                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct + 1;
                frm99.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой е основал славянската писменост?")
            {
                player.Play();


                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct;
                frm99.Show();
                Hide();

            }
            if (button5.Text == "Кой княз покръства българите?")
            {
                player.Play();

                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct;
                frm99.Show();
                Hide();
            }
            if (button5.Text == "В кой век попада 1878год.?")
            {
                player.Play();

                frm99 = new Form99();
                frm99.passTime1 = Time1;
                frm99.passTime2 = Time2;
                frm99.passTime3 = Time3;
                frm99.passTime4 = a;
                frm99.passCorrect = Correct;
                frm99.Show();
                Hide();
            }
        }
    }
}
