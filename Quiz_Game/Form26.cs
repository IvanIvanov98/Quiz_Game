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
    public partial class Form26 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form27 frm27;
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
        public Form26()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Низината Тихама се намира в?";
                    button1.Text = "Саудитска Арабия"; // Верният Отговор
                    button2.Text = "Алжир"; 
                    button3.Text = "Оман";
                    button4.Text = "Йемен";
                }
                if (q1 == 2)
                {
                    button5.Text = "Езерото Ел Ихван принадлежи към?";
                    button1.Text = "Йемен"; // Верният Отговор
                    button2.Text = "Бахрейн";
                    button3.Text = "Катар";
                    button4.Text = "Алжир"; 
                }
                if (q1 == 3)
                {
                    button5.Text = "Континент без действащи вулкани е?";
                    button1.Text = "Африка";
                    button2.Text = "Австралия"; // Верният отговор
                    button3.Text = "Европа";
                    button4.Text = "Азия";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Низината Тихама се намира в?")
            {
                player1.Play();   //Верен отговор
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct + 1;
                frm27.Show();
                Hide();

            }
            if (button5.Text == "Езерото Ел Ихван принадлежи към?")
            {
                player1.Play();   //Верен отговор
                
                frm27 = new Form27();

                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct + 1;
                frm27.Show();
                Hide();
            }
            if (button5.Text == "Континент без действащи вулкани е?")
            {
                player.Play();
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct;
                frm27.Show();
                Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Низината Тихама се намира в?")
            {
                player.Play();
                
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct;
                frm27.Show();
                Hide();

            }
            if (button5.Text == "Езерото Ел Ихван принадлежи към?")
            {
                player.Play();
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct;
                frm27.Show();
                Hide();
            }
            if (button5.Text == "Континент без действащи вулкани е?")
            {
                player.Play();
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct;
                frm27.Show();
                
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Низината Тихама се намира в?")
            {
                player.Play();
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct;
                frm27.Show();
                Hide();

            }
            if (button5.Text == "Езерото Ел Ихван принадлежи към?")
            {
                player1.Play();   //Верен отговор
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct + 1;
                frm27.Show();
                Hide();
            }
            if (button5.Text == "Континент без действащи вулкани е?")
            {
                player.Play();
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct;
                frm27.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Низината Тихама се намира в?")
            {
                player.Play();
               
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct;
                frm27.Show();
                Hide();

            }
            if (button5.Text == "Езерото Ел Ихван принадлежи към?")
            {
                player.Play();
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct;
                frm27.Show();
                Hide();
            }
            if (button5.Text == "Континент без действащи вулкани е?")
            {
                player.Play();
                
                frm27 = new Form27();
                frm27.passTime1 = Time1;
                frm27.passTime2 = a;
                frm27.passCorrect = Correct;
                frm27.Show();
                Hide();
            }
        }
    }
}
