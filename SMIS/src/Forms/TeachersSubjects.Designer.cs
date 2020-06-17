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
            this.TeacherSubjectsView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSet = new SMIS.SmisDataSet();
            this.teachers_SubjectsTableAdapter = new SMIS.SmisDataSetTableAdapters.Teachers_SubjectsTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DoAdd = new System.Windows.Forms.Button();
            this.DoRemove = new System.Windows.Forms.Button();
            this.TeacherSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectSelection = new System.Windows.Forms.ComboBox();
            this.DoEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherSubjectsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherSubjectsView
            // 
            this.TeacherSubjectsView.AllowUserToAddRows = false;
            this.TeacherSubjectsView.AutoGenerateColumns = false;
            this.TeacherSubjectsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherSubjectsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn});
            this.TeacherSubjectsView.DataSource = this.teachersSubjectsBindingSource;
            this.TeacherSubjectsView.Location = new System.Drawing.Point(12, 12);
            this.TeacherSubjectsView.Name = "TeacherSubjectsView";
            this.TeacherSubjectsView.ReadOnly = true;
            this.TeacherSubjectsView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherSubjectsView.RowTemplate.DefaultCellStyle.NullValue = "(Empty)";
            this.TeacherSubjectsView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Lime;
            this.TeacherSubjectsView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherSubjectsView.Size = new System.Drawing.Size(342, 153);
            this.TeacherSubjectsView.TabIndex = 0;
            this.TeacherSubjectsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherSubjectsView_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            this.teacherIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teachersSubjectsBindingSource
            // 
            this.teachersSubjectsBindingSource.DataMember = "Teachers_Subjects";
            this.teachersSubjectsBindingSource.DataSource = this.smisDataSet;
            // 
            // smisDataSet
            // 
            this.smisDataSet.DataSetName = "SmisDataSet";
            this.smisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachers_SubjectsTableAdapter
            // 
            this.teachers_SubjectsTableAdapter.ClearBeforeFill = true;
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
            // TeachersSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 286);
            this.Controls.Add(this.DoEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubjectSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeacherSelection);
            this.Controls.Add(this.DoRemove);
            this.Controls.Add(this.DoAdd);
            this.Controls.Add(this.TeacherSubjectsView);
            this.Name = "TeachersSubjects";
            this.Text = "Teachers subject chooser";
            this.Load += new System.EventHandler(this.TeachersSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherSubjectsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TeacherSubjectsView;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource teachersSubjectsBindingSource;
        private SmisDataSetTableAdapters.Teachers_SubjectsTableAdapter teachers_SubjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button DoAdd;
        private System.Windows.Forms.Button DoRemove;
        private System.Windows.Forms.ComboBox TeacherSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SubjectSelection;
        private System.Windows.Forms.Button DoEdit;
    }
}