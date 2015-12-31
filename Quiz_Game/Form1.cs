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

namespace Quiz_Game
{
    public partial class Form1 : Form
    {
        private Userform user;
        private Setings stngs;
        private LoginForm Logfrm;
        private GameInfoFormcs GameInfo;
        System.Media.SoundPlayer Melody = new System.Media.SoundPlayer();

        private string N3;
        public string passValue
        {
            get
            {
                return N3;
            }
            set
            {
                N3 = value;
            }
        }
            public Form1()
        {
            InitializeComponent();
            Melody.SoundLocation = "Best_of_NoCopyrightSounds__ALL_TIME_NCS_Compilation_[Free_Download].wav";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 categoriesPanel = new Form2();
            categoriesPanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            stngs = new Setings();
            stngs.passValue = N3;
            stngs.Show();
            Hide();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string proba;
            StreamReader Sr = new StreamReader("Register.txt");
            proba = Sr.ReadLine();
            Sr.Close();
            if (proba == "No name")
            {
                user = new Userform();
                user.Show();
                Hide();
            }
            else
            {
                Logfrm = new LoginForm();
                Logfrm.Show();
                Hide();
            }

        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            pictureBox9.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            GameInfo = new GameInfoFormcs();
            GameInfo.Show();
            Hide();
        }
    }
}
