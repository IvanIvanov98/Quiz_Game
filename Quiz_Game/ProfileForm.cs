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
    public partial class ProfileForm : Form
    {
        private Form1 frm1;
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            StreamReader Sr = new StreamReader("Register.txt");
            labelName.Text = Sr.ReadLine();
            string Pass = Sr.ReadLine();
            labelMale.Text = Sr.ReadLine();
            labelAge.Text = Sr.ReadLine();
            Sr.Close();
            StreamReader SR = new StreamReader("LastGameStats.txt");
            labelCorrA.Text = SR.ReadLine();
            labelWrongA.Text = SR.ReadLine();
            labelTime.Text = SR.ReadLine();
            labelTimeAverage.Text = SR.ReadLine();
            string IDmedal = SR.ReadLine();
            labelScore.Text = SR.ReadLine();
            SR.Close();
            if (IDmedal == "1")
            {
                pictureBoxBronze.Visible = true;
            }
            if (IDmedal == "2")
            {
                pictureBoxSilver.Visible = true;
            }
            if (IDmedal == "3")
            {
                pictureBoxGold.Visible = true;
            }
            
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frm1 = new Form1();
            frm1.Show();
            Hide();
        }
    }
}
