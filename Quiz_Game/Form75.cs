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
    public partial class Form75 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form76 frm76;
        int a = 0;
        int Correct = 0;

        
        public Form75()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form75_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
                button5.Text = "Витамин „Д“ е?";
                button1.Text = "Въглехидрат";
                button2.Text = "Стероид"; // Верният Отговор
                button3.Text = "Аминокиселина";
                button4.Text = "Триглицерол"; 
            }
            if (q1 == 2)
            {
                button5.Text = "Какъв остатък съдържат фосфолипидите?";
                button1.Text = "Карбонатен";
                button2.Text = "Амино";
                button3.Text = "Фосфатен"; // Верният Отговор
                button4.Text = "Карбоксилен";
            }
            if (q1 == 3)
            {

                button5.Text = "Колко въгл. атома има рибозата(хексоза)?";
                button1.Text = "6"; // Верният отговор
                button2.Text = "7";
                button3.Text = "5";
                button4.Text = "16";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Витамин „Д“ е?")
            {
                player.Play();


                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct;
                frm76.Show();
                Hide();

            }
            if (button5.Text == "От какво е част зеницата?")
            {
                player.Play();


                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct;
                frm76.Show();
                Hide();
            }
            if (button5.Text == "Колко въгл. атома има рибозата(хексоза)?")
            {
                player1.Play();

                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct + 1;
                frm76.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Витамин „Д“ е?")
            {
                player1.Play();


                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct + 1;
                frm76.Show();
                Hide();

            }
            if (button5.Text == "От какво е част зеницата?")
            {
                player.Play();

                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct;
                frm76.Show();
                Hide();
            }
            if (button5.Text == "Колко въгл. атома има рибозата(хексоза)?")
            {
                player.Play();

                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct;
                frm76.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Витамин „Д“ е?")
            {
                player.Play();


                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct;
                frm76.Show();
                Hide();

            }
            if (button5.Text == "От какво е част зеницата?")
            {
                player1.Play();

                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct + 1;
                frm76.Show();
                Hide();
            }
            if (button5.Text == "Колко въгл. атома има рибозата(хексоза)?")
            {
                player.Play();

                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct;
                frm76.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Витамин „Д“ е?")
            {
                player.Play();


                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct;
                frm76.Show();
                Hide();

            }
            if (button5.Text == "От какво е част зеницата?")
            {
                player.Play();

                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct;
                frm76.Show();
                Hide();
            }
            if (button5.Text == "Колко въгл. атома има рибозата(хексоза)?")
            {
                player.Play();

                frm76 = new Form76();
                frm76.passTime1 = a;
                frm76.passCorrect = Correct;
                frm76.Show();
                Hide();
            }
        }
    }
}
