namespace StudentPortal
{
    partial class frm_db
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
            this.label1 = new System.Windows.Forms.Label();
            this.viewTeacher = new System.Windows.Forms.Button();
            this.viewCourses = new System.Windows.Forms.Button();
            this.viewGrades = new System.Windows.Forms.Button();
            this.checkAccount = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.InfoTab = new System.Windows.Forms.TabControl();
            this.CourseList = new System.Windows.Forms.TabPage();
            this.ResultList = new System.Windows.Forms.TabPage();
            this.res = new System.Windows.Forms.Label();
            this.InfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // viewTeacher
            // 
            this.viewTeacher.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTeacher.Location = new System.Drawing.Point(648, 98);
            this.viewTeacher.Name = "viewTeacher";
            this.viewTeacher.Size = new System.Drawing.Size(143, 79);
            this.viewTeacher.TabIndex = 1;
            this.viewTeacher.Text = "View Teachers";
            this.viewTeacher.UseVisualStyleBackColor = true;
            // 
            // viewCourses
            // 
            this.viewCourses.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCourses.Location = new System.Drawing.Point(53, 98);
            this.viewCourses.Name = "viewCourses";
            this.viewCourses.Size = new System.Drawing.Size(143, 79);
            this.viewCourses.TabIndex = 2;
            this.viewCourses.Text = "View Courses";
            this.viewCourses.UseVisualStyleBackColor = true;
            this.viewCourses.Click += new System.EventHandler(this.viewCourses_Click);
            // 
            // viewGrades
            // 
            this.viewGrades.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewGrades.Location = new System.Drawing.Point(249, 98);
            this.viewGrades.Name = "viewGrades";
            this.viewGrades.Size = new System.Drawing.Size(143, 79);
            this.viewGrades.TabIndex = 3;
            this.viewGrades.Text = "View Grades";
            this.viewGrades.UseVisualStyleBackColor = true;
            // 
            // checkAccount
            // 
            this.checkAccount.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAccount.Location = new System.Drawing.Point(453, 98);
            this.checkAccount.Name = "checkAccount";
            this.checkAccount.Size = new System.Drawing.Size(143, 79);
            this.checkAccount.TabIndex = 4;
            this.checkAccount.Text = "Check Account";
            this.checkAccount.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(285, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 13);
            this.id.TabIndex = 5;
            this.id.Visible = false;
            // 
            // InfoTab
            // 
            this.InfoTab.Controls.Add(this.CourseList);
            this.InfoTab.Controls.Add(this.ResultList);
            this.InfoTab.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTab.Location = new System.Drawing.Point(53, 209);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.SelectedIndex = 0;
            this.InfoTab.Size = new System.Drawing.Size(738, 286);
            this.InfoTab.TabIndex = 6;
            // 
            // CourseList
            // 
            this.CourseList.Location = new System.Drawing.Point(4, 33);
            this.CourseList.Name = "CourseList";
            this.CourseList.Padding = new System.Windows.Forms.Padding(3);
            this.CourseList.Size = new System.Drawing.Size(730, 249);
            this.CourseList.TabIndex = 0;
            this.CourseList.Text = "Course List";
            this.CourseList.UseVisualStyleBackColor = true;
            // 
            // ResultList
            // 
            this.ResultList.Location = new System.Drawing.Point(4, 33);
            this.ResultList.Name = "ResultList";
            this.ResultList.Padding = new System.Windows.Forms.Padding(3);
            this.ResultList.Size = new System.Drawing.Size(730, 249);
            this.ResultList.TabIndex = 1;
            this.ResultList.Text = "Result List";
            this.ResultList.UseVisualStyleBackColor = true;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(76, 180);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(0, 27);
            this.res.TabIndex = 7;
            this.res.Visible = false;
            // 
            // frm_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 587);
            this.Controls.Add(this.res);
            this.Controls.Add(this.InfoTab);
            this.Controls.Add(this.id);
            this.Controls.Add(this.checkAccount);
            this.Controls.Add(this.viewGrades);
            this.Controls.Add(this.viewCourses);
            this.Controls.Add(this.viewTeacher);
            this.Controls.Add(this.label1);
            this.Name = "frm_db";
            this.Text = "Dashboard";
            this.InfoTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewTeacher;
        private System.Windows.Forms.Button viewCourses;
        private System.Windows.Forms.Button viewGrades;
        private System.Windows.Forms.Button checkAccount;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TabControl InfoTab;
        private System.Windows.Forms.TabPage CourseList;
        private System.Windows.Forms.TabPage ResultList;
        private System.Windows.Forms.Label res;
    }
}