using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue2021
{
    class MyStackIsEmptyException : Exception
    {
        public MyStackIsEmptyException(String message) : base(message)
        {

        }
    }
}
