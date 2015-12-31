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
    public partial class Form52 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form53 frm53;
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
        private int Time7;
        public int passTime7
        {
            get
            {
                return Time7;
            }
            set
            {
                Time7 = value;
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
        public Form52()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form52_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Рони О'Съливан е професионален състезател по?";
                    button1.Text = "Тенис на маса";
                    button2.Text = "Хокей на лед";
                    button3.Text = "Снукър"; // Верният Отговор
                    button4.Text = "Лека атлетика"; 
                }
                if (q1 == 2)
                {
                    button5.Text = "Кой дисциплина не е включен в триатлона?";
                    button1.Text = "бягане"; // Верният Отговор
                    button2.Text = "плуване";
                    button3.Text = "колоездене";
                    button4.Text = "висок скок";
                }
                if (q1 == 3)
                {
                    button5.Text = "Спортист №1 на България за 2003г. е обявен?";
                    button1.Text = "Йордан Йовчев"; // Верният отговор
                    button2.Text = "Армен Назарян";
                    button3.Text = "Милен Добрев";
                    button4.Text = "Ваня Стамболова"; 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Рони О'Съливан е професионален състезател по?")
            {

                player.Play();

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct;
                frm53.Show();
                Hide();

            }
            if (button5.Text == "Кой дисциплина не е включен в триатлона?")
            {
                player1.Play();   //Верен отговор

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct + 1;
                frm53.Show();
                Hide();
            }
            if (button5.Text == "Спортист №1 на България за 2003г. е обявен?")
            {

                player1.Play();   //Верен отговор

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct + 1;
                frm53.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Рони О'Съливан е професионален състезател по?")
            {

                player.Play();

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct;
                frm53.Show();
                Hide();

            }
            if (button5.Text == "Кой дисциплина не е включен в триатлона?")
            {
                player.Play();   

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct;
                frm53.Show();
                Hide();
            }
            if (button5.Text == "Спортист №1 на България за 2003г. е обявен?")
            {

                player.Play();

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct;
                frm53.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Рони О'Съливан е професионален състезател по?")
            {

                player1.Play();   //Верен отговор

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct + 1;
                frm53.Show();
                Hide();

            }
            if (button5.Text == "Кой дисциплина не е включен в триатлона?")
            {
                player.Play();  

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct;
                frm53.Show();
                Hide();
            }
            if (button5.Text == "Спортист №1 на България за 2003г. е обявен?")
            {

                player.Play();

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct;
                frm53.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Рони О'Съливан е професионален състезател по?")
            {

                player.Play();

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct;
                frm53.Show();
                Hide();

            }
            if (button5.Text == "Кой дисциплина не е включен в триатлона?")
            {
                player.Play();   

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct;
                frm53.Show();
                Hide();
            }
            if (button5.Text == "Спортист №1 на България за 2003г. е обявен?")
            {

                player.Play();

                
                frm53 = new Form53();
                frm53.passTime1 = Time1;
                frm53.passTime2 = Time2;
                frm53.passTime3 = Time3;
                frm53.passTime4 = Time4;
                frm53.passTime5 = Time5;
                frm53.passTime6 = Time6;
                frm53.passTime7 = Time7;
                frm53.passTime8 = a;
                frm53.passCorrect = Correct;
                frm53.Show();
                Hide();
            }
        }
    }
}
