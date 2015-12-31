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
    public partial class Form122 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form123 frm123;
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
        public Form122()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form122_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой от изброените инструментите е клавишен?";
                button1.Text = "Орган"; // Верният отговор
                button2.Text = "Китара";
                button3.Text = "Лира";
                button4.Text = "Тарамбука";
            }
            if (q1 == 2)
            {
                button5.Text = "Кой от изброените инструментите е ударен?";
                button1.Text = "Йоника";
                button2.Text = "Тъпан"; // Верният Отговор
                button3.Text = "Туба";
                button4.Text = "Гайда";
            }
            if (q1 == 3)
            {

                button5.Text = "Как се нарича създателят на инструментална музика?";
                button1.Text = "Певец";
                button2.Text = "Композитор"; // Верният отговор
                button3.Text = "Диригент";
                button4.Text = "Продуцент";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от изброените инструментите е клавишен?")
            {
                player1.Play();


                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct + 1;
                frm123.Show();
                Hide();

            }
            if (button5.Text == "Кой от изброените инструментите е ударен?")
            {
                player.Play();

                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct;
                frm123.Show();
                Hide();
            }
            if (button5.Text == "Как се нарича създателят на инструментална музика?")
            {
                player.Play();

                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct;
                frm123.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от изброените инструментите е клавишен?")
            {
                player.Play();


                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct;
                frm123.Show();
                Hide();

            }
            if (button5.Text == "Кой от изброените инструментите е ударен?")
            {
                player1.Play();

                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct + 1;
                frm123.Show();
                Hide();
            }
            if (button5.Text == "Как се нарича създателят на инструментална музика?")
            {
                player1.Play();

                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct + 1;
                frm123.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от изброените инструментите е клавишен?")
            {
                player.Play();


                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct;
                frm123.Show();
                Hide();

            }
            if (button5.Text == "Кой от изброените инструментите е ударен?")
            {
                player.Play();

                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct;
                frm123.Show();
                Hide();
            }
            if (button5.Text == "Как се нарича създателят на инструментална музика?")
            {
                player.Play();

                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct;
                frm123.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от изброените инструментите е клавишен?")
            {
                player.Play();


                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct;
                frm123.Show();
                Hide();

            }
            if (button5.Text == "Кой от изброените инструментите е ударен?")
            {
                player.Play();

                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct;
                frm123.Show();
                Hide();
            }
            if (button5.Text == "Как се нарича създателят на инструментална музика?")
            {
                player.Play();

                frm123 = new Form123();
                frm123.passTime1 = Time1;
                frm123.passTime2 = Time2;
                frm123.passTime3 = Time3;
                frm123.passTime4 = Time4;
                frm123.passTime5 = Time5;
                frm123.passTime6 = Time6;
                frm123.passTime7 = Time7;
                frm123.passTime8 = a;
                frm123.passCorrect = Correct;
                frm123.Show();
                Hide();
            }
        }
    }
}
