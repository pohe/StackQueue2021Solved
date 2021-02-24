using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue2021
{
    public class MyStackArray<T>: IMyStack<T>
    {
        private T[] stack;
        public int Size { get; }
        private int top = 0;

        public MyStackArray(int size)
        {
            stack = new T[size];
            this.Size = size;
        }
        public void Push(T element)
        {
            if (top == Size) throw new MyStackIsFullException("The stack is full!");
            stack[top] = element;
            top++;
        }

        public T Pop()
        {
            if (top == 0) throw new MyStackIsEmptyException("The stack is empty!");
            return stack[--top];
        }

        public T Peek()
        {
            if (top == 0) throw new MyStackIsEmptyException("The stack is empty!");
            int last =top; 
            return stack[--last];
        }
    }
}
