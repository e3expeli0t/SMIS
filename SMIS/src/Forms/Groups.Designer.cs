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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.smisDataSet = new SMIS.SmisDataSet();
            this.smisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new SMIS.SmisDataSetTableAdapters.GroupsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.classCodeDataGridViewTextBoxColumn,
            this.availableDataGridViewTextBoxColumn,
            this.scheduledDataGridViewTextBoxColumn,
            this.teachersCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.groupsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(192, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 200);
            this.dataGridView1.TabIndex = 0;
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
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.smisDataSetBindingSource;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // classCodeDataGridViewTextBoxColumn
            // 
            this.classCodeDataGridViewTextBoxColumn.DataPropertyName = "ClassCode";
            this.classCodeDataGridViewTextBoxColumn.HeaderText = "ClassCode";
            this.classCodeDataGridViewTextBoxColumn.Name = "classCodeDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewTextBoxColumn
            // 
            this.availableDataGridViewTextBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewTextBoxColumn.HeaderText = "Available";
            this.availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            // 
            // scheduledDataGridViewTextBoxColumn
            // 
            this.scheduledDataGridViewTextBoxColumn.DataPropertyName = "Scheduled";
            this.scheduledDataGridViewTextBoxColumn.HeaderText = "Scheduled";
            this.scheduledDataGridViewTextBoxColumn.Name = "scheduledDataGridViewTextBoxColumn";
            // 
            // teachersCodeDataGridViewTextBoxColumn
            // 
            this.teachersCodeDataGridViewTextBoxColumn.DataPropertyName = "TeachersCode";
            this.teachersCodeDataGridViewTextBoxColumn.HeaderText = "TeachersCode";
            this.teachersCodeDataGridViewTextBoxColumn.Name = "teachersCodeDataGridViewTextBoxColumn";
            // 
            // DoSave
            // 
            this.DoSave.Location = new System.Drawing.Point(328, 383);
            this.DoSave.Name = "DoSave";
            this.DoSave.Size = new System.Drawing.Size(75, 23);
            this.DoSave.TabIndex = 1;
            this.DoSave.Text = "Save";
            this.DoSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 515);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Groups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource smisDataSetBindingSource;
        private SmisDataSet smisDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private SmisDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DoSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}