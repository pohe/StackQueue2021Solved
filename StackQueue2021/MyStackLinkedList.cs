using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue2021
{
    public class MyStackLinkedList<T>: IMyStack<T>
    {
        public int Size { get; set; }
        private LinkedList<T> myList; 
        public MyStackLinkedList(int size)
        {
            Size = size; 
            myList = new LinkedList<T>(); 
        }
        public void Push(T element)
        {
            if (myList.Count == Size) throw new MyStackIsFullException("The stack is full!");
            myList.AddLast(element);
        }

        public T Pop()
        {
            if (myList.Count == 0) throw new MyStackIsEmptyException("The stack is empty!");
            T returnNode = myList.Last.Value;
            myList.RemoveLast();
            return returnNode;
        }

        public T Peek()
        {
            if (myList.Count == 0) throw new MyStackIsEmptyException("The stack is empty!");
            return myList.Last.Value;
        }
    }
}
