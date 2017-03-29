namespace StudentPortal
{
    partial class ins_db
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
            this.ViewCourses = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.UploadResult = new System.Windows.Forms.Button();
            this.UploadTimeTable = new System.Windows.Forms.Button();
            this.ViewProfile = new System.Windows.Forms.Button();
            this.InfoTab = new System.Windows.Forms.TabControl();
            this.ProfileTab = new System.Windows.Forms.TabPage();
            this.lname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.Label();
            this.lbl_dname = new System.Windows.Forms.Label();
            this.lbl_office_no = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.CoursesTab = new System.Windows.Forms.TabPage();
            this.phone = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.office_no = new System.Windows.Forms.Label();
            this.InfoTab.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewCourses
            // 
            this.ViewCourses.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCourses.Location = new System.Drawing.Point(282, 72);
            this.ViewCourses.Name = "ViewCourses";
            this.ViewCourses.Size = new System.Drawing.Size(146, 71);
            this.ViewCourses.TabIndex = 0;
            this.ViewCourses.Text = "View Courses";
            this.ViewCourses.UseVisualStyleBackColor = true;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(64, 19);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(102, 22);
            this.msg.TabIndex = 1;
            this.msg.Text = "Welcome ";
            // 
            // UploadResult
            // 
            this.UploadResult.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadResult.Location = new System.Drawing.Point(700, 72);
            this.UploadResult.Name = "UploadResult";
            this.UploadResult.Size = new System.Drawing.Size(146, 71);
            this.UploadResult.TabIndex = 2;
            this.UploadResult.Text = "Upload Result";
            this.UploadResult.UseVisualStyleBackColor = true;
            // 
            // UploadTimeTable
            // 
            this.UploadTimeTable.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadTimeTable.Location = new System.Drawing.Point(488, 72);
            this.UploadTimeTable.Name = "UploadTimeTable";
            this.UploadTimeTable.Size = new System.Drawing.Size(146, 71);
            this.UploadTimeTable.TabIndex = 3;
            this.UploadTimeTable.Text = "Upload Schedule";
            this.UploadTimeTable.UseVisualStyleBackColor = true;
            // 
            // ViewProfile
            // 
            this.ViewProfile.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProfile.Location = new System.Drawing.Point(68, 72);
            this.ViewProfile.Name = "ViewProfile";
            this.ViewProfile.Size = new System.Drawing.Size(146, 71);
            this.ViewProfile.TabIndex = 4;
            this.ViewProfile.Text = "View Profile";
            this.ViewProfile.UseVisualStyleBackColor = true;
            // 
            // InfoTab
            // 
            this.InfoTab.Controls.Add(this.ProfileTab);
            this.InfoTab.Controls.Add(this.CoursesTab);
            this.InfoTab.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTab.Location = new System.Drawing.Point(68, 176);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.SelectedIndex = 0;
            this.InfoTab.Size = new System.Drawing.Size(778, 439);
            this.InfoTab.TabIndex = 5;
            // 
            // ProfileTab
            // 
            this.ProfileTab.Controls.Add(this.phone);
            this.ProfileTab.Controls.Add(this.lbl_phone);
            this.ProfileTab.Controls.Add(this.office_no);
            this.ProfileTab.Controls.Add(this.lname);
            this.ProfileTab.Controls.Add(this.lbl_lname);
            this.ProfileTab.Controls.Add(this.uname);
            this.ProfileTab.Controls.Add(this.lbl_uname);
            this.ProfileTab.Controls.Add(this.dname);
            this.ProfileTab.Controls.Add(this.lbl_dname);
            this.ProfileTab.Controls.Add(this.lbl_office_no);
            this.ProfileTab.Controls.Add(this.fname);
            this.ProfileTab.Controls.Add(this.lbl_fname);
            this.ProfileTab.Location = new System.Drawing.Point(4, 31);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfileTab.Size = new System.Drawing.Size(770, 404);
            this.ProfileTab.TabIndex = 0;
            this.ProfileTab.Text = "Profile";
            this.ProfileTab.UseVisualStyleBackColor = true;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(174, 76);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(0, 22);
            this.lname.TabIndex = 9;
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(27, 76);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(117, 22);
            this.lbl_lname.TabIndex = 8;
            this.lbl_lname.Text = "Last Name:";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Location = new System.Drawing.Point(174, 115);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(0, 22);
            this.uname.TabIndex = 7;
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Location = new System.Drawing.Point(27, 115);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(112, 22);
            this.lbl_uname.TabIndex = 6;
            this.lbl_uname.Text = "Username:";
            // 
            // dname
            // 
            this.dname.AutoSize = true;
            this.dname.Location = new System.Drawing.Point(174, 154);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(0, 22);
            this.dname.TabIndex = 5;
            // 
            // lbl_dname
            // 
            this.lbl_dname.AutoSize = true;
            this.lbl_dname.Location = new System.Drawing.Point(27, 154);
            this.lbl_dname.Name = "lbl_dname";
            this.lbl_dname.Size = new System.Drawing.Size(132, 22);
            this.lbl_dname.TabIndex = 4;
            this.lbl_dname.Text = "Department:";
            // 
            // lbl_office_no
            // 
            this.lbl_office_no.AutoSize = true;
            this.lbl_office_no.Location = new System.Drawing.Point(24, 245);
            this.lbl_office_no.Name = "lbl_office_no";
            this.lbl_office_no.Size = new System.Drawing.Size(107, 22);
            this.lbl_office_no.TabIndex = 2;
            this.lbl_office_no.Text = "Office No:";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(174, 32);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(0, 22);
            this.fname.TabIndex = 1;
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(27, 32);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(121, 22);
            this.lbl_fname.TabIndex = 0;
            this.lbl_fname.Text = "First Name:";
            // 
            // CoursesTab
            // 
            this.CoursesTab.Location = new System.Drawing.Point(4, 31);
            this.CoursesTab.Name = "CoursesTab";
            this.CoursesTab.Padding = new System.Windows.Forms.Padding(3);
            this.CoursesTab.Size = new System.Drawing.Size(770, 404);
            this.CoursesTab.TabIndex = 1;
            this.CoursesTab.Text = "Courses";
            this.CoursesTab.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(174, 200);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(0, 22);
            this.phone.TabIndex = 12;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(27, 200);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(74, 22);
            this.lbl_phone.TabIndex = 11;
            this.lbl_phone.Text = "Phone:";
            // 
            // office_no
            // 
            this.office_no.AutoSize = true;
            this.office_no.Location = new System.Drawing.Point(174, 245);
            this.office_no.Name = "office_no";
            this.office_no.Size = new System.Drawing.Size(0, 22);
            this.office_no.TabIndex = 10;
            // 
            // ins_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 645);
            this.Controls.Add(this.InfoTab);
            this.Controls.Add(this.ViewProfile);
            this.Controls.Add(this.UploadTimeTable);
            this.Controls.Add(this.UploadResult);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.ViewCourses);
            this.Name = "ins_db";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher\'s Dashboard";
            this.InfoTab.ResumeLayout(false);
            this.ProfileTab.ResumeLayout(false);
            this.ProfileTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewCourses;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button UploadResult;
        private System.Windows.Forms.Button UploadTimeTable;
        private System.Windows.Forms.Button ViewProfile;
        private System.Windows.Forms.TabControl InfoTab;
        private System.Windows.Forms.TabPage ProfileTab;
        private System.Windows.Forms.TabPage CoursesTab;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Label dname;
        private System.Windows.Forms.Label lbl_dname;
        private System.Windows.Forms.Label lbl_office_no;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label office_no;
    }
}