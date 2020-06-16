namespace SMIS
{
    partial class Classes
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
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.DoSearch = new System.Windows.Forms.Button();
            this.ClassesView = new System.Windows.Forms.DataGridView();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSet = new SMIS.SmisDataSet();
            this.classesTableAdapter = new SMIS.SmisDataSetTableAdapters.ClassesTableAdapter();
            this.TeacherName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClassesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(30, 326);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(77, 29);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(212, 328);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(70, 27);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(123, 326);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(73, 29);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Visible = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(79, 229);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(100, 20);
            this.ClassName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grade";
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(79, 281);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(100, 20);
            this.Grade.TabIndex = 8;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(65, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 20);
            this.Search.TabIndex = 11;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // DoSearch
            // 
            this.DoSearch.Location = new System.Drawing.Point(12, 9);
            this.DoSearch.Name = "DoSearch";
            this.DoSearch.Size = new System.Drawing.Size(47, 27);
            this.DoSearch.TabIndex = 12;
            this.DoSearch.Text = "search";
            this.DoSearch.UseVisualStyleBackColor = true;
            this.DoSearch.Click += new System.EventHandler(this.DoSearch_Click);
            // 
            // ClassesView
            // 
            this.ClassesView.AllowUserToAddRows = false;
            this.ClassesView.AllowUserToDeleteRows = false;
            this.ClassesView.AutoGenerateColumns = false;
            this.ClassesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classNameDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.ClassesView.DataSource = this.classesBindingSource;
            this.ClassesView.Location = new System.Drawing.Point(11, 47);
            this.ClassesView.Name = "ClassesView";
            this.ClassesView.ReadOnly = true;
            this.ClassesView.Size = new System.Drawing.Size(344, 141);
            this.ClassesView.TabIndex = 13;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.smisDataSetBindingSource;
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
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherName
            // 
            this.TeacherName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TeacherName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TeacherName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherName.FormattingEnabled = true;
            this.TeacherName.Location = new System.Drawing.Point(79, 255);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(121, 21);
            this.TeacherName.TabIndex = 14;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 376);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.ClassesView);
            this.Controls.Add(this.DoSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button DoSearch;
        private System.Windows.Forms.DataGridView ClassesView;
        private System.Windows.Forms.BindingSource smisDataSetBindingSource;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private SmisDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox TeacherName;
    }
}