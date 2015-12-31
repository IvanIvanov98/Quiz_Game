using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;


namespace Quiz_Game
{
    public partial class FormResult : Form
    {

        private Form1 frm1;

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
        private int Time10;
        public int passTime10
        {
            get
            {
                return Time10;
            }
            set
            {
                Time10 = value;
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

        public FormResult()
        {
            InitializeComponent();
            
        }

        private void FormResult_Load(object sender, EventArgs e)
        {


            int a = (Time1 + Time2 + Time3 + Time4 + Time5 + Time6 + Time7 + Time8 + Time9 + Time10) - 10;
            int halfA = a / 10;
            int Wrong = 10 - Correct;

            int z = a / 2;
            int t = halfA / 2;
            int vtoraChast = (z - t) / Correct;

            int rezultata = ((Correct - Wrong) * 10 + 400) / vtoraChast;
            

            timeLabel.Text = "Общо време:" + (a).ToString();
            timeSrednoLabel.Text = "Средно на въпрос:" + (halfA).ToString();

            labelCorrect.Text = "Верни отговори:" + (Correct).ToString();
            labelWrong.Text = "Грешни отговори:" + (Wrong).ToString();

            labelResult.Text = (((Correct - Wrong) * 10 + 400) / vtoraChast).ToString();

            if (rezultata > 620)
            {
                pictureBoxGold.Visible = true;

            }
            if (rezultata > 200 & rezultata < 620)
            {
                pictureBoxSilver.Visible = true;

            }
            if (rezultata < 200)
            {
                pictureBoxBronze.Visible = true;

            }
            if (pictureBoxBronze.Visible = true)
            {
                labelIdMedal.Text = "1";
            }
            if (pictureBoxSilver.Visible = true)
            {
                labelIdMedal.Text = "2";
            }
            if (pictureBoxGold.Visible = true)
            {
                labelIdMedal.Text = "3";
            }
            StreamWriter SW = new StreamWriter("LastGameStats.txt");
            SW.WriteLine(Correct.ToString());
            SW.WriteLine(Wrong.ToString());
            SW.WriteLine(a.ToString());
            SW.WriteLine(halfA.ToString());
            SW.WriteLine(labelIdMedal.Text);
            SW.WriteLine(rezultata.ToString());
            SW.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}