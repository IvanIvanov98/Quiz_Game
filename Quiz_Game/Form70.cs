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
    public partial class Form70 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form71 frm71;
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
        public Form70()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form70_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Какво осигуряват въглехидратите?";
                button1.Text = "Енергия"; // Верният Отговор
                button2.Text = "Имунна защита";
                button3.Text = "Пари";
                button4.Text = "Соли";
            }
            if (q1 == 2)
            {
                button5.Text = "Процесът фотосинтеза е неусъществим без?";
                button1.Text = "Слънце"; // Верният Отговор
                button2.Text = "Огън";
                button3.Text = "Тъмнина"; 
                button4.Text = "Лава";
            }
            if (q1 == 3)
            {
                button5.Text = "Най - близко до човека по разум са?";
                button1.Text = "Делфините"; // Верният отговор
                button2.Text = "Кучетата"; 
                button3.Text = "Пеперудите";
                button4.Text = "Змиите";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво осигуряват въглехидратите?")
            {
                player1.Play(); // Верният Отговор


                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct + 1;
                frm71.Show();
                Hide();

            }
            if (button5.Text == "Процесът фотосинтеза е неусъществим без?")
            {
                player1.Play(); // Верният Отговор

                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct + 1;
                frm71.Show();
                Hide();
            }
            if (button5.Text == "Най - близко до човека по разум са?")
            {
                player1.Play(); // Верният Отговор

                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct + 1;
                frm71.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво осигуряват въглехидратите?")
            {
                player.Play();


                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct;
                frm71.Show();
                Hide();

            }
            if (button5.Text == "Процесът фотосинтеза е неусъществим без?")
            {
                player.Play();

                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct;
                frm71.Show();
                Hide();
            }
            if (button5.Text == "Най - близко до човека по разум са?")
            {
                player.Play();

                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct;
                frm71.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво осигуряват въглехидратите?")
            {
                player.Play();


                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct;
                frm71.Show();
                Hide();

            }
            if (button5.Text == "Процесът фотосинтеза е неусъществим без?")
            {
                player.Play();

                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct;
                frm71.Show();
                Hide();
            }
            if (button5.Text == "Най - близко до човека по разум са?")
            {
                player.Play();

                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct;
                frm71.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Какво осигуряват въглехидратите?")
            {
                player.Play();


                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct;
                frm71.Show();
                Hide();

            }
            if (button5.Text == "Процесът фотосинтеза е неусъществим без?")
            {
                player.Play();

                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct;
                frm71.Show();
                Hide();
            }
            if (button5.Text == "Най - близко до човека по разум са?")
            {
                player.Play();

                frm71 = new Form71();
                frm71.passTime1 = Time1;
                frm71.passTime2 = Time2;
                frm71.passTime3 = Time3;
                frm71.passTime4 = Time4;
                frm71.passTime5 = Time5;
                frm71.passTime6 = a;
                frm71.passCorrect = Correct;
                frm71.Show();
                Hide();
            }
        }
    }
}
