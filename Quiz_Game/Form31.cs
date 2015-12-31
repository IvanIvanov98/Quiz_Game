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
    public partial class Form31 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form32 frm32;
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
        public Form31()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form31_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Столица на държава с най-много милиярдери?";
                    button1.Text = "Вашингтън";
                    button2.Text = "Пекин"; 
                    button3.Text = "Токио";
                    button4.Text = "Москва"; // Верният Отговор
                }
                if (q1 == 2)
                {
                    button5.Text = "Коя страна е полупрезидентска република?";
                    button1.Text = "Шри Ланка"; // Верният Отговор
                    button2.Text = "Габон";
                    button3.Text = "Еквадор";
                    button4.Text = "Уругвай"; 
                }
                if (q1 == 3)
                {
                    button5.Text = "Най-бедна държава в Южна Америка?";
                    button1.Text = "Суринам";
                    button2.Text = "Гаяна";
                    button3.Text = "Гиана";
                    button4.Text = "Боливия";  // Верният отговор
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столица на държава с най-много милиярдери?")
            {
                player1.Play();   //Верен отговор
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct + 1;
                frm32.Show();
                Hide();

            }
            if (button5.Text == "Коя страна е полупрезидентска република?")
            {
                player.Play();
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct;
                frm32.Show();
                Hide();
            }
            if (button5.Text == "Най-бедна държава в Южна Америка?")
            {
                player.Play();
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct;
                frm32.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столица на държава с най-много милиярдери?")
            {
                player.Play();
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct;
                frm32.Show();
                Hide();

            }
            if (button5.Text == "Коя страна е полупрезидентска република?")
            {
                player.Play();
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct;
                frm32.Show();
                Hide();
            }
            if (button5.Text == "Най-бедна държава в Южна Америка?")
            {
                player.Play();
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct;
                frm32.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столица на държава с най-много милиярдери?")
            {
                player.Play();
                
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct;
                frm32.Show();
                Hide();

            }
            if (button5.Text == "Коя страна е полупрезидентска република?")
            {
                player.Play();
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct;
                frm32.Show();
                Hide();
            }
            if (button5.Text == "Най-бедна държава в Южна Америка?")
            {
                player.Play();
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct;
                frm32.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Столица на държава с най-много милиярдери?")
            {
                player1.Play();   //Верен отговор
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct + 1;
                frm32.Show();
                Hide();

            }
            if (button5.Text == "Коя страна е полупрезидентска република?")
            {
                player.Play();
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct;
                frm32.Show();
                Hide();
            }
            if (button5.Text == "Най-бедна държава в Южна Америка?")
            {
                player1.Play();   //Верен отговор
                
                frm32 = new Form32();
                frm32.passTime1 = Time1;
                frm32.passTime2 = Time2;
                frm32.passTime3 = Time3;
                frm32.passTime4 = Time4;
                frm32.passTime5 = Time5;
                frm32.passTime6 = Time6;
                frm32.passTime7 = a;
                frm32.passCorrect = Correct + 1;
                frm32.Show();
                Hide();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
