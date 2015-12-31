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
    public partial class Form14 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form15 frm15;
        int value = 0;
        int Correct;


        public Form14()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int q1 = 0;
            Random r = new Random();
            q1 = r.Next(1, 4);
            if (q1 == 1)
            {
             
               button5.Text = "В кой континент е страната  Ливан?";
                button1.Text = "Африка"; 
                button2.Text = "Азия"; // Верният Отговор
                button3.Text = "Европа";
                button4.Text = "Северна Америка";
            }
            if (q1 == 2)
            {
                

               button5.Text = "Неизчерпаеми природни ресурси са?";
                button1.Text = "въглища";
                button2.Text = "почвени ресурси"; 
                button3.Text = "горски ресурси"; 
                button4.Text = "енергия на вятъра"; // Верният Отговор
            }
            if (q1 == 3)
            {
               button5.Text = "Коя страна не е член на ЕС?";
                button1.Text = "Норвегия";  // Верният отговор
                button2.Text = "Финландия"; 
                button3.Text = "Швеция";
                button4.Text = "Белгия";  
            }
            
        

 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (value++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой континент е страната  Ливан?")
            {
                player.Play();
                
                frm15 = new Form15();
                frm15.passTime1 = value;
                frm15.Show();
                Hide();

            }
            if (button5.Text == "Неизчерпаеми природни ресурси са?")
            {
                player.Play();
                
                frm15 = new Form15();
                frm15.passTime1 = value;
                frm15.Show();
                Hide();
            }
            if (button5.Text == "Коя страна не е член на ЕС?")
            {
                player1.Play();   //Верен отговор
                Correct = 1;

                
                frm15 = new Form15();
                frm15.passCorrect = Correct;
                frm15.passTime1 = value;
                frm15.Show();
                Hide();
            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой континент е страната  Ливан?")
            {
                player1.Play();   //Верен отговор
                Correct = 1;

                
                frm15 = new Form15();
                frm15.passCorrect = Correct;
                frm15.passTime1 = value;
                frm15.Show();
                Hide();

            }
            if (button5.Text == "Неизчерпаеми природни ресурси са?")
            {
                player.Play();
                
                frm15 = new Form15();
                frm15.passTime1 = value;
                frm15.Show();
                Hide();
            }
            if (button5.Text == "Коя страна не е член на ЕС?")
            {
                player.Play();
                
                frm15 = new Form15();
                frm15.passTime1 = value;
                frm15.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой континент е страната  Ливан?")
            {
                player.Play();
                
                frm15 = new Form15();
                frm15.passTime1 = value;
                frm15.Show();
                Hide();

            }
            if (button5.Text == "Неизчерпаеми природни ресурси са?")
            {
                player.Play();
                
                frm15 = new Form15();
                frm15.passTime1 = value;
                frm15.Show();
                Hide();
            }
            if (button5.Text == "Коя страна не е член на ЕС?")
            {
                player.Play();
                
                frm15.passTime1 = value;
                frm15 = new Form15();
                frm15.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "В кой континент е страната  Ливан?")
            {
                player.Play();
                
                frm15 = new Form15();
                frm15.passTime1 = value;
                frm15.Show();
                Hide();

            }
            if (button5.Text == "Неизчерпаеми природни ресурси са?")
            {
                player1.Play();   //Верен отговор
                Correct = 1;

                
                frm15 = new Form15();
                frm15.passCorrect = Correct;
                frm15.passTime1 = value;
                frm15.Show();
                Hide();
            }
            if (button5.Text == "Коя страна не е член на ЕС?")
            {
                player.Play();
                
                frm15 = new Form15();
                frm15.passTime1 = value;
                frm15.Show();
                Hide();
            }
        }
    }
}
