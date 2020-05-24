using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMISSecurity;


/*
 * Class responsible to handle all open resources and major errors
 * also the class handles user access control and other security related stuff
 */
namespace SMIS
{
    public partial class MainMenu : Form
    {
        //Class should handle users. so this would be replaced with User class
        private AccessLevel AdminAccsess = AccessLevel.Admin;

        public MainMenu()
        {

            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        //todo: add login support
        private void login()
        {
        }

        private void Classes_Click(object sender, EventArgs e)
        {
            new Classes(AdminAccsess).Show();
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            new Teachers(AccessLevel.Admin).Show();
        }

        private void Subjects_Click(object sender, EventArgs e)
        {
            new Subjects(AccessLevel.Admin).ShowDialog();
        }
    }
}
