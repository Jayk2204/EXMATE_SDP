using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class signup: Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.AutoSize = false;  // allow manual height
                    txt.Height = 27;       // set height
                    txt.Font = new Font("Segoe UI", 10); // optional for better look
                }
            }
        }

        private void txtboxconfirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                // Show passwords
                txtpassword.UseSystemPasswordChar = false;
                txtconfpassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide passwords
                txtpassword.UseSystemPasswordChar = true;
                txtconfpassword.UseSystemPasswordChar = true;
            }
        }

        private void lblsignup_Click(object sender, EventArgs e)
        {
            Login signupForm = new Login();
            signupForm.Show();


            this.Hide();
        }
    }
}
