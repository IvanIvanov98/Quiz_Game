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
    public partial class LoginForm : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private ProfileForm Profilefrm;
        private Form1 frm1;
        private ForgotPassFrm ForgotPass;
        public LoginForm()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxPass.Enabled = true;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name;
            string Pass;
            StreamReader Sr = new StreamReader("Register.txt");
            Name = Sr.ReadLine();
            Pass = Sr.ReadLine();
            Sr.Close();
            if (Name == textBoxName.Text & Pass == textBoxPass.Text)
            {
                player1.Play();
                MessageBox.Show("Успешно се вписахте във вашият профил.");
                Profilefrm = new ProfileForm();
                Profilefrm.Show();
                Hide();
            }
            else
            {
                player.Play();
                MessageBox.Show("Въвели сте грешно име или парола.");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ForgotPass = new ForgotPassFrm();
            ForgotPass.Show();
            Hide();

        }
    }
}
