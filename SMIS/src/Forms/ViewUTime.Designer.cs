namespace SMIS
{
    partial class ViewUTime
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
            this.TimeView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unavailableTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSet = new SMIS.SmisDataSet();
            this.smisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unavailableTimeTableAdapter = new SMIS.SmisDataSetTableAdapters.UnavailableTimeTableAdapter();
            this.TeacherSelector = new System.Windows.Forms.ComboBox();
            this.DoReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unavailableTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeView
            // 
            this.TimeView.AllowUserToAddRows = false;
            this.TimeView.AllowUserToDeleteRows = false;
            this.TimeView.AutoGenerateColumns = false;
            this.TimeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.TimeView.DataSource = this.unavailableTimeBindingSource;
            this.TimeView.Location = new System.Drawing.Point(1, 0);
            this.TimeView.Name = "TimeView";
            this.TimeView.ReadOnly = true;
            this.TimeView.Size = new System.Drawing.Size(450, 340);
            this.TimeView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            this.teacherIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // smisDataSetBindingSource
            // 
            this.smisDataSetBindingSource.DataSource = this.smisDataSet;
            this.smisDataSetBindingSource.Position = 0;
            // 
            // unavailableTimeTableAdapter
            // 
            this.unavailableTimeTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherSelector
            // 
            this.TeacherSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherSelector.FormattingEnabled = true;
            this.TeacherSelector.Items.AddRange(new object[] {
            "All"});
            this.TeacherSelector.Location = new System.Drawing.Point(152, 346);
            this.TeacherSelector.Name = "TeacherSelector";
            this.TeacherSelector.Size = new System.Drawing.Size(121, 21);
            this.TeacherSelector.TabIndex = 1;
            this.TeacherSelector.SelectedIndexChanged += new System.EventHandler(this.TeacherSelector_SelectedIndexChanged);
            // 
            // DoReset
            // 
            this.DoReset.Location = new System.Drawing.Point(292, 346);
            this.DoReset.Name = "DoReset";
            this.DoReset.Size = new System.Drawing.Size(75, 23);
            this.DoReset.TabIndex = 2;
            this.DoReset.Text = "Reset";
            this.DoReset.UseVisualStyleBackColor = true;
            this.DoReset.Click += new System.EventHandler(this.DoReset_Click);
            // 
            // ViewUTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 380);
            this.Controls.Add(this.DoReset);
            this.Controls.Add(this.TeacherSelector);
            this.Controls.Add(this.TimeView);
            this.Name = "ViewUTime";
            this.Text = "ViewUTime";
            this.Load += new System.EventHandler(this.ViewUTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unavailableTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TimeView;
        private System.Windows.Forms.BindingSource smisDataSetBindingSource;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource unavailableTimeBindingSource;
        private SmisDataSetTableAdapters.UnavailableTimeTableAdapter unavailableTimeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox TeacherSelector;
        private System.Windows.Forms.Button DoReset;
    }
}