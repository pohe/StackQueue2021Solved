using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue2021
{
    public class MyQueueLinkedList<T>:IMyQueue<T>
    {
        private LinkedList<T> data;
        public int Size { get;  }

        public MyQueueLinkedList(int size)
        {
            if (size <= 0)
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            Size = size; 
            this.data = new LinkedList<T>();
        }
        public void Enqueue(T item)
        {
            if (Size == data.Count)
                throw new MyQueueIsFullException("The queue is full");
            data.AddFirst(item);
        }

        public T Dequeue()
        {
            if (data.Count == 0)
                throw new MyQueueIsEmptyException("The queue is empty");
            T queueItem = data.Last.Value;
            data.RemoveLast();
            return queueItem;
        }
    }
}
