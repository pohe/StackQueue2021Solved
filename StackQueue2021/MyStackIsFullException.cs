using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue2021
{
    public class MyStackIsFullException : Exception
    {
        public MyStackIsFullException(string message) : base(message)
        {

        }
    }
}
