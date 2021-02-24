using System;
using System.Runtime.Serialization;

namespace StackQueue2021
{
    [Serializable]
    internal class MyQueueIsEmptyException : Exception
    {
        public MyQueueIsEmptyException()
        {
        }

        public MyQueueIsEmptyException(string message) : base(message)
        {
        }

       
    }
}