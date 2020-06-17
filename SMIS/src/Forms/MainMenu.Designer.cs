namespace SMIS
{
    partial class MainMenu
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
            this.Classes = new System.Windows.Forms.Button();
            this.SubjectTeachers = new System.Windows.Forms.Button();
            this.Subjects = new System.Windows.Forms.Button();
            this.Teachers = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Groups = new System.Windows.Forms.Button();
            this.ViewUTime = new System.Windows.Forms.Button();
            this.SubjectClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Classes
            // 
            this.Classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Classes.Location = new System.Drawing.Point(115, 246);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(138, 49);
            this.Classes.TabIndex = 0;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            this.Classes.Click += new System.EventHandler(this.Classes_Click);
            // 
            // SubjectTeachers
            // 
            this.SubjectTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectTeachers.Location = new System.Drawing.Point(115, 340);
            this.SubjectTeachers.Name = "SubjectTeachers";
            this.SubjectTeachers.Size = new System.Drawing.Size(138, 49);
            this.SubjectTeachers.TabIndex = 1;
            this.SubjectTeachers.Text = "Subjects Teachers";
            this.SubjectTeachers.UseVisualStyleBackColor = true;
            this.SubjectTeachers.Click += new System.EventHandler(this.SubjectTeachers_Click);
            // 
            // Subjects
            // 
            this.Subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subjects.Location = new System.Drawing.Point(450, 246);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(138, 49);
            this.Subjects.TabIndex = 2;
            this.Subjects.Text = "Subjects";
            this.Subjects.UseVisualStyleBackColor = true;
            this.Subjects.Click += new System.EventHandler(this.Subjects_Click);
            // 
            // Teachers
            // 
            this.Teachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teachers.Location = new System.Drawing.Point(289, 246);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(138, 49);
            this.Teachers.TabIndex = 3;
            this.Teachers.Text = "Teachers";
            this.Teachers.UseVisualStyleBackColor = true;
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(180, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 83);
            this.progressBar1.TabIndex = 4;
            // 
            // Groups
            // 
            this.Groups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Groups.Location = new System.Drawing.Point(289, 340);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(138, 49);
            this.Groups.TabIndex = 5;
            this.Groups.Text = "View Groups";
            this.Groups.UseVisualStyleBackColor = true;
            this.Groups.Click += new System.EventHandler(this.Groups_Click);
            // 
            // ViewUTime
            // 
            this.ViewUTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewUTime.Location = new System.Drawing.Point(450, 340);
            this.ViewUTime.Name = "ViewUTime";
            this.ViewUTime.Size = new System.Drawing.Size(138, 49);
            this.ViewUTime.TabIndex = 6;
            this.ViewUTime.Text = "View Hours";
            this.ViewUTime.UseVisualStyleBackColor = true;
            this.ViewUTime.Click += new System.EventHandler(this.ViewUTime_Click);
            // 
            // SubjectClasses
            // 
            this.SubjectClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectClasses.Location = new System.Drawing.Point(289, 419);
            this.SubjectClasses.Name = "SubjectClasses";
            this.SubjectClasses.Size = new System.Drawing.Size(138, 49);
            this.SubjectClasses.TabIndex = 7;
            this.SubjectClasses.Text = "Subjects classes";
            this.SubjectClasses.UseVisualStyleBackColor = true;
            this.SubjectClasses.Click += new System.EventHandler(this.SubjectClasses_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 525);
            this.Controls.Add(this.SubjectClasses);
            this.Controls.Add(this.ViewUTime);
            this.Controls.Add(this.Groups);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.SubjectTeachers);
            this.Controls.Add(this.Classes);
            this.Name = "MainMenu";
            this.Text = "textt";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Classes;
        private System.Windows.Forms.Button SubjectTeachers;
        private System.Windows.Forms.Button Subjects;
        private System.Windows.Forms.Button Teachers;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Groups;
        private System.Windows.Forms.Button ViewUTime;
        private System.Windows.Forms.Button SubjectClasses;
    }
}