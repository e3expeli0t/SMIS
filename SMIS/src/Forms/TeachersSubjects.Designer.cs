namespace SMIS
{
    partial class TeachersSubjects
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
            this.DoAdd = new System.Windows.Forms.Button();
            this.DoRemove = new System.Windows.Forms.Button();
            this.TeacherSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectSelection = new System.Windows.Forms.ComboBox();
            this.DoEdit = new System.Windows.Forms.Button();
            this.TeachersSubjectsView = new System.Windows.Forms.DataGridView();
            this.smisDataSet = new SMIS.SmisDataSet();
            this.smisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachers_SubjectsTableAdapter = new SMIS.SmisDataSetTableAdapters.Teachers_SubjectsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersSubjectsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DoAdd
            // 
            this.DoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoAdd.Location = new System.Drawing.Point(214, 233);
            this.DoAdd.Name = "DoAdd";
            this.DoAdd.Size = new System.Drawing.Size(82, 23);
            this.DoAdd.TabIndex = 1;
            this.DoAdd.Text = "New";
            this.DoAdd.UseVisualStyleBackColor = true;
            this.DoAdd.Click += new System.EventHandler(this.DoAdd_Click);
            // 
            // DoRemove
            // 
            this.DoRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoRemove.Location = new System.Drawing.Point(214, 191);
            this.DoRemove.Name = "DoRemove";
            this.DoRemove.Size = new System.Drawing.Size(82, 23);
            this.DoRemove.TabIndex = 2;
            this.DoRemove.Text = "Remove";
            this.DoRemove.UseVisualStyleBackColor = true;
            this.DoRemove.Click += new System.EventHandler(this.DoRemove_Click);
            // 
            // TeacherSelection
            // 
            this.TeacherSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherSelection.FormattingEnabled = true;
            this.TeacherSelection.Location = new System.Drawing.Point(65, 188);
            this.TeacherSelection.Name = "TeacherSelection";
            this.TeacherSelection.Size = new System.Drawing.Size(121, 21);
            this.TeacherSelection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject";
            // 
            // SubjectSelection
            // 
            this.SubjectSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectSelection.FormattingEnabled = true;
            this.SubjectSelection.Location = new System.Drawing.Point(65, 230);
            this.SubjectSelection.Name = "SubjectSelection";
            this.SubjectSelection.Size = new System.Drawing.Size(121, 21);
            this.SubjectSelection.TabIndex = 5;
            // 
            // DoEdit
            // 
            this.DoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoEdit.Location = new System.Drawing.Point(214, 191);
            this.DoEdit.Name = "DoEdit";
            this.DoEdit.Size = new System.Drawing.Size(82, 23);
            this.DoEdit.TabIndex = 7;
            this.DoEdit.Text = "Edit";
            this.DoEdit.UseVisualStyleBackColor = true;
            this.DoEdit.Visible = false;
            this.DoEdit.Click += new System.EventHandler(this.DoEdit_Click);
            // 
            // TeachersSubjectsView
            // 
            this.TeachersSubjectsView.AutoGenerateColumns = false;
            this.TeachersSubjectsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersSubjectsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.SubjectIDDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn});
            this.TeachersSubjectsView.DataSource = this.teachersSubjectsBindingSource;
            this.TeachersSubjectsView.Location = new System.Drawing.Point(12, 12);
            this.TeachersSubjectsView.Name = "TeachersSubjectsView";
            this.TeachersSubjectsView.Size = new System.Drawing.Size(342, 139);
            this.TeachersSubjectsView.TabIndex = 8;
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
            // teachersSubjectsBindingSource
            // 
            this.teachersSubjectsBindingSource.DataMember = "Teachers_Subjects";
            this.teachersSubjectsBindingSource.DataSource = this.smisDataSetBindingSource;
            // 
            // teachers_SubjectsTableAdapter
            // 
            this.teachers_SubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // SubjectIDDataGridViewTextBoxColumn
            // 
            this.SubjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.SubjectIDDataGridViewTextBoxColumn.HeaderText = "SubjectID";
            this.SubjectIDDataGridViewTextBoxColumn.Name = "SubjectIDDataGridViewTextBoxColumn";
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // TeachersSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 286);
            this.Controls.Add(this.TeachersSubjectsView);
            this.Controls.Add(this.DoEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubjectSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeacherSelection);
            this.Controls.Add(this.DoRemove);
            this.Controls.Add(this.DoAdd);
            this.Name = "TeachersSubjects";
            this.Text = "Teachers subject chooser";
            this.Load += new System.EventHandler(this.TeachersSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersSubjectsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DoAdd;
        private System.Windows.Forms.Button DoRemove;
        private System.Windows.Forms.ComboBox TeacherSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SubjectSelection;
        private System.Windows.Forms.Button DoEdit;
        private System.Windows.Forms.DataGridView TeachersSubjectsView;
        private System.Windows.Forms.BindingSource smisDataSetBindingSource;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource teachersSubjectsBindingSource;
        private SmisDataSetTableAdapters.Teachers_SubjectsTableAdapter teachers_SubjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
    }
}