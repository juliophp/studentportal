namespace StudentPortal
{
    partial class frm_login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.register = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StudentPortal.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(356, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(380, 166);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(116, 23);
            this.userlabel.TabIndex = 2;
            this.userlabel.Text = "Username:";
           
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lst);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.msg);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.passtext);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.userlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 476);
            this.panel1.TabIndex = 3;
            // 
            // register
            // 
            this.register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.register.FlatAppearance.BorderSize = 3;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register.Font = new System.Drawing.Font("Lucida Fax", 13F);
            this.register.Location = new System.Drawing.Point(453, 387);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(93, 30);
            this.register.TabIndex = 8;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(193, 438);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 24);
            this.msg.TabIndex = 7;
            // 
            // login
            // 
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login.FlatAppearance.BorderSize = 3;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("Lucida Fax", 13F);
            this.login.Location = new System.Drawing.Point(327, 387);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 30);
            this.login.TabIndex = 6;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Lucida Fax", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(327, 265);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(219, 28);
            this.password.TabIndex = 5;
            // 
            // passtext
            // 
            this.passtext.AutoSize = true;
            this.passtext.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext.Location = new System.Drawing.Point(380, 239);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(113, 23);
            this.passtext.TabIndex = 4;
            this.passtext.Text = "Password:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Lucida Fax", 13F);
            this.username.Location = new System.Drawing.Point(327, 192);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(219, 28);
            this.username.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Role:";
            // 
            // lst
            // 
            this.lst.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 22;
            this.lst.Location = new System.Drawing.Point(329, 340);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(218, 26);
            this.lst.TabIndex = 24;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentPortal.Properties.Resources.aptw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(868, 476);
            this.Controls.Add(this.panel1);
            this.Name = "frm_login";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passtext;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst;


    }
}

