using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue2021
{
    public class MyQueueArray<T> : IMyQueue<T>
    {
        private const int DEFAULTSIZE = 10;
        private T[] data;
        private int _top = 0;
        private int _buttom = 0;
        private int _numItems = 0;

        public MyQueueArray()
        {
            data = new T[DEFAULTSIZE];
        }

        public MyQueueArray(int size)
        {
            if (size <= 0)
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            data = new T[size];
        }

        public void Enqueue(T item)
        {
            if (_numItems == data.Length)
                throw new MyQueueIsFullException("The queue is full");
            data[_buttom++] = item;
            _buttom %= data.Length;
            _numItems++;
        }

        public T Dequeue()
        {
            if (_numItems == 0)
                throw new MyQueueIsEmptyException("The queue is empty");
            T queueItem = data[_top++];
            _top %= data.Length;
            _numItems--;
            return queueItem;
        }
    }
}
