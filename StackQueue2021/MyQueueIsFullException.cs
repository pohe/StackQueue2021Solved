using System;
using System.Runtime.Serialization;

namespace StackQueue2021
{
    [Serializable]
    internal class MyQueueIsFullException : Exception
    {
        public MyQueueIsFullException()
        {
        }

        public MyQueueIsFullException(string message) : base(message)
        {
        }

        
    }
}