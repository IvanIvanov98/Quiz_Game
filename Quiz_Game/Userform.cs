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
    public partial class Userform : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  // 1) COpy paste
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();  // 1)  COpy paste
        private Form1 frm1;
        public Userform()
        {
            InitializeComponent();
            player.SoundLocation = "wrong.wav"; // 2) Copy paste - greshen otgovor
            player1.SoundLocation = "right.wav"; // 2) Copy paste - Veren Otgovor
        }
        private void Userform_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StreamWriter SW = new StreamWriter("Register.txt");
            SW.WriteLine(textBoxName.Text);
            SW.WriteLine(textBoxPass.Text);
            SW.WriteLine(comboBox1.Text);
            SW.WriteLine(textBoxAge.Text);
            SW.WriteLine(textBox1.Text);
            SW.WriteLine(textBox2.Text);
            SW.Close();
            player1.Play();
            MessageBox.Show("Вие направихте вашата регистрация успешно.");
            frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void pictureBox1_EnabledChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxPass.Enabled = true;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            textBoxAge.Enabled = true;
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
