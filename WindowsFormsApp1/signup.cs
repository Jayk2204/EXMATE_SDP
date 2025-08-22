using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void btnregister_Click(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginDB.mdf;Integrated Security=True"))
            //{
            //    string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
            //    SqlCommand cmd = new SqlCommand(query, con);

            //    cmd.Parameters.AddWithValue("@username", txtusername.Text);
            //    cmd.Parameters.AddWithValue("@password", txtpassword.Text);

            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();

            //    MessageBox.Show("Signup Successful!");
            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
}
