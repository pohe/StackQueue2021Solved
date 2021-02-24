using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace StackQueue2021
{
    abstract class Person :IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static int _counter =0;
        public int Age { get; set; }
        public abstract int CalculateSUprMonth();

        public Person(string name, int age)
        {
            Id = _counter++;
            Name = name;
            Age = age; 
        }

         

        

        public override string ToString()
        {
            return string.Format($"Id: {Id}, Name: {Name} Age: {Age}");
        }
    }

    
}
