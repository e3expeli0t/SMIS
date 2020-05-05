using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMISSecurity
{
    /*
     * Parses the LastLogin.json file located in Meta/Configuration/
     * then using the key loacted in last login it tries to decrypt the user.lgn
     * located in Meta/Login/. If the file is succsefully  decrypted CreateUser() 
     * returns User Object else: InvaidLoginCredsException is thrown
     */
    class Login
    {
        //Parses the LastLogin.json and user.lgn file
        public Login() {
        }

        //Creates new LastLogin file and calls reProccess to re parse 
        public void NewLogin(String user, String password) {

        }
        public bool TryLogin() {
            return true; 
        }

        public void ReProccess() { }
        private bool CheckValid() {
            return false;
        }
    }
}
