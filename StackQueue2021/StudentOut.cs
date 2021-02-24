using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue2021
{
    class StudentOut : Person
    {
        public StudentOut(string name, int age) : base(name, age)
        {
        }
        public override int CalculateSUprMonth()
        {
            if (Age < 18)
                return 4055;
            else
            {
                return 6321;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" SU pr month {CalculateSUprMonth()} kr.";
        }

    }
}
