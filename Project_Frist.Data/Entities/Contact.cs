using Project_Frist.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Project_Frist.Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public Status Status { get; set; }

    }
}
