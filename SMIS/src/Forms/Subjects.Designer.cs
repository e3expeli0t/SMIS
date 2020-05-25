namespace SMIS
{
    partial class Subjects
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
            this.SubjectsView = new System.Windows.Forms.DataGridView();
            this.lIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSet = new SMIS.SmisDataSet();
            this.subjectsTableAdapter = new SMIS.SmisDataSetTableAdapters.SubjectsTableAdapter();
            this.DoSave = new System.Windows.Forms.Button();
            this.DoEdit = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectsView
            // 
            this.SubjectsView.AutoGenerateColumns = false;
            this.SubjectsView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.SubjectsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lIDDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn});
            this.SubjectsView.DataSource = this.subjectsBindingSource;
            this.SubjectsView.Location = new System.Drawing.Point(37, 12);
            this.SubjectsView.Name = "SubjectsView";
            this.SubjectsView.Size = new System.Drawing.Size(245, 132);
            this.SubjectsView.TabIndex = 1;
            this.SubjectsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectsView_CellContentClick);
            // 
            // lIDDataGridViewTextBoxColumn
            // 
            this.lIDDataGridViewTextBoxColumn.DataPropertyName = "LID";
            this.lIDDataGridViewTextBoxColumn.HeaderText = "LID";
            this.lIDDataGridViewTextBoxColumn.Name = "lIDDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.smisDataSetBindingSource;
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
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // DoSave
            // 
            this.DoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoSave.Location = new System.Drawing.Point(64, 208);
            this.DoSave.Name = "DoSave";
            this.DoSave.Size = new System.Drawing.Size(93, 33);
            this.DoSave.TabIndex = 2;
            this.DoSave.Text = "Save";
            this.DoSave.UseVisualStyleBackColor = true;
            this.DoSave.Click += new System.EventHandler(this.DoSave_Click);
            // 
            // DoEdit
            // 
            this.DoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoEdit.Location = new System.Drawing.Point(163, 208);
            this.DoEdit.Name = "DoEdit";
            this.DoEdit.Size = new System.Drawing.Size(93, 33);
            this.DoEdit.TabIndex = 3;
            this.DoEdit.Text = "Edit";
            this.DoEdit.UseVisualStyleBackColor = false;
            this.DoEdit.Visible = false;
            this.DoEdit.Click += new System.EventHandler(this.DoEdit_Click);
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(119, 163);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(100, 20);
            this.Subject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMIS.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(297, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.DoEdit);
            this.Controls.Add(this.DoSave);
            this.Controls.Add(this.SubjectsView);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SubjectsView;
        private System.Windows.Forms.BindingSource smisDataSetBindingSource;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private SmisDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DoSave;
        private System.Windows.Forms.Button DoEdit;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label1;
    }
}