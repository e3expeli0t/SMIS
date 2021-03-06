﻿namespace SMIS
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
            this.DoRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectsView
            // 
            this.SubjectsView.AllowUserToAddRows = false;
            this.SubjectsView.AllowUserToDeleteRows = false;
            this.SubjectsView.AutoGenerateColumns = false;
            this.SubjectsView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.SubjectsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lIDDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn});
            this.SubjectsView.DataSource = this.subjectsBindingSource;
            this.SubjectsView.Location = new System.Drawing.Point(35, 12);
            this.SubjectsView.Name = "SubjectsView";
            this.SubjectsView.ReadOnly = true;
            this.SubjectsView.Size = new System.Drawing.Size(245, 145);
            this.SubjectsView.TabIndex = 1;
            this.SubjectsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectsView_CellClick);
            // 
            // lIDDataGridViewTextBoxColumn
            // 
            this.lIDDataGridViewTextBoxColumn.DataPropertyName = "LID";
            this.lIDDataGridViewTextBoxColumn.HeaderText = "LID";
            this.lIDDataGridViewTextBoxColumn.Name = "lIDDataGridViewTextBoxColumn";
            this.lIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.DoSave.Location = new System.Drawing.Point(12, 205);
            this.DoSave.Name = "DoSave";
            this.DoSave.Size = new System.Drawing.Size(93, 33);
            this.DoSave.TabIndex = 2;
            this.DoSave.Text = "New";
            this.DoSave.UseVisualStyleBackColor = true;
            this.DoSave.Click += new System.EventHandler(this.DoSave_Click);
            // 
            // DoEdit
            // 
            this.DoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoEdit.Location = new System.Drawing.Point(111, 205);
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
            this.Subject.Location = new System.Drawing.Point(115, 163);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(100, 20);
            this.Subject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(74, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // DoRemove
            // 
            this.DoRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoRemove.Location = new System.Drawing.Point(210, 205);
            this.DoRemove.Name = "DoRemove";
            this.DoRemove.Size = new System.Drawing.Size(93, 33);
            this.DoRemove.TabIndex = 6;
            this.DoRemove.Text = "Delete";
            this.DoRemove.UseVisualStyleBackColor = false;
            this.DoRemove.Click += new System.EventHandler(this.DoRemove_Click);
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 258);
            this.Controls.Add(this.DoRemove);
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
        private System.Windows.Forms.Button DoRemove;
    }
}