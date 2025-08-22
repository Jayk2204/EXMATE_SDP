namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtusername = new System.Windows.Forms.TextBox();
            this.picboxuser = new System.Windows.Forms.PictureBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.picboxpassword = new System.Windows.Forms.PictureBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblforgetpass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblorconnect = new System.Windows.Forms.Label();
            this.picboxgoogle = new System.Windows.Forms.PictureBox();
            this.lbldonthaveacc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblexmate = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblsignup = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxgoogle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtusername.Location = new System.Drawing.Point(156, 289);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(359, 31);
            this.txtusername.TabIndex = 1;
            this.txtusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // picboxuser
            // 
            this.picboxuser.BackColor = System.Drawing.Color.Transparent;
            this.picboxuser.Image = global::WindowsFormsApp1.Properties.Resources._7153150;
            this.picboxuser.Location = new System.Drawing.Point(156, 264);
            this.picboxuser.Name = "picboxuser";
            this.picboxuser.Size = new System.Drawing.Size(37, 24);
            this.picboxuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxuser.TabIndex = 2;
            this.picboxuser.TabStop = false;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(189, 269);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(92, 17);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "Username :";
            // 
            // picboxpassword
            // 
            this.picboxpassword.BackColor = System.Drawing.Color.Transparent;
            this.picboxpassword.Image = global::WindowsFormsApp1.Properties.Resources._7781678;
            this.picboxpassword.Location = new System.Drawing.Point(156, 344);
            this.picboxpassword.Name = "picboxpassword";
            this.picboxpassword.Size = new System.Drawing.Size(37, 24);
            this.picboxpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxpassword.TabIndex = 4;
            this.picboxpassword.TabStop = false;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(189, 347);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(89, 17);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Password :";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtpassword.Location = new System.Drawing.Point(156, 370);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(359, 22);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lblforgetpass
            // 
            this.lblforgetpass.AutoSize = true;
            this.lblforgetpass.BackColor = System.Drawing.Color.Transparent;
            this.lblforgetpass.Font = new System.Drawing.Font("Microsoft Tai Le", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgetpass.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblforgetpass.Location = new System.Drawing.Point(399, 415);
            this.lblforgetpass.Name = "lblforgetpass";
            this.lblforgetpass.Size = new System.Drawing.Size(102, 32);
            this.lblforgetpass.TabIndex = 8;
            this.lblforgetpass.Text = "Forget password ?\r\n\r\n";
            // 
            // btnlogin
            // 
            this.btnlogin.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2025_08_21_at_20_37_12_2061eda6;
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(156, 471);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(359, 38);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblorconnect
            // 
            this.lblorconnect.AutoSize = true;
            this.lblorconnect.BackColor = System.Drawing.Color.Transparent;
            this.lblorconnect.Font = new System.Drawing.Font("Microsoft Tai Le", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorconnect.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblorconnect.Location = new System.Drawing.Point(283, 519);
            this.lblorconnect.Name = "lblorconnect";
            this.lblorconnect.Size = new System.Drawing.Size(100, 32);
            this.lblorconnect.TabIndex = 10;
            this.lblorconnect.Text = "Or Connect With\r\n\r\n";
            // 
            // picboxgoogle
            // 
            this.picboxgoogle.BackColor = System.Drawing.Color.Transparent;
            this.picboxgoogle.Image = global::WindowsFormsApp1.Properties.Resources._768px_Google__G__logo_svg;
            this.picboxgoogle.Location = new System.Drawing.Point(317, 538);
            this.picboxgoogle.Name = "picboxgoogle";
            this.picboxgoogle.Size = new System.Drawing.Size(35, 30);
            this.picboxgoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxgoogle.TabIndex = 11;
            this.picboxgoogle.TabStop = false;
            // 
            // lbldonthaveacc
            // 
            this.lbldonthaveacc.AutoSize = true;
            this.lbldonthaveacc.BackColor = System.Drawing.Color.Transparent;
            this.lbldonthaveacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonthaveacc.Location = new System.Drawing.Point(218, 597);
            this.lbldonthaveacc.Name = "lbldonthaveacc";
            this.lbldonthaveacc.Size = new System.Drawing.Size(195, 22);
            this.lbldonthaveacc.TabIndex = 12;
            this.lbldonthaveacc.Text = "Dont have an account?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icone_cercle_violet;
            this.pictureBox1.Location = new System.Drawing.Point(271, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblexmate
            // 
            this.lblexmate.AutoSize = true;
            this.lblexmate.BackColor = System.Drawing.Color.Transparent;
            this.lblexmate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexmate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblexmate.Location = new System.Drawing.Point(641, 315);
            this.lblexmate.Name = "lblexmate";
            this.lblexmate.Size = new System.Drawing.Size(190, 54);
            this.lblexmate.TabIndex = 15;
            this.lblexmate.Text = "ExMate";
            this.lblexmate.Click += new System.EventHandler(this.lblexmate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(1229, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 17;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.BackColor = System.Drawing.Color.Transparent;
            this.lblsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup.Location = new System.Drawing.Point(407, 597);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(66, 22);
            this.lblsignup.TabIndex = 18;
            this.lblsignup.Text = "Signup\r\n";
            this.lblsignup.Click += new System.EventHandler(this.lblsignup_Click_1);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkShowPassword.Location = new System.Drawing.Point(156, 414);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(111, 20);
            this.chkShowPassword.TabIndex = 31;
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.file_00000000cc8461f9b8755bfd9482eee5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1286, 758);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblexmate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbldonthaveacc);
            this.Controls.Add(this.picboxgoogle);
            this.Controls.Add(this.lblorconnect);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblforgetpass);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.picboxpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.picboxuser);
            this.Controls.Add(this.txtusername);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxgoogle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.PictureBox picboxuser;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox picboxpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblforgetpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblorconnect;
        private System.Windows.Forms.PictureBox picboxgoogle;
        private System.Windows.Forms.Label lbldonthaveacc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblexmate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}

