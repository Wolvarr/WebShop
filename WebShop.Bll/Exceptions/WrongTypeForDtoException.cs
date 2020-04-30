using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Bll.Exceptions
{
    public class WrongTypeForDtoException : Exception
    {
        public WrongTypeForDtoException()
        {
        }

        public WrongTypeForDtoException(string message)
            : base(message)
        {
        }

        public WrongTypeForDtoException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
