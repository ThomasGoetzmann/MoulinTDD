using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoulinTDD.Exceptions
{
    public class InvalidPawnOwnerException : Exception
    {
        public InvalidPawnOwnerException(string message) : base(message) {}
    }
}
