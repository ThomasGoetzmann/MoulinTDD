using System;

namespace MoulinTDD.Exceptions
{
    public class InvalidPawnOwnerException : Exception
    {
        public InvalidPawnOwnerException(string message) : base(message) {}
    }
}
