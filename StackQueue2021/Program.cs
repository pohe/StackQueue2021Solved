using System;

namespace StackQueue2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Person sh1 = new StudentHome(450000, "Aksel", 22);
            Person sh2 = new StudentHome(600000, "Israa", 18);
            Person sh3 = new StudentHome(500000, "Katrine", 21);
            Person so1 = new StudentOut( "Mikkel", 22);
            Person so2 = new StudentOut("Mikael", 18);
            Person so3 = new StudentOut( "Rasmus", 21);

            MyStackArray<Person> myStack = new MyStackArray<Person>(5);
            //MyStackLinkedList<Person> myStack = new MyStackLinkedList<Person>(5);
            try
            {
                Console.WriteLine($"Push {sh1}");
                myStack.Push(sh1);
                Console.WriteLine($"Push {sh2}"); 
                myStack.Push(sh2);
                Console.WriteLine($"Push {sh3}"); 
                myStack.Push(sh3);
                Console.WriteLine($"Push {so1}");
                myStack.Push(so1);
                Console.WriteLine($"Push {so2}");
                myStack.Push(so2);
                Console.WriteLine($"Push {so3}");
                myStack.Push(so3);
            }
            catch (MyStackIsFullException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                Console.WriteLine($"Peek {myStack.Peek()} ");
                Console.WriteLine(myStack.Pop());
                Console.WriteLine(myStack.Pop());
                Console.WriteLine(myStack.Pop());
                Console.WriteLine(myStack.Pop());
                Console.WriteLine(myStack.Pop());
                Console.WriteLine(myStack.Pop());
            }
            catch (MyStackIsEmptyException e)
            {
                Console.WriteLine(e);
            }



            MyQueueArray<Person> myQueue = new MyQueueArray<Person>(5);
            //MyQueueLinkedList<Person> myQueue = new MyQueueLinkedList<Person>(5);
            try
            {
                Console.WriteLine($"Enqueue {sh1}");
                myQueue.Enqueue(sh1);
                Console.WriteLine($"Enqueue {sh2}"); 
                myQueue.Enqueue(sh2);
                Console.WriteLine($"Enqueue {sh3}");
                myQueue.Enqueue(sh3);
                Console.WriteLine($"Enqueue {so1}");
                myQueue.Enqueue(so1);
                Console.WriteLine($"Enqueue {so2}");
                myQueue.Enqueue(so2);
                Console.WriteLine($"Enqueue {so3}");
                myQueue.Enqueue(so3);
            }
            catch (MyQueueIsFullException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine(myQueue.Dequeue());
            }
            catch (MyQueueIsEmptyException e)
            {
                Console.WriteLine(e);
            }





            Console.ReadLine();
        }
    }
}
