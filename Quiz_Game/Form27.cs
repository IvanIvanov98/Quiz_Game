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
    public partial class Form27 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste

        private Form28 frm28;
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
        public Form27()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void Form27_Load(object sender, EventArgs e)
        {
            {
                timer1.Start();
                int q1 = 0;
                Random r = new Random();
                q1 = r.Next(1, 4);
                if (q1 == 1)
                {
                    button5.Text = "Нац. парк Канайма се намира в?";
                    button1.Text = "Венецуела"; // Верният Отговор
                    button2.Text = "Перу"; 
                    button3.Text = "Чили";
                    button4.Text = "Мексико";
                }
                if (q1 == 2)
                {
                    button5.Text = "Град Гуанахуато е разположен в?";
                    button1.Text = "Аржентина";
                    button2.Text = "Бразилия";
                    button3.Text = "Чили";
                    button4.Text = "Мексико"; // Верният Отговор
                }
                if (q1 == 3)
                {
                    button5.Text = "О-в Комодо принадлежи към?";
                    button1.Text = "Индия";
                    button2.Text = "Индонезия"; // Верният отговор
                    button3.Text = "Тайланд";
                    button4.Text = "Япония";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (a++).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Нац. парк Канайма се намира в?")
            {
                player1.Play();   //Верен отговор
                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct + 1;
                frm28.Show();
                Hide();

            }
            if (button5.Text == "Град Гуанахуато е разположен в?")
            {
                player.Play();

                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct;
                frm28.Show();
                Hide();
            }
            if (button5.Text == "О-в Комодо принадлежи към?")
            {
                player1.Play();   //Верен отговор
                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct + 1;
                frm28.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Нац. парк Канайма се намира в?")
            {
                player.Play();
                
                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct;
                frm28.Show();
                Hide();

            }
            if (button5.Text == "Град Гуанахуато е разположен в?")
            {
                player.Play();

                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct;
                frm28.Show();
                Hide();
            }
            if (button5.Text == "О-в Комодо принадлежи към?")
            {
                player.Play();

                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct;
                frm28.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Нац. парк Канайма се намира в?")
            {
                player.Play();

                
                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct;
                frm28.Show();
                Hide();

            }
            if (button5.Text == "Град Гуанахуато е разположен в?")
            {
                player.Play();

                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct;
                frm28.Show();
                Hide();
            }
            if (button5.Text == "О-в Комодо принадлежи към?")
            {
                player.Play();

                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct;
                frm28.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Нац. парк Канайма се намира в?")
            {
                player.Play();

                
                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct;
                frm28.Show();
                Hide();

            }
            if (button5.Text == "Град Гуанахуато е разположен в?")
            {
                player1.Play();   //Верен отговор
                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct + 1;
                frm28.Show();
                Hide();
            }
            if (button5.Text == "О-в Комодо принадлежи към?")
            {
                player.Play();

                
                frm28 = new Form28();
                frm28.passTime1 = Time1;
                frm28.passTime2 = Time2;
                frm28.passTime2 = a;
                frm28.passCorrect = Correct;
                frm28.Show();
                Hide();
            }
        }
        }
        }
        
