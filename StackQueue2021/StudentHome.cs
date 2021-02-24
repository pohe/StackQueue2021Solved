using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue2021
{
    class StudentHome: Person
    {
        public int ParentIncome { get; set; }

        public StudentHome(int parentIncome, string name, int age) : base(name, age)
        {
            ParentIncome = parentIncome; 
        }
        public override int CalculateSUprMonth()
        {
            if (Age < 20)
                return 3143;
            else if (ParentIncome > 600000)
                return 1013;
            else 
            {
                return 2725;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" parentOutcome {ParentIncome} Su pr month {CalculateSUprMonth()} kr.";
        }
    }
}
