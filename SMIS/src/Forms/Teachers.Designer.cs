﻿namespace SMIS
{
    partial class Teachers
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
            this.DoSave = new System.Windows.Forms.Button();
            this.TeachersView = new System.Windows.Forms.DataGridView();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SmisDataSet = new SMIS.SMISDBDataSet();
            this.teachersTableAdapter = new SMIS.SMISDBDataSetTableAdapters.TeachersTableAdapter();
            this.teachersGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherName = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Helper = new System.Windows.Forms.HelpProvider();
            this.AddHour = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DoEdit = new System.Windows.Forms.Button();
            this.DoDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersGroupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DoSave
            // 
            this.DoSave.Location = new System.Drawing.Point(438, 460);
            this.DoSave.Name = "DoSave";
            this.DoSave.Size = new System.Drawing.Size(101, 32);
            this.DoSave.TabIndex = 0;
            this.DoSave.Text = "Save";
            this.DoSave.UseVisualStyleBackColor = true;
            this.DoSave.Click += new System.EventHandler(this.DoSave_Click);
            // 
            // TeachersView
            // 
            this.TeachersView.AutoGenerateColumns = false;
            this.TeachersView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeachersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn});
            this.TeachersView.DataSource = this.teachersBindingSource;
            this.TeachersView.Location = new System.Drawing.Point(94, 12);
            this.TeachersView.Name = "TeachersView";
            this.TeachersView.Size = new System.Drawing.Size(743, 275);
            this.TeachersView.TabIndex = 1;
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.SmisDataSet;
            // 
            // SmisDataSet
            // 
            this.SmisDataSet.DataSetName = "SMISDBDataSet";
            this.SmisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // teachersGroupsBindingSource
            // 
            this.teachersGroupsBindingSource.DataMember = "TeachersGroups";
            this.teachersGroupsBindingSource.DataSource = this.teachersBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(380, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full name";
            // 
            // TeacherName
            // 
            this.TeacherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeacherName.Location = new System.Drawing.Point(438, 299);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(117, 20);
            this.TeacherName.TabIndex = 3;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumber.Location = new System.Drawing.Point(438, 334);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(117, 20);
            this.PhoneNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // Address
            // 
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address.Location = new System.Drawing.Point(438, 370);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(117, 20);
            this.Address.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // AddHour
            // 
            this.AddHour.Location = new System.Drawing.Point(366, 405);
            this.AddHour.Name = "AddHour";
            this.AddHour.Size = new System.Drawing.Size(59, 26);
            this.AddHour.TabIndex = 10;
            this.AddHour.Text = "Add time";
            this.AddHour.UseVisualStyleBackColor = true;
            this.AddHour.Click += new System.EventHandler(this.AddHour_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.CalendarFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(438, 405);
            this.TimePicker.MaxDate = new System.DateTime(2225, 12, 31, 0, 0, 0, 0);
            this.TimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(117, 20);
            this.TimePicker.TabIndex = 9;
            this.TimePicker.Value = new System.DateTime(2020, 5, 5, 16, 12, 56, 0);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(869, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Quick serach";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DoEdit
            // 
            this.DoEdit.Location = new System.Drawing.Point(316, 460);
            this.DoEdit.Name = "DoEdit";
            this.DoEdit.Size = new System.Drawing.Size(101, 32);
            this.DoEdit.TabIndex = 14;
            this.DoEdit.Text = "Edit";
            this.DoEdit.UseVisualStyleBackColor = true;
            // 
            // DoDelete
            // 
            this.DoDelete.Location = new System.Drawing.Point(571, 460);
            this.DoDelete.Name = "DoDelete";
            this.DoDelete.Size = new System.Drawing.Size(101, 32);
            this.DoDelete.TabIndex = 15;
            this.DoDelete.Text = "Delete";
            this.DoDelete.UseVisualStyleBackColor = true;
            // 
            // Teachers
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 517);
            this.Controls.Add(this.DoDelete);
            this.Controls.Add(this.DoEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddHour);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeachersView);
            this.Controls.Add(this.DoSave);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersGroupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoSave;
        private System.Windows.Forms.DataGridView TeachersView;
        private SMISDBDataSet SmisDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private SMISDBDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource teachersGroupsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeacherName;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider Helper;
        private System.Windows.Forms.Button AddHour;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DoEdit;
        private System.Windows.Forms.Button DoDelete;
    }
}