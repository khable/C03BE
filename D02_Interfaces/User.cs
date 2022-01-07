using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{


    class User : IAutentication
    {

        #region Constructors
        public User()
        {
            UserName = string.Empty;
            UserPassword = string.Empty;

        }

        public User(string username , string userpassword)
        {
            UserName = username;
            UserPassword = userpassword;
        }

        public 
       

        #endregion

        string message;

        #region Properties
        public string UserName { get; set; }

        public string UserPassword { get; set; }
        #endregion
    


        #region Methods
        public void Exit()
        {
            message = "A sair.";
            Message(message, "\n\n");
        }

        public void Message(string message, string startLine = "", string endLine = "")
        {
            Console.WriteLine($"{startLine}{message}{endLine}");
        }

        public bool Validate(string userName, string userPassword)
        {
            if (userName == "Antonio" && userPassword == "12345")
            {
                
                message =  "OK";
                Message(message,"","\n");
                return true;

            }
            else
            {
                message = "Não OK";
                Message(message, "\n\n");
                return false;
            }

            
           

        }
        #endregion

        
    }
}
