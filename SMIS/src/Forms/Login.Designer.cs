namespace SMIS
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.UName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.DoLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // UName
            // 
            this.UName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UName.Location = new System.Drawing.Point(98, 123);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(144, 20);
            this.UName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.CausesValidation = false;
            this.Password.Location = new System.Drawing.Point(98, 149);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(144, 20);
            this.Password.TabIndex = 5;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorMessage.Location = new System.Drawing.Point(48, 185);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(194, 13);
            this.ErrorMessage.TabIndex = 6;
            this.ErrorMessage.Text = "Error: one or more login fields are invalid";
            this.ErrorMessage.Visible = false;
            // 
            // DoLogin
            // 
            this.DoLogin.BackColor = System.Drawing.Color.Silver;
            this.DoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoLogin.Location = new System.Drawing.Point(98, 211);
            this.DoLogin.Name = "DoLogin";
            this.DoLogin.Size = new System.Drawing.Size(88, 26);
            this.DoLogin.TabIndex = 7;
            this.DoLogin.Text = "Login";
            this.DoLogin.UseVisualStyleBackColor = false;
            this.DoLogin.Click += new System.EventHandler(this.DoLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 324);
            this.Controls.Add(this.DoLogin);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UName);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Button DoLogin;
    }
}