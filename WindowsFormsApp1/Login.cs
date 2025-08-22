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
    public partial class Login: Form
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
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
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
                // Show passwords
                txtpassword.UseSystemPasswordChar = false;
                
            }
            else
            {
                // Hide passwords
                txtpassword.UseSystemPasswordChar = true;
           
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginDB.mdf;Integrated Security=True"))
            //{
            //    string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
            //    SqlCommand cmd = new SqlCommand(query, con);

            //    cmd.Parameters.AddWithValue("@username", txtusername.Text);
            //    cmd.Parameters.AddWithValue("@password", txtpassword.Text);

            //    con.Open();
            //    int count = (int)cmd.ExecuteScalar();
            //    con.Close();

            //    if (count > 0)
            //    {
            //        MessageBox.Show("Login Successful!");
            //        // Open new form
            //        //Home home = new Home();
            //        //home.Show();
            //        //this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Username or Password!");
                }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        }
    }
}
