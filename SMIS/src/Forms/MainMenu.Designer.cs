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
            this.Subjects = new System.Windows.Forms.Button();
            this.Teachers = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ViewUTime = new System.Windows.Forms.Button();
            this.SetupSG = new System.Windows.Forms.Button();
            this.ViewGroups = new System.Windows.Forms.Button();
            this.AddGrade = new System.Windows.Forms.Button();
            this.ViewSchedule = new System.Windows.Forms.Button();
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
            // ViewUTime
            // 
            this.ViewUTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewUTime.Location = new System.Drawing.Point(115, 409);
            this.ViewUTime.Name = "ViewUTime";
            this.ViewUTime.Size = new System.Drawing.Size(138, 49);
            this.ViewUTime.TabIndex = 6;
            this.ViewUTime.Text = "View Hours";
            this.ViewUTime.UseVisualStyleBackColor = true;
            this.ViewUTime.Click += new System.EventHandler(this.ViewUTime_Click);
            // 
            // SetupSG
            // 
            this.SetupSG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetupSG.Location = new System.Drawing.Point(289, 340);
            this.SetupSG.Name = "SetupSG";
            this.SetupSG.Size = new System.Drawing.Size(138, 49);
            this.SetupSG.TabIndex = 8;
            this.SetupSG.Text = "Setup study group";
            this.SetupSG.UseVisualStyleBackColor = true;
            this.SetupSG.Click += new System.EventHandler(this.SetupSG_Click);
            // 
            // ViewGroups
            // 
            this.ViewGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewGroups.Location = new System.Drawing.Point(115, 340);
            this.ViewGroups.Name = "ViewGroups";
            this.ViewGroups.Size = new System.Drawing.Size(138, 49);
            this.ViewGroups.TabIndex = 9;
            this.ViewGroups.Text = "View Groups";
            this.ViewGroups.UseVisualStyleBackColor = true;
            // 
            // AddGrade
            // 
            this.AddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGrade.Location = new System.Drawing.Point(450, 340);
            this.AddGrade.Name = "AddGrade";
            this.AddGrade.Size = new System.Drawing.Size(138, 49);
            this.AddGrade.TabIndex = 10;
            this.AddGrade.Text = "Grades";
            this.AddGrade.UseVisualStyleBackColor = true;
            this.AddGrade.Click += new System.EventHandler(this.AddGrade_Click);
            // 
            // ViewSchedule
            // 
            this.ViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSchedule.Location = new System.Drawing.Point(289, 409);
            this.ViewSchedule.Name = "ViewSchedule";
            this.ViewSchedule.Size = new System.Drawing.Size(138, 49);
            this.ViewSchedule.TabIndex = 11;
            this.ViewSchedule.Text = "View schedule";
            this.ViewSchedule.UseVisualStyleBackColor = true;
            this.ViewSchedule.Click += new System.EventHandler(this.ViewSchedule_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 525);
            this.Controls.Add(this.ViewSchedule);
            this.Controls.Add(this.AddGrade);
            this.Controls.Add(this.ViewGroups);
            this.Controls.Add(this.SetupSG);
            this.Controls.Add(this.ViewUTime);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.Classes);
            this.Name = "MainMenu";
            this.Text = "SMIS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Classes;
        private System.Windows.Forms.Button Subjects;
        private System.Windows.Forms.Button Teachers;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ViewUTime;
        private System.Windows.Forms.Button SetupSG;
        private System.Windows.Forms.Button ViewGroups;
        private System.Windows.Forms.Button AddGrade;
        private System.Windows.Forms.Button ViewSchedule;
    }
}