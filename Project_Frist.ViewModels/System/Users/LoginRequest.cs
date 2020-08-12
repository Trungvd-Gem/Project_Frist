using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.ViewModels.System.Users
{
    public class LoginRequest
    {
        public string UserName { get; set; }

        public string Passwrod { get; set; }

        public bool RememberMe { get; set; }
    }
}
