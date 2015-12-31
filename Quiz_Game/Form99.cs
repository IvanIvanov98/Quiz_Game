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
    public partial class Form99 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form100 frm100;
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
        public Form99()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form99_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Уинстън Чърчил е управлявал коя държава?";
                button1.Text = "Англия"; // Верният отговор
                button2.Text = "Русия";
                button3.Text = "България";
                button4.Text = "Германия";
            }
            if (q1 == 2)
            {
                button5.Text = "Славяните са какво?";
                button1.Text = "Комитет";
                button2.Text = "Цивилизация";
                button3.Text = "Братя";
                button4.Text = "Народ";  // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Коя държава спомага за освобождението на България от турско робство?";
                button1.Text = "Америка";
                button2.Text = "Германия";
                button3.Text = "Русия"; // Верният отговор
                button4.Text = "Сърбия";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Уинстън Чърчил е управлявал коя държава?")
            {
                player1.Play(); // Верният отговор


                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct + 1;
                frm100.Show();
                Hide();

            }
            if (button5.Text == "Славяните са какво?")
            {
                player.Play();

                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct;
                frm100.Show();
                Hide();
            }
            if (button5.Text == "Коя държава спомага за освобождението на България от турско робство?")
            {
                player.Play();

                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct;
                frm100.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Уинстън Чърчил е управлявал коя държава?")
            {
                player.Play();


                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct;
                frm100.Show();
                Hide();

            }
            if (button5.Text == "Славяните са какво?")
            {
                player.Play();

                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct;
                frm100.Show();
                Hide();
            }
            if (button5.Text == "Коя държава спомага за освобождението на България от турско робство?")
            {
                player.Play();

                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct;
                frm100.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Уинстън Чърчил е управлявал коя държава?")
            {
                player.Play();


                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct;
                frm100.Show();
                Hide();

            }
            if (button5.Text == "Славяните са какво?")
            {
                player.Play();

                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct;
                frm100.Show();
                Hide();
            }
            if (button5.Text == "Коя държава спомага за освобождението на България от турско робство?")
            {
                player1.Play(); // Верният отговор

                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct + 1;
                frm100.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Уинстън Чърчил е управлявал коя държава?")
            {
                player.Play();


                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct;
                frm100.Show();
                Hide();

            }
            if (button5.Text == "Славяните са какво?")
            {
                player1.Play(); // Верният отговор

                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct + 1;
                frm100.Show();
                Hide();
            }
            if (button5.Text == "Коя държава спомага за освобождението на България от турско робство?")
            {
                player.Play();

                frm100 = new Form100();
                frm100.passTime1 = Time1;
                frm100.passTime2 = Time2;
                frm100.passTime3 = Time3;
                frm100.passTime4 = Time4;
                frm100.passTime5 = a;
                frm100.passCorrect = Correct;
                frm100.Show();
                Hide();
            }
        }
    }
}
