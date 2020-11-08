using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Basics
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        // member
        public void IntorduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eyecolor is {3}", firstName, lastName, age, eyeColor);
        }
    }
}
