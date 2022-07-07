using System;

namespace MyExceptionHandling
{
    /*
     * Encapsulate low level exception 
     * To make a user friendly message
     */
    class CustomException : Exception
    {
        public CustomException(string message, Exception innerException = default) : base(message, innerException)
        {

        }
    }
}
