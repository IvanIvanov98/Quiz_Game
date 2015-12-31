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
    public partial class PassBackFrm : Form
    {
        private Form1 frm1;
        public PassBackFrm()
        {
            InitializeComponent();
        }

        private void PassBackFrm_Load(object sender, EventArgs e)
        {
            StreamReader Sr = new StreamReader("Register.txt");
            string name = Sr.ReadLine();
            textBox1.Text = Sr.ReadLine();
            Sr.Close();
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
