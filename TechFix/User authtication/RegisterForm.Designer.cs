
namespace TechFix.User_authtication
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.reg_close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.reg_login = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_showPass = new System.Windows.Forms.CheckBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_close
            // 
            this.reg_close.AutoSize = true;
            this.reg_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_close.ForeColor = System.Drawing.Color.Red;
            this.reg_close.Location = new System.Drawing.Point(607, 0);
            this.reg_close.Name = "reg_close";
            this.reg_close.Size = new System.Drawing.Size(21, 20);
            this.reg_close.TabIndex = 10;
            this.reg_close.Text = "X";
            this.reg_close.Click += new System.EventHandler(this.reg_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.role);
            this.panel1.Controls.Add(this.reg_username);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.reg_close);
            this.panel1.Controls.Add(this.reg_login);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.reg_showPass);
            this.panel1.Controls.Add(this.register_btn);
            this.panel1.Controls.Add(this.reg_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.reg_email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 406);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Role";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Location = new System.Drawing.Point(344, 186);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(236, 24);
            this.role.TabIndex = 13;
            // 
            // reg_username
            // 
            this.reg_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_username.Location = new System.Drawing.Point(297, 143);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(285, 22);
            this.reg_username.TabIndex = 12;
            this.reg_username.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Username";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // reg_login
            // 
            this.reg_login.AutoSize = true;
            this.reg_login.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reg_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_login.ForeColor = System.Drawing.Color.Green;
            this.reg_login.Location = new System.Drawing.Point(391, 365);
            this.reg_login.Name = "reg_login";
            this.reg_login.Size = new System.Drawing.Size(93, 20);
            this.reg_login.TabIndex = 9;
            this.reg_login.Text = "Log In here";
            this.reg_login.Click += new System.EventHandler(this.reg_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Don\'t have an account?";
            // 
            // reg_showPass
            // 
            this.reg_showPass.AutoSize = true;
            this.reg_showPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg_showPass.Location = new System.Drawing.Point(448, 282);
            this.reg_showPass.Name = "reg_showPass";
            this.reg_showPass.Size = new System.Drawing.Size(129, 21);
            this.reg_showPass.TabIndex = 7;
            this.reg_showPass.Text = "Show Password";
            this.reg_showPass.UseVisualStyleBackColor = false;
            this.reg_showPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Lime;
            this.register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(297, 295);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(93, 37);
            this.register_btn.TabIndex = 6;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // reg_password
            // 
            this.reg_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_password.Location = new System.Drawing.Point(294, 256);
            this.reg_password.Name = "reg_password";
            this.reg_password.PasswordChar = '*';
            this.reg_password.Size = new System.Drawing.Size(285, 22);
            this.reg_password.TabIndex = 5;
            this.reg_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // reg_email
            // 
            this.reg_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_email.Location = new System.Drawing.Point(297, 85);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(285, 22);
            this.reg_email.TabIndex = 3;
            this.reg_email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Started";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 406);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PanRoman", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.Location = new System.Drawing.Point(48, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "TechFix";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 124);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label reg_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reg_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox reg_showPass;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox role;
    }
}