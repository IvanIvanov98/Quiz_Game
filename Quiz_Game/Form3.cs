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
    public partial class Form3 : Form
        
    {
        private Form145 frm145;
        private Form135 frm135;
        private Form125 frm125;
        private Form75 frm75;
        private Form115 frm115;
        private Form105 frm105;
        private Form65 frm65;
        private Form55 frm55;
        private Form45 frm45;
        private Form35 frm35;
        private Form25 frm25;
        private Form14 frm14;
        private Form4 frm4;
        private Form2 frm2;
        private Form85 frm85;
        private Form95 frm95;

        private int CategoryID;
        public int passID
        {
            get
            {
                return CategoryID;
            }
            set
            {
                CategoryID = value;
            }
        }

        public Form3()
        {
            InitializeComponent();
           
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (CategoryID == 1)
            {
                label1.Text = "3";
                frm25 = new Form25();
                frm25.Show();
                Hide();
            }
            if (CategoryID == 2)
            {
                label1.Text = "3";
                frm55 = new Form55();
                frm55.Show();
                Hide();
            }
            if (CategoryID == 3)
            {
                label1.Text = "3";
                frm85 = new Form85();
                frm85.Show();
                Hide();
            }
            if (CategoryID == 4)
            {
                label1.Text = "3";
                frm105 = new Form105();
                frm105.Show();
                Hide();
            }
            if (CategoryID == 5)
            {
                label1.Text = "3";
                frm145 = new Form145();
                frm145.Show();
                Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CategoryID == 1)
            {
                label1.Text = "1";
                frm4 = new Form4();
                frm4.passValue = label1.Text;
                frm4.Show();
                Hide();
            }
            if (CategoryID == 2)
            {
                label1.Text = "1";
                frm35 = new Form35();
                frm35.Show();
                Hide();
            }
            if (CategoryID == 3)
            {
                label1.Text = "1";
                frm65 = new Form65();
                frm65.Show();
                Hide();
            }
            if (CategoryID == 4)
            {
                label1.Text = "1";
                frm95 = new Form95();
                frm95.Show();
                Hide();
            }
            if (CategoryID == 5)
            {
                label1.Text = "1";
                frm115 = new Form115();
                frm115.Show();
                Hide();
            }

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (CategoryID == 1)
            {
                label1.Text = "2";
                frm14 = new Form14();
                frm14.Show();
                Hide();
            }
            if (CategoryID == 2)
            {
                label1.Text = "1";
                frm45 = new Form45();
                frm45.Show();
                Hide();
            }
            if (CategoryID == 3)
            {
                label1.Text = "1";
                frm75 = new Form75();
                frm75.Show();
                Hide();
            }
            if (CategoryID == 4)
            {
                label1.Text = "1";
                frm125 = new Form125();
                frm125.Show();
                Hide();
            }
            if (CategoryID == 5)
            {
                label1.Text = "1";
                frm135 = new Form135();
                frm135.Show();
                Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox9.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.Show();
            Hide();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
        
        }
    }
}
