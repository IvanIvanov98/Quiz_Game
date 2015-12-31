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
    public partial class Form142 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form143 frm143;
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
        public Form142()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form142_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Жанр, в който се изопачават характерни черти на хора и предмети е?";
                button1.Text = "Сатира";
                button2.Text = "Карикатура";  // Верният отговор
                button3.Text = "Епиграма"; 
                button4.Text = "Комедия";
            }
            if (q1 == 2)
            {
                button5.Text = "Изобразително изкуство включващо елементи от архитектурата е?";
                button1.Text = "Живописта";  
                button2.Text = "Илюстрацията";
                button3.Text = "Анимацията";
                button4.Text = "Сценографията"; // Верният Отговор
            }
            if (q1 == 3)
            {

                button5.Text = "Кой е художникът, нарисувал „Звездна нощ“?";
                button1.Text = "Винсент ван Гог";
                button2.Text = "Ботичели"; // Верният отговор
                button3.Text = "Густав Климт";
                button4.Text = "Клод Моне";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Жанр, в който се изопачават характерни черти на хора и предмети е?")
            {
                player.Play();


                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct;
                frm143.Show();
                Hide();

            }
            if (button5.Text == "Изобразително изкуство включващо елементи от архитектурата е?")
            {
                player.Play();

                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct;
                frm143.Show();
                Hide();
            }
            if (button5.Text == "Кой е художникът нарисувал „Звездна нощ“?")
            {
                player.Play();

                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct;
                frm143.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Жанр, в който се изопачават характерни черти на хора и предмети е?")
            {
                player1.Play();


                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct + 1;
                frm143.Show();
                Hide();

            }
            if (button5.Text == "Изобразително изкуство включващо елементи от архитектурата е?")
            {
                player.Play();

                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct;
                frm143.Show();
                Hide();
            }
            if (button5.Text == "Кой е художникът нарисувал „Звездна нощ“?")
            {
                player1.Play();

                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct + 1;
                frm143.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Жанр, в който се изопачават характерни черти на хора и предмети е?")
            {
                player.Play();


                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct;
                frm143.Show();
                Hide();

            }
            if (button5.Text == "Изобразително изкуство включващо елементи от архитектурата е?")
            {
                player.Play();

                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct;
                frm143.Show();
                Hide();
            }
            if (button5.Text == "Кой е художникът нарисувал „Звездна нощ“?")
            {
                player.Play();

                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct;
                frm143.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Жанр, в който се изопачават характерни черти на хора и предмети е?")
            {
                player.Play();


                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct;
                frm143.Show();
                Hide();

            }
            if (button5.Text == "Изобразително изкуство включващо елементи от архитектурата е?")
            {
                player1.Play();

                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct + 1;
                frm143.Show();
                Hide();
            }
            if (button5.Text == "Кой е художникът нарисувал „Звездна нощ“?")
            {
                player.Play();

                frm143 = new Form143();
                frm143.passTime1 = Time1;
                frm143.passTime2 = Time2;
                frm143.passTime3 = Time3;
                frm143.passTime4 = Time4;
                frm143.passTime5 = Time5;
                frm143.passTime6 = Time6;
                frm143.passTime7 = Time7;
                frm143.passTime8 = a;
                frm143.passCorrect = Correct;
                frm143.Show();
                Hide();
            }
        }
    }
}
