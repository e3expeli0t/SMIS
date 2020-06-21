namespace SMIS
{
    partial class Groups
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
            this.GroupsView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSet = new SMIS.SmisDataSet();
            this.groupsTableAdapter = new SMIS.SmisDataSetTableAdapters.GroupsTableAdapter();
            this.TeacherSelector = new System.Windows.Forms.ComboBox();
            this.ClassSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubjectSelector = new System.Windows.Forms.ComboBox();
            this.Schedualed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DoRemove = new System.Windows.Forms.Button();
            this.DoAdd = new System.Windows.Forms.Button();
            this.DoReSched = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PossibleTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DoEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupsView
            // 
            this.GroupsView.AllowUserToAddRows = false;
            this.GroupsView.AllowUserToDeleteRows = false;
            this.GroupsView.AutoGenerateColumns = false;
            this.GroupsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.classCodeDataGridViewTextBoxColumn,
            this.availableDataGridViewTextBoxColumn,
            this.scheduledDataGridViewTextBoxColumn,
            this.teachersCodeDataGridViewTextBoxColumn});
            this.GroupsView.DataSource = this.groupsBindingSource;
            this.GroupsView.Location = new System.Drawing.Point(12, 33);
            this.GroupsView.Name = "GroupsView";
            this.GroupsView.ReadOnly = true;
            this.GroupsView.Size = new System.Drawing.Size(543, 242);
            this.GroupsView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classCodeDataGridViewTextBoxColumn
            // 
            this.classCodeDataGridViewTextBoxColumn.DataPropertyName = "ClassCode";
            this.classCodeDataGridViewTextBoxColumn.HeaderText = "ClassCode";
            this.classCodeDataGridViewTextBoxColumn.Name = "classCodeDataGridViewTextBoxColumn";
            this.classCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableDataGridViewTextBoxColumn
            // 
            this.availableDataGridViewTextBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewTextBoxColumn.HeaderText = "Available";
            this.availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            this.availableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scheduledDataGridViewTextBoxColumn
            // 
            this.scheduledDataGridViewTextBoxColumn.DataPropertyName = "Scheduled";
            this.scheduledDataGridViewTextBoxColumn.HeaderText = "Scheduled";
            this.scheduledDataGridViewTextBoxColumn.Name = "scheduledDataGridViewTextBoxColumn";
            this.scheduledDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teachersCodeDataGridViewTextBoxColumn
            // 
            this.teachersCodeDataGridViewTextBoxColumn.DataPropertyName = "TeachersCode";
            this.teachersCodeDataGridViewTextBoxColumn.HeaderText = "TeachersCode";
            this.teachersCodeDataGridViewTextBoxColumn.Name = "teachersCodeDataGridViewTextBoxColumn";
            this.teachersCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.smisDataSetBindingSource;
            // 
            // smisDataSetBindingSource
            // 
            this.smisDataSetBindingSource.DataSource = this.smisDataSet;
            this.smisDataSetBindingSource.Position = 0;
            // 
            // smisDataSet
            // 
            this.smisDataSet.DataSetName = "SmisDataSet";
            this.smisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherSelector
            // 
            this.TeacherSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherSelector.FormattingEnabled = true;
            this.TeacherSelector.Location = new System.Drawing.Point(66, 298);
            this.TeacherSelector.Name = "TeacherSelector";
            this.TeacherSelector.Size = new System.Drawing.Size(121, 21);
            this.TeacherSelector.TabIndex = 1;
            // 
            // ClassSelector
            // 
            this.ClassSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassSelector.FormattingEnabled = true;
            this.ClassSelector.Location = new System.Drawing.Point(66, 351);
            this.ClassSelector.Name = "ClassSelector";
            this.ClassSelector.Size = new System.Drawing.Size(121, 21);
            this.ClassSelector.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duration";
            // 
            // Duration
            // 
            this.Duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Duration.Location = new System.Drawing.Point(67, 395);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(100, 20);
            this.Duration.TabIndex = 7;
            this.Duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Duration_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject";
            // 
            // SubjectSelector
            // 
            this.SubjectSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectSelector.FormattingEnabled = true;
            this.SubjectSelector.Location = new System.Drawing.Point(268, 298);
            this.SubjectSelector.Name = "SubjectSelector";
            this.SubjectSelector.Size = new System.Drawing.Size(121, 21);
            this.SubjectSelector.TabIndex = 8;
            this.SubjectSelector.SelectedIndexChanged += new System.EventHandler(this.SubjectSelector_SelectedIndexChanged);
            // 
            // Schedualed
            // 
            this.Schedualed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Schedualed.Enabled = false;
            this.Schedualed.Location = new System.Drawing.Point(268, 347);
            this.Schedualed.Name = "Schedualed";
            this.Schedualed.Size = new System.Drawing.Size(121, 20);
            this.Schedualed.TabIndex = 11;
            this.Schedualed.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Scheduled";
            this.label5.Visible = false;
            // 
            // DoRemove
            // 
            this.DoRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoRemove.Location = new System.Drawing.Point(91, 440);
            this.DoRemove.Name = "DoRemove";
            this.DoRemove.Size = new System.Drawing.Size(76, 23);
            this.DoRemove.TabIndex = 12;
            this.DoRemove.Text = "Remove";
            this.DoRemove.UseVisualStyleBackColor = true;
            // 
            // DoAdd
            // 
            this.DoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoAdd.Location = new System.Drawing.Point(187, 440);
            this.DoAdd.Name = "DoAdd";
            this.DoAdd.Size = new System.Drawing.Size(75, 23);
            this.DoAdd.TabIndex = 13;
            this.DoAdd.Text = "Add";
            this.DoAdd.UseVisualStyleBackColor = true;
            this.DoAdd.Click += new System.EventHandler(this.DoAdd_Click);
            // 
            // DoReSched
            // 
            this.DoReSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoReSched.Location = new System.Drawing.Point(12, 4);
            this.DoReSched.Name = "DoReSched";
            this.DoReSched.Size = new System.Drawing.Size(75, 23);
            this.DoReSched.TabIndex = 14;
            this.DoReSched.Text = "Reschedule";
            this.DoReSched.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(268, 391);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search";
            // 
            // PossibleTime
            // 
            this.PossibleTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PossibleTime.Cursor = System.Windows.Forms.Cursors.No;
            this.PossibleTime.Location = new System.Drawing.Point(245, 4);
            this.PossibleTime.MaxLength = 10;
            this.PossibleTime.Name = "PossibleTime";
            this.PossibleTime.ReadOnly = true;
            this.PossibleTime.Size = new System.Drawing.Size(88, 20);
            this.PossibleTime.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Possible time";
            // 
            // DoEdit
            // 
            this.DoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoEdit.Location = new System.Drawing.Point(278, 440);
            this.DoEdit.Name = "DoEdit";
            this.DoEdit.Size = new System.Drawing.Size(75, 23);
            this.DoEdit.TabIndex = 19;
            this.DoEdit.Text = "Edit";
            this.DoEdit.UseVisualStyleBackColor = true;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 496);
            this.Controls.Add(this.DoEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PossibleTime);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DoReSched);
            this.Controls.Add(this.DoAdd);
            this.Controls.Add(this.DoRemove);
            this.Controls.Add(this.Schedualed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubjectSelector);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassSelector);
            this.Controls.Add(this.TeacherSelector);
            this.Controls.Add(this.GroupsView);
            this.Name = "Groups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GroupsView;
        private System.Windows.Forms.BindingSource smisDataSetBindingSource;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private SmisDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox TeacherSelector;
        private System.Windows.Forms.ComboBox ClassSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SubjectSelector;
        private System.Windows.Forms.TextBox Schedualed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DoRemove;
        private System.Windows.Forms.Button DoAdd;
        private System.Windows.Forms.Button DoReSched;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PossibleTime;
        private System.Windows.Forms.Button DoEdit;
    }
}