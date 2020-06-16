namespace SMIS
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
            this.DoNew = new System.Windows.Forms.Button();
            this.TeachersView = new System.Windows.Forms.DataGridView();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smisDataSet = new SMIS.SmisDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherName = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DoDelete = new System.Windows.Forms.Button();
            this.teachersTableAdapter = new SMIS.SmisDataSetTableAdapters.TeachersTableAdapter();
            this.DoEdit = new System.Windows.Forms.Button();
            this.DoCancel = new System.Windows.Forms.Button();
            this.TotalTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DoNew
            // 
            this.DoNew.Location = new System.Drawing.Point(370, 444);
            this.DoNew.Name = "DoNew";
            this.DoNew.Size = new System.Drawing.Size(101, 32);
            this.DoNew.TabIndex = 0;
            this.DoNew.Text = "New";
            this.DoNew.UseVisualStyleBackColor = true;
            this.DoNew.Click += new System.EventHandler(this.DoSave_Click);
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
            this.TeachersView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersView_CellClick);
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
            this.teachersBindingSource.DataSource = this.smisDataSet;
            // 
            // smisDataSet
            // 
            this.smisDataSet.DataSetName = "SmisDataSet";
            this.smisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(265, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full name";
            // 
            // TeacherName
            // 
            this.TeacherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeacherName.Location = new System.Drawing.Point(323, 292);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(117, 20);
            this.TeacherName.TabIndex = 3;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumber.Location = new System.Drawing.Point(323, 327);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(117, 20);
            this.PhoneNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
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
            // DoDelete
            // 
            this.DoDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DoDelete.Location = new System.Drawing.Point(487, 444);
            this.DoDelete.Name = "DoDelete";
            this.DoDelete.Size = new System.Drawing.Size(101, 32);
            this.DoDelete.TabIndex = 15;
            this.DoDelete.Text = "Delete";
            this.DoDelete.UseVisualStyleBackColor = true;
            this.DoDelete.Click += new System.EventHandler(this.DoDelete_Click);
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // DoEdit
            // 
            this.DoEdit.Location = new System.Drawing.Point(251, 444);
            this.DoEdit.Name = "DoEdit";
            this.DoEdit.Size = new System.Drawing.Size(101, 32);
            this.DoEdit.TabIndex = 16;
            this.DoEdit.Text = "Edit";
            this.DoEdit.UseVisualStyleBackColor = true;
            this.DoEdit.Visible = false;
            this.DoEdit.Click += new System.EventHandler(this.DoEdit_Click);
            // 
            // DoCancel
            // 
            this.DoCancel.Location = new System.Drawing.Point(607, 444);
            this.DoCancel.Name = "DoCancel";
            this.DoCancel.Size = new System.Drawing.Size(101, 32);
            this.DoCancel.TabIndex = 17;
            this.DoCancel.Text = "Cancel edit";
            this.DoCancel.UseVisualStyleBackColor = true;
            this.DoCancel.Visible = false;
            this.DoCancel.Click += new System.EventHandler(this.DoCancel_Click);
            // 
            // TotalTime
            // 
            this.TotalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTime.Location = new System.Drawing.Point(531, 295);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(117, 20);
            this.TotalTime.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // IDNum
            // 
            this.IDNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDNum.Location = new System.Drawing.Point(323, 359);
            this.IDNum.Name = "IDNum";
            this.IDNum.Size = new System.Drawing.Size(117, 20);
            this.IDNum.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID number";
            // 
            // addr
            // 
            this.addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addr.Location = new System.Drawing.Point(531, 330);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(117, 20);
            this.addr.TabIndex = 23;
            // 
            // Teachers
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 517);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.IDNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DoCancel);
            this.Controls.Add(this.DoEdit);
            this.Controls.Add(this.DoDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeachersView);
            this.Controls.Add(this.DoNew);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoNew;
        private System.Windows.Forms.DataGridView TeachersView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeacherName;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DoDelete;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private SmisDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DoEdit;
        private System.Windows.Forms.Button DoCancel;
        private System.Windows.Forms.TextBox TotalTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addr;
    }
}