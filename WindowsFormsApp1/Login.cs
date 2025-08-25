using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;   // ✅ For SQLite
using System.Configuration; // ✅ For App.config connection string

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblbrief_Click(object sender, EventArgs e)
        {

        }

        private void lblexmate_Click(object sender, EventArgs e)
        {

        }

        private void lblsignup_Click(object sender, EventArgs e)
        {
            signup signupForm = new signup();
            signupForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // (Optional, you can remove if unused)
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblsignup_Click_1(object sender, EventArgs e)
        {
            signup signupForm = new signup();
            signupForm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["SQLiteConn"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE username=@Username AND password=@Password";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtpassword.Text.Trim());

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // TODO: Navigate to Dashboard/Home form
                            // Example:
                            // Dashboard dash = new Dashboard();
                            // dash.Show();
                            // this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
