using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.Utilities.Exceptions
{
    public class Project_FristException: Exception
    {
        public Project_FristException()
        {

        }

        public Project_FristException(string message)
            : base (message)
        {

        }

        public Project_FristException(string message, Exception inner)
            : base (message, inner)        
        {

        }
    }
}
