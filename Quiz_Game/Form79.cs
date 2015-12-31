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
    public partial class Form79 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form80 frm80;
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
        public Form79()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form79_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Кл.стена при раст. е изградена главно от?";
                button1.Text = "Скорбяла";
                button2.Text = "Кликоген";
                button3.Text = "Целуоза";  // Верният Отговор
                button4.Text = "Хитин";
            }
            if (q1 == 2)
            {
                button5.Text = "Немембранни клетъчни органели са?";
                button1.Text = "Рибозомите"; // Верният Отговор
                button2.Text = "Лизозомите";
                button3.Text = "Пластидите"; 
                button4.Text = "Митохондрите";
            }
            if (q1 == 3)
            {

                button5.Text = "За разлика от митохондрите хлороплас. имат?";
                button1.Text = "Ензими"; 
                button2.Text = "Рибозоми";
                button3.Text = "Пластиди"; // Верният отговор
                button4.Text = "ДНК";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кл.стена при раст. е изградена главно от?")
            {
                player.Play();


                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct;
                frm80.Show();
                Hide();

            }
            if (button5.Text == "Немембранни клетъчни органели са?")
            {
                player1.Play();

                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct + 1;
                frm80.Show();
                Hide();
            }
            if (button5.Text == "За разлика от митохондрите хлороплас. имат?")
            {
                player.Play();

                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct;
                frm80.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кл.стена при раст. е изградена главно от?")
            {
                player.Play();


                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct;
                frm80.Show();
                Hide();

            }
            if (button5.Text == "Немембранни клетъчни органели са?")
            {
                player.Play();

                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct;
                frm80.Show();
                Hide();
            }
            if (button5.Text == "За разлика от митохондрите хлороплас. имат?")
            {
                player.Play();

                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct;
                frm80.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кл.стена при раст. е изградена главно от?")
            {
                player1.Play();


                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct + 1;
                frm80.Show();
                Hide();

            }
            if (button5.Text == "Немембранни клетъчни органели са?")
            {
                player.Play();

                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct;
                frm80.Show();
                Hide();
            }
            if (button5.Text == "За разлика от митохондрите хлороплас. имат?")
            {
                player1.Play();

                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct + 1;
                frm80.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кл.стена при раст. е изградена главно от?")
            {
                player.Play();


                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct;
                frm80.Show();
                Hide();

            }
            if (button5.Text == "Немембранни клетъчни органели са?")
            {
                player.Play();

                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct;
                frm80.Show();
                Hide();
            }
            if (button5.Text == "За разлика от митохондрите хлороплас. имат?")
            {
                player.Play();

                frm80 = new Form80();
                frm80.passTime1 = Time1;
                frm80.passTime2 = Time2;
                frm80.passTime3 = Time3;
                frm80.passTime4 = Time4;
                frm80.passTime5 = a;
                frm80.passCorrect = Correct;
                frm80.Show();
                Hide();
            }
        }
    }
}
