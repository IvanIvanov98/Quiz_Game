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
    public partial class Form89 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form90 frm90;
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
        public Form89()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form89_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Костите на лицевия дял на чов. череп са?";
                button1.Text = "74";
                button2.Text = "66"; // Верният Отговор
                button3.Text = "45";
                button4.Text = "51";
            }
            if (q1 == 2)
            {
                button5.Text = "Колко са вътрешните очни мускули при човека?";
                button1.Text = "15";
                button2.Text = "16";
                button3.Text = "3";
                button4.Text = "8";  // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Какъв белтък е хемоглобина?";
                button1.Text = "Първичен";
                button2.Text = "Вторичен";
                button3.Text = "Третичен";
                button4.Text = "Четвъртичен"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Костите на лицевия дял на чов. череп са?")
            {
                player.Play();


                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct;
                frm90.Show();
                Hide();

            }
            if (button5.Text == "Колко са вътрешните очни мускули при човека?")
            {
                player.Play();

                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct;
                frm90.Show();
                Hide();
            }
            if (button5.Text == "Какъв белтък е хемоглобина?")
            {
                player.Play();

                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct;
                frm90.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Костите на лицевия дял на чов. череп са?")
            {
                player1.Play();


                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct  + 1;
                frm90.Show();
                Hide();

            }
            if (button5.Text == "Колко са вътрешните очни мускули при човека?")
            {
                player.Play();

                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct;
                frm90.Show();
                Hide();
            }
            if (button5.Text == "Какъв белтък е хемоглобина?")
            {
                player.Play();

                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct;
                frm90.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Костите на лицевия дял на чов. череп са?")
            {
                player.Play();


                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct;
                frm90.Show();
                Hide();

            }
            if (button5.Text == "Колко са вътрешните очни мускули при човека?")
            {
                player.Play();

                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct;
                frm90.Show();
                Hide();
            }
            if (button5.Text == "Какъв белтък е хемоглобина?")
            {
                player.Play();

                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct;
                frm90.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Костите на лицевия дял на чов. череп са?")
            {
                player.Play();


                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct;
                frm90.Show();
                Hide();

            }
            if (button5.Text == "Колко са вътрешните очни мускули при човека?")
            {
                player1.Play();

                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct  + 1 ;
                frm90.Show();
                Hide();
            }
            if (button5.Text == "Какъв белтък е хемоглобина?")
            {
                player1.Play();

                frm90 = new Form90();
                frm90.passTime1 = Time1;
                frm90.passTime2 = Time2;
                frm90.passTime3 = Time3;
                frm90.passTime4 = Time4;
                frm90.passTime5 = a;
                frm90.passCorrect = Correct  + 1;
                frm90.Show();
                Hide();
            }
        }
    }
}
