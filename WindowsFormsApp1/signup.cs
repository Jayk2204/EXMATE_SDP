using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;      // ✅ SQLite instead of SqlClient
using System.Configuration;   // ✅ For connection string

namespace WindowsFormsApp1
{
    public partial class signup : Form
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
                    txt.Font = new Font("Segoe UI", 10); // better look
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

        private void btnregister_Click(object sender, EventArgs e)
        {
            // ✅ Step 1: Validate fields
            if (string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text) ||
                string.IsNullOrWhiteSpace(txtconfpassword.Text))
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtpassword.Text != txtconfpassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // ✅ Step 2: Get connection string from App.config
                string connStr = ConfigurationManager.ConnectionStrings["SQLiteConn"].ConnectionString;

                using (SQLiteConnection conn = new SQLiteConnection(connStr))
                {
                    conn.Open();

                    // ✅ Step 3: Insert new user
                    string query = "INSERT INTO users (username, email, password) VALUES (@username, @email, @password)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ✅ Step 4: Redirect to login form
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
