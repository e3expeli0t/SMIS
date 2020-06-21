namespace SMIS
{
    partial class Schedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DoSchedule = new System.Windows.Forms.Button();
            this.ScheduleView = new System.Windows.Forms.DataGridView();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuersday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleView)).BeginInit();
            this.SuspendLayout();
            // 
            // DoSchedule
            // 
            this.DoSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoSchedule.Location = new System.Drawing.Point(407, 371);
            this.DoSchedule.Name = "DoSchedule";
            this.DoSchedule.Size = new System.Drawing.Size(91, 41);
            this.DoSchedule.TabIndex = 0;
            this.DoSchedule.Text = "Schedule";
            this.DoSchedule.UseVisualStyleBackColor = true;
            this.DoSchedule.Click += new System.EventHandler(this.DoSchedule_Click);
            // 
            // ScheduleView
            // 
            this.ScheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hour,
            this.Sunday,
            this.Monday,
            this.Tuersday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday});
            this.ScheduleView.Location = new System.Drawing.Point(50, 12);
            this.ScheduleView.Name = "ScheduleView";
            this.ScheduleView.Size = new System.Drawing.Size(846, 303);
            this.ScheduleView.TabIndex = 1;
            // 
            // Hour
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Hour.DefaultCellStyle = dataGridViewCellStyle1;
            this.Hour.HeaderText = "Hour";
            this.Hour.Name = "Hour";
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Sunday";
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Monday";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            // 
            // Tuersday
            // 
            this.Tuersday.HeaderText = "Tuersday";
            this.Tuersday.Name = "Tuersday";
            this.Tuersday.ReadOnly = true;
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Wednesday";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Thursday";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Friday";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Saturday";
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 470);
            this.Controls.Add(this.ScheduleView);
            this.Controls.Add(this.DoSchedule);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoSchedule;
        private System.Windows.Forms.DataGridView ScheduleView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuersday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
    }
}