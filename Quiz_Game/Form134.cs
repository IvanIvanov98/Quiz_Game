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
    public partial class Form134 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private FormResult frmResult;
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
        private int Time8;
        public int passTime8
        {
            get
            {
                return Time8;
            }
            set
            {
                Time8 = value;
            }
        }
        private int Time9;
        public int passTime9
        {
            get
            {
                return Time9;
            }
            set
            {
                Time9 = value;
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
        public Form134()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form134_Load(object sender, EventArgs e)
        {

            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {

                button5.Text = "Кой от книжовниците НЕ е от времето на „Златния век”?";
                button1.Text = "Черноризец Храбър"; 
                button2.Text = "Климент Охридски";
                button3.Text = "Евтимий Търновски"; // Верният отговор
                button4.Text = "Константин Преславски";
            }
            if (q1 == 2)
            {
                button5.Text = "Цар Иван Александър се прославил като?";
                button1.Text = "смел пълководец";
                button2.Text = "изкусен зограф"; 
                button3.Text = "покровител на книжнината"; // Верният Отговор
                button4.Text = "строг законодател";
            }
            if (q1 == 3)
            {

                button5.Text = "За „Баща на историята“ се смята древногръцкият учен?";
                button1.Text = "Сократ"; // Верният отговор
                button2.Text = "Херодот";
                button3.Text = "Тукидид";
                button4.Text = "Питагор"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от книжовниците НЕ е от времето на „Златния век”?")
            {
                player.Play();


                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct;
                frmResult.Show();
                Hide();

            }
            if (button5.Text == "Цар Иван Александър се прославил като?")
            {
                player.Play();

                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct;
                frmResult.Show();
                Hide();
            }
            if (button5.Text == "За „Баща на историята“ се смята древногръцкият учен?")
            {
                player1.Play();

                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct + 1;
                frmResult.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от книжовниците НЕ е от времето на „Златния век”?")
            {
                player.Play();


                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct;
                frmResult.Show();
                Hide();

            }
            if (button5.Text == "Цар Иван Александър се прославил като?")
            {
                player.Play();

                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct;
                frmResult.Show();
                Hide();
            }
            if (button5.Text == "За „Баща на историята“ се смята древногръцкият учен?")
            {
                player.Play();

                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct;
                frmResult.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от книжовниците НЕ е от времето на „Златния век”?")
            {
                player1.Play();


                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct + 1;
                frmResult.Show();
                Hide();

            }
            if (button5.Text == "Цар Иван Александър се прославил като?")
            {
                player1.Play();

                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct + 1;
                frmResult.Show();
                Hide();
            }
            if (button5.Text == "За „Баща на историята“ се смята древногръцкият учен?")
            {
                player.Play();

                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct;
                frmResult.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Кой от книжовниците НЕ е от времето на „Златния век”?")
            {
                player.Play();


                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct;
                frmResult.Show();
                Hide();

            }
            if (button5.Text == "Цар Иван Александър се прославил като?")
            {
                player.Play();

                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct;
                frmResult.Show();
                Hide();
            }
            if (button5.Text == "За „Баща на историята“ се смята древногръцкият учен?")
            {
                player.Play();

                frmResult = new FormResult();
                frmResult.passTime1 = Time1;
                frmResult.passTime2 = Time2;
                frmResult.passTime3 = Time3;
                frmResult.passTime4 = Time4;
                frmResult.passTime5 = Time5;
                frmResult.passTime6 = Time6;
                frmResult.passTime7 = Time7;
                frmResult.passTime8 = Time8;
                frmResult.passTime9 = Time9;
                frmResult.passTime10 = a;
                frmResult.passCorrect = Correct;
                frmResult.Show();
                Hide();
            }
        }
    }
}
