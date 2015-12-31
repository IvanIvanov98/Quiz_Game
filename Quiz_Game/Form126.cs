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
    public partial class Form126 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form127 frm127;
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
        public Form126()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form126_Load(object sender, EventArgs e)
        {

            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "При кой владетел бъл. войници биват ослепени?";
                button1.Text = "Самуил"; // Верният отговор
                button2.Text = "Петър I";
                button3.Text = "Кубрат";
                button4.Text = "Симеон";
            }
            if (q1 == 2)
            {
                button5.Text = "Страна която не е била част от Антантата?";
                button1.Text = "Сърбия";
                button2.Text = "Италия";
                button3.Text = "Англия";
                button4.Text = "България";  // Верният Отговор
            }
            if (q1 == 3)
            {
                button5.Text = "След ПСВ Герм. дава Елзас на?";
                button1.Text = "Полша";
                button2.Text = "Чехословакия"; 
                button3.Text = "Дания";
                button4.Text = "Франция"; // Верният отговор
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "При кой владетел бъл. войници биват ослепени?")
            {
                player1.Play();


                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct + 1;
                frm127.Show();
                Hide();

            }
            if (button5.Text == "Страна която не е била част от Антантата?")
            {
                player.Play();

                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct;
                frm127.Show();
                Hide();
            }
            if (button5.Text == "След ПСВ Герм. дава Елзас на?")
            {
                player.Play();

                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct;
                frm127.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "При кой владетел бъл. войници биват ослепени?")
            {
                player.Play();


                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct;
                frm127.Show();
                Hide();

            }
            if (button5.Text == "Страна която не е била част от Антантата?")
            {
                player.Play();

                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct;
                frm127.Show();
                Hide();
            }
            if (button5.Text == "След ПСВ Герм. дава Елзас на?")
            {
                player.Play();

                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct;
                frm127.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "При кой владетел бъл. войници биват ослепени?")
            {
                player.Play();


                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct;
                frm127.Show();
                Hide();

            }
            if (button5.Text == "Страна която не е била част от Антантата?")
            {
                player.Play();

                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct;
                frm127.Show();
                Hide();
            }
            if (button5.Text == "След ПСВ Герм. дава Елзас на?")
            {
                player.Play();

                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct;
                frm127.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "При кой владетел бъл. войници биват ослепени?")
            {
                player.Play();


                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct;
                frm127.Show();
                Hide();

            }
            if (button5.Text == "Страна която не е била част от Антантата?")
            {
                player1.Play();

                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct + 1;
                frm127.Show();
                Hide();
            }
            if (button5.Text == "След ПСВ Герм. дава Елзас на?")
            {
                player1.Play();

                frm127 = new Form127();
                frm127.passTime1 = Time1;
                frm127.passTime2 = a;
                frm127.passCorrect = Correct + 1;
                frm127.Show();
                Hide();
            }
        }
    }
}
