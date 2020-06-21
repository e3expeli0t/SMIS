namespace SMIS
{
    partial class SetupStudyGroup
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
            this.SubjectClasses = new System.Windows.Forms.Button();
            this.SubjectTeachers = new System.Windows.Forms.Button();
            this.AddGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubjectClasses
            // 
            this.SubjectClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectClasses.Location = new System.Drawing.Point(151, 22);
            this.SubjectClasses.Name = "SubjectClasses";
            this.SubjectClasses.Size = new System.Drawing.Size(138, 49);
            this.SubjectClasses.TabIndex = 9;
            this.SubjectClasses.Text = "Subjects classes";
            this.SubjectClasses.UseVisualStyleBackColor = true;
            this.SubjectClasses.Click += new System.EventHandler(this.SubjectClasses_Click);
            // 
            // SubjectTeachers
            // 
            this.SubjectTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectTeachers.Location = new System.Drawing.Point(7, 22);
            this.SubjectTeachers.Name = "SubjectTeachers";
            this.SubjectTeachers.Size = new System.Drawing.Size(138, 49);
            this.SubjectTeachers.TabIndex = 8;
            this.SubjectTeachers.Text = "Subjects Teachers";
            this.SubjectTeachers.UseVisualStyleBackColor = true;
            this.SubjectTeachers.Click += new System.EventHandler(this.SubjectTeachers_Click);
            // 
            // AddGroup
            // 
            this.AddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGroup.Location = new System.Drawing.Point(75, 93);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(138, 49);
            this.AddGroup.TabIndex = 10;
            this.AddGroup.Text = "Add Group";
            this.AddGroup.UseVisualStyleBackColor = true;
            this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // SetupStudyGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 174);
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.SubjectClasses);
            this.Controls.Add(this.SubjectTeachers);
            this.Location = new System.Drawing.Point(99, 0);
            this.Name = "SetupStudyGroup";
            this.Text = "SetupStudyGroup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubjectClasses;
        private System.Windows.Forms.Button SubjectTeachers;
        private System.Windows.Forms.Button AddGroup;
    }
}