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
        private String password="";
        private String user="";

        //For testing
        String valid_user = "c1c224b03cd9bc7b6a86d77f5dace40191766c485cd55dc48caf9ac873335d6f";
        String valid_password = "bb40f26bff132769970a9a1e36f499234349ba3c83617f1c5cc63b94b4538e1c";

        //Parses the LastLogin.json and user.lgn file
        public Login() {
        }

        //Creates new LastLogin file and calls reProccess to re parse 
        public void NewLogin(String user, String password) {
            this.password = password;
            this.user = user;
        }

        //For testing
        public bool TryLogin() {
            return this.validateTesting(this.user, this.password);
        }
        private bool validateTesting(String user, string password)
        {
            return valid_user == RandomString.sha265(user) && valid_password == RandomString.sha265(password);
        }

        public void ReProccess() { }
        private bool CheckValid() {
            return false;
        }

        
    }
}
