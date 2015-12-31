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
    public partial class Setings : Form
    {
        private Form1 frm1;
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
            public Setings()
        {
            InitializeComponent();
            Melody.SoundLocation = "Best_of_NoCopyrightSounds__ALL_TIME_NCS_Compilation_[Free_Download].wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Melody.Play();
            
            button2.Visible = true;
            button1.Visible = false;
            label1.Text = "1";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frm1 = new Form1();
            frm1.passValue = label1.Text;
            frm1.Show();
            Hide();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox9.Visible = true;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label1.Text = "0";
            Melody.Stop();
            button1.Visible = true;
            button2.Visible = false;
        }

        private void Setings_Load(object sender, EventArgs e)
        {
            label1.Text = (N3);
            if (label1.Text == "1")
            {
                button2.Visible = true;
                button1.Visible = false;
            }
            label1.Text = (N3);
            if (label1.Text == "0")
            {
                button1.Visible = true;
                button2.Visible = false;
            }
        }
    }
}
