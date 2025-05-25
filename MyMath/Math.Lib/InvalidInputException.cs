using System;

namespace Math.Lib
{
    public class InvalidInputException : ArgumentException
    {
        public InvalidInputException(string message) : base(message) { }
    }
}
