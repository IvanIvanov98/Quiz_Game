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
    public partial class ForgotPassFrm : Form
    {
        private PassBackFrm PassBack;
        private Form1 frm1;
        public ForgotPassFrm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StreamReader Sr = new StreamReader("Register.txt");
            string Name = Sr.ReadLine();
            string pass = Sr.ReadLine();
            string male = Sr.ReadLine();
            string age = Sr.ReadLine();
            string question = Sr.ReadLine();
            string answer = Sr.ReadLine();
            Sr.Close();
            if (Name == textBox1.Text & male == textBox2.Text & age == textBox3.Text & question == textBox4.Text & answer == textBox5.Text)
            {
                MessageBox.Show("Вие възвърнахте вашата парола.");
                PassBack = new PassBackFrm();
                PassBack.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Някъде сте допуснали грешка. Опитайте пак.");
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
