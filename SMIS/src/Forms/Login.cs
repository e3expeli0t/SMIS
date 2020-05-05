using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMISInternal;

namespace SMIS
{
    //todo: Think for more secure login system
    public partial class Login : Form
    {
        SMISSecurity.Login LoginManager = new SMISSecurity.Login();
        bool success = false;

        public Login()
        {
            InitializeComponent();
            if (LoginManager.TryLogin()) {
                this.success = true;
                this.Close();
            }
        }

        //todo: return User object
        public bool Success() {
            return this.success;
        }

        private void DoLogin_Click(object sender, EventArgs e)
        {
            this.LoginManager.ReProccess();

            if (!Field.Valid(this.UName.Text, this.Password.Text)) {
                Errors.DisplayMinor("Please supply valid input");
                
                this.ErrorMessage.Visible = false;
                this.UName.Text = "";
                this.Password.Text = "";
                
                return;
            }
            
            
            this.LoginManager.NewLogin(this.UName.Text, this.Password.Text);
            if (!this.LoginManager.TryLogin()) {
                this.ErrorMessage.Visible = true;
                this.Password.Text = "";
                return;
            }
            this.success = true;
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
