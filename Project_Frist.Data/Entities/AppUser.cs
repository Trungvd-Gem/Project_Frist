using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.Data.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
    }
}
