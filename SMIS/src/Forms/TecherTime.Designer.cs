namespace SMIS
{
    partial class TecherTime
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
            this.components = new System.ComponentModel.Container();
            this.TTimeView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unavailableTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSet = new SMIS.SmisDataSet();
            this.unavailableTimeTableAdapter = new SMIS.SmisDataSetTableAdapters.UnavailableTimeTableAdapter();
            this.DoAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.ComboBox();
            this.TimeList = new System.Windows.Forms.ComboBox();
            this.DoRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TTimeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unavailableTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TTimeView
            // 
            this.TTimeView.AllowUserToAddRows = false;
            this.TTimeView.AllowUserToDeleteRows = false;
            this.TTimeView.AutoGenerateColumns = false;
            this.TTimeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTimeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.TTimeView.DataSource = this.unavailableTimeBindingSource;
            this.TTimeView.Location = new System.Drawing.Point(47, 12);
            this.TTimeView.Name = "TTimeView";
            this.TTimeView.ReadOnly = true;
            this.TTimeView.Size = new System.Drawing.Size(445, 153);
            this.TTimeView.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // unavailableTimeBindingSource
            // 
            this.unavailableTimeBindingSource.DataMember = "UnavailableTime";
            this.unavailableTimeBindingSource.DataSource = this.smisDataSet;
            // 
            // smisDataSet
            // 
            this.smisDataSet.DataSetName = "SmisDataSet";
            this.smisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unavailableTimeTableAdapter
            // 
            this.unavailableTimeTableAdapter.ClearBeforeFill = true;
            // 
            // DoAdd
            // 
            this.DoAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DoAdd.Location = new System.Drawing.Point(138, 314);
            this.DoAdd.Name = "DoAdd";
            this.DoAdd.Size = new System.Drawing.Size(75, 23);
            this.DoAdd.TabIndex = 2;
            this.DoAdd.Text = "Add";
            this.DoAdd.UseVisualStyleBackColor = true;
            this.DoAdd.Click += new System.EventHandler(this.DoAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time";
            // 
            // Day
            // 
            this.Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.Day.Location = new System.Drawing.Point(176, 224);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(121, 21);
            this.Day.TabIndex = 7;
            // 
            // TimeList
            // 
            this.TimeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeList.FormattingEnabled = true;
            this.TimeList.Location = new System.Drawing.Point(176, 271);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(121, 21);
            this.TimeList.TabIndex = 8;
            // 
            // DoRemove
            // 
            this.DoRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DoRemove.Location = new System.Drawing.Point(235, 314);
            this.DoRemove.Name = "DoRemove";
            this.DoRemove.Size = new System.Drawing.Size(75, 23);
            this.DoRemove.TabIndex = 9;
            this.DoRemove.Text = "Remove";
            this.DoRemove.UseVisualStyleBackColor = true;
            this.DoRemove.Click += new System.EventHandler(this.DoRemove_Click);
            // 
            // TecherTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 349);
            this.Controls.Add(this.DoRemove);
            this.Controls.Add(this.TimeList);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoAdd);
            this.Controls.Add(this.TTimeView);
            this.Name = "TecherTime";
            this.Text = "TecherTime";
            this.Load += new System.EventHandler(this.TecherTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TTimeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unavailableTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TTimeView;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource unavailableTimeBindingSource;
        private SmisDataSetTableAdapters.UnavailableTimeTableAdapter unavailableTimeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DoAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox TimeList;
        private System.Windows.Forms.Button DoRemove;
    }
}