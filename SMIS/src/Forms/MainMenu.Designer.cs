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
            this.Groups = new System.Windows.Forms.Button();
            this.Subjects = new System.Windows.Forms.Button();
            this.Teachers = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Classes
            // 
            this.Classes.Location = new System.Drawing.Point(263, 290);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(138, 49);
            this.Classes.TabIndex = 0;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            this.Classes.Click += new System.EventHandler(this.Classes_Click);
            // 
            // Groups
            // 
            this.Groups.Location = new System.Drawing.Point(437, 388);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(138, 49);
            this.Groups.TabIndex = 1;
            this.Groups.Text = "View Groups";
            this.Groups.UseVisualStyleBackColor = true;
            // 
            // Subjects
            // 
            this.Subjects.Location = new System.Drawing.Point(598, 290);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(138, 49);
            this.Subjects.TabIndex = 2;
            this.Subjects.Text = "Subjects";
            this.Subjects.UseVisualStyleBackColor = true;
            // 
            // Teachers
            // 
            this.Teachers.Location = new System.Drawing.Point(437, 290);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(138, 49);
            this.Teachers.TabIndex = 3;
            this.Teachers.Text = "Teachers";
            this.Teachers.UseVisualStyleBackColor = true;
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(328, 122);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 83);
            this.progressBar1.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 645);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.Groups);
            this.Controls.Add(this.Classes);
            this.Name = "MainMenu";
            this.Text = "textt";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Classes;
        private System.Windows.Forms.Button Groups;
        private System.Windows.Forms.Button Subjects;
        private System.Windows.Forms.Button Teachers;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}