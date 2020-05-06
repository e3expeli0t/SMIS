namespace SMIS
{
    partial class EditHours
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
            this.AddHour = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DoRemove = new System.Windows.Forms.Button();
            this.TimeList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddHour
            // 
            this.AddHour.Location = new System.Drawing.Point(62, 218);
            this.AddHour.Name = "AddHour";
            this.AddHour.Size = new System.Drawing.Size(69, 34);
            this.AddHour.TabIndex = 12;
            this.AddHour.Text = "Add time";
            this.AddHour.UseVisualStyleBackColor = true;
            this.AddHour.Click += new System.EventHandler(this.AddHour_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.CalendarFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(83, 62);
            this.TimePicker.MaxDate = new System.DateTime(2225, 12, 31, 0, 0, 0, 0);
            this.TimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(117, 20);
            this.TimePicker.TabIndex = 11;
            this.TimePicker.Value = new System.DateTime(2020, 5, 5, 16, 12, 56, 0);
            // 
            // DoRemove
            // 
            this.DoRemove.Location = new System.Drawing.Point(151, 218);
            this.DoRemove.Name = "DoRemove";
            this.DoRemove.Size = new System.Drawing.Size(71, 34);
            this.DoRemove.TabIndex = 13;
            this.DoRemove.Text = "Remove time";
            this.DoRemove.UseVisualStyleBackColor = true;
            // 
            // TimeList
            // 
            this.TimeList.FormattingEnabled = true;
            this.TimeList.Location = new System.Drawing.Point(80, 100);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(120, 95);
            this.TimeList.TabIndex = 14;
            // 
            // EditHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 294);
            this.Controls.Add(this.TimeList);
            this.Controls.Add(this.DoRemove);
            this.Controls.Add(this.AddHour);
            this.Controls.Add(this.TimePicker);
            this.Name = "EditHours";
            this.Text = "EditHours";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddHour;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button DoRemove;
        private System.Windows.Forms.ListBox TimeList;
    }
}