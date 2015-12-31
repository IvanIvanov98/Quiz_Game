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
    public partial class Form2 : Form
    {
        private Form1 frm1;
        private Form3 frm3;
        int ID;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox7.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox7.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ID = 1;
            frm3 = new Form3();
            frm3.passID = ID;
            frm3.Show();
            Hide();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox8.Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox9.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox10.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ID = 3;
            frm3 = new Form3();
            frm3.passID = ID;
            frm3.Show();
            Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Visible = true;
            pictureBox6.Visible = false;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox11.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ID = 5;
            frm3 = new Form3();
            frm3.passID = ID;
            frm3.Show();
            Hide();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox12.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ID = 2;
            frm3 = new Form3();
            frm3.passID = ID;
            frm3.Show();
            Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ID = 4;
            frm3 = new Form3();
            frm3.passID = ID;
            frm3.Show();
            Hide();
        }
    }
}
