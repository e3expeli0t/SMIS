namespace SMIS
{
    partial class SubjectClassess
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSet = new SMIS.SmisDataSet();
            this.subjects_ClassesTableAdapter = new SMIS.SmisDataSetTableAdapters.Subjects_ClassesTableAdapter();
            this.SubjectSelector = new System.Windows.Forms.ComboBox();
            this.TotalTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassSelector = new System.Windows.Forms.ComboBox();
            this.DoAdd = new System.Windows.Forms.Button();
            this.DoEdit = new System.Windows.Forms.Button();
            this.DoRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.totalTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subjectsClassesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalTimeDataGridViewTextBoxColumn
            // 
            this.totalTimeDataGridViewTextBoxColumn.DataPropertyName = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn.HeaderText = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn.Name = "totalTimeDataGridViewTextBoxColumn";
            this.totalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectsClassesBindingSource
            // 
            this.subjectsClassesBindingSource.DataMember = "Subjects_Classes";
            this.subjectsClassesBindingSource.DataSource = this.smisDataSetBindingSource;
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
            // subjects_ClassesTableAdapter
            // 
            this.subjects_ClassesTableAdapter.ClearBeforeFill = true;
            // 
            // SubjectSelector
            // 
            this.SubjectSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectSelector.FormattingEnabled = true;
            this.SubjectSelector.Location = new System.Drawing.Point(68, 192);
            this.SubjectSelector.Name = "SubjectSelector";
            this.SubjectSelector.Size = new System.Drawing.Size(121, 21);
            this.SubjectSelector.TabIndex = 1;
            // 
            // TotalTime
            // 
            this.TotalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTime.Location = new System.Drawing.Point(68, 259);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(121, 20);
            this.TotalTime.TabIndex = 2;
            this.TotalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class";
            // 
            // ClassSelector
            // 
            this.ClassSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassSelector.FormattingEnabled = true;
            this.ClassSelector.Location = new System.Drawing.Point(68, 230);
            this.ClassSelector.Name = "ClassSelector";
            this.ClassSelector.Size = new System.Drawing.Size(121, 21);
            this.ClassSelector.TabIndex = 5;
            // 
            // DoAdd
            // 
            this.DoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoAdd.Location = new System.Drawing.Point(301, 190);
            this.DoAdd.Name = "DoAdd";
            this.DoAdd.Size = new System.Drawing.Size(75, 23);
            this.DoAdd.TabIndex = 7;
            this.DoAdd.Text = "New";
            this.DoAdd.UseVisualStyleBackColor = true;
            this.DoAdd.Click += new System.EventHandler(this.DoAdd_Click);
            // 
            // DoEdit
            // 
            this.DoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoEdit.Location = new System.Drawing.Point(301, 256);
            this.DoEdit.Name = "DoEdit";
            this.DoEdit.Size = new System.Drawing.Size(75, 23);
            this.DoEdit.TabIndex = 8;
            this.DoEdit.Text = "Edit";
            this.DoEdit.UseVisualStyleBackColor = true;
            // 
            // DoRemove
            // 
            this.DoRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoRemove.Location = new System.Drawing.Point(301, 223);
            this.DoRemove.Name = "DoRemove";
            this.DoRemove.Size = new System.Drawing.Size(75, 23);
            this.DoRemove.TabIndex = 9;
            this.DoRemove.Text = "Remove";
            this.DoRemove.UseVisualStyleBackColor = true;
            // 
            // SubjectClassess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(452, 294);
            this.Controls.Add(this.DoRemove);
            this.Controls.Add(this.DoEdit);
            this.Controls.Add(this.DoAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClassSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.SubjectSelector);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SubjectClassess";
            this.Text = "SubjectClassess";
            this.Load += new System.EventHandler(this.SubjectClassess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource smisDataSetBindingSource;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource subjectsClassesBindingSource;
        private SmisDataSetTableAdapters.Subjects_ClassesTableAdapter subjects_ClassesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox SubjectSelector;
        private System.Windows.Forms.TextBox TotalTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ClassSelector;
        private System.Windows.Forms.Button DoAdd;
        private System.Windows.Forms.Button DoEdit;
        private System.Windows.Forms.Button DoRemove;
    }
}