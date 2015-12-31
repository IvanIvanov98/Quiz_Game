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
    public partial class Form82 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form83 frm83;
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
        public Form82()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form82_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Взаимоотношенията м/у организмите е?";
                button1.Text = "Антропогенен фактор";
                button2.Text = "Абиотичен фактор";
                button3.Text = "Биотичен фактор"; // Верният Отговор
                button4.Text = "Биогеннен фактор"; 
            }
            if (q1 == 2)
            {
                button5.Text = "Общото за про- и еу- кариотните клетки е?";
                button1.Text = "Едноплаз.мрежа";
                button2.Text = "Апарат на Голджи";
                button3.Text = "Цитоплазмата"; // Верният Отговор
                button4.Text = "Ядрото";
            }
            if (q1 == 3)
            {

                button5.Text = "Кое е компонент на микросистемата?";
                button1.Text = "Надмолекулен комплекс"; // Верният отговор
                button2.Text = "Организъм";
                button3.Text = "Популация";
                button4.Text = "Екосистема";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Взаимоотношенията м/у организмите е?")
            {
                player.Play();


                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a; 
                frm83.passCorrect = Correct;    
                frm83.Show();
                Hide();

            }
            if (button5.Text == "Общото за про- и еу- кариотните клетки е?")
            {
                player.Play();

                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct;
                frm83.Show();
                Hide();
            }
            if (button5.Text == "Кое е компонент на микросистемата?")
            {
                player1.Play();

                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct + 1;
                frm83.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Взаимоотношенията м/у организмите е?")
            {
                player.Play();


                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct;
                frm83.Show();
                Hide();

            }
            if (button5.Text == "Общото за про- и еу- кариотните клетки е?")
            {
                player.Play();

                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct;
                frm83.Show();
                Hide();
            }
            if (button5.Text == "Кое е компонент на микросистемата?")
            {
                player.Play();

                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct;
                frm83.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Взаимоотношенията м/у организмите е?")
            {
                player1.Play();


                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct + 1;
                frm83.Show();
                Hide();

            }
            if (button5.Text == "Общото за про- и еу- кариотните клетки е?")
            {
                player1.Play();

                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct + 1;
                frm83.Show();
                Hide();
            }
            if (button5.Text == "Кое е компонент на микросистемата?")
            {
                player.Play();

                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct;
                frm83.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Взаимоотношенията м/у организмите е?")
            {
                player.Play();


                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct;
                frm83.Show();
                Hide();

            }
            if (button5.Text == "Общото за про- и еу- кариотните клетки е?")
            {
                player.Play();


                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct;
                frm83.Show();
                Hide();
            }
            if (button5.Text == "Кое е компонент на микросистемата?")
            {
                player.Play();

                frm83 = new Form83();
                frm83.passTime1 = Time1;
                frm83.passTime2 = Time2;
                frm83.passTime3 = Time3;
                frm83.passTime4 = Time4;
                frm83.passTime5 = Time5;
                frm83.passTime6 = Time6;
                frm83.passTime7 = Time7;
                frm83.passTime8 = a;
                frm83.passCorrect = Correct;
                frm83.Show();
                Hide();
            }
        }
    }
}
