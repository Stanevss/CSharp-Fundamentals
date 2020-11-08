using System;

namespace Classes_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Create an object of my class
            //// an instance of Human
            //Human denis = new Human();
            //// access public variable from outside, and even change it
            //denis.firstName = "Denis";
            //// call methods of the class
            //denis.IntorduceMyself();
            //Human michael = new Human();
            //michael.IntorduceMyself();

            //Human sissy = new Human();
            //sissy.firstName = "Sissy";
            //sissy.lastName = "Wagner";
            //sissy.IntorduceMyself();

            //Human franzl = new Human();
            //franzl.firstName = "Franzl";
            //franzl.lastName = "Mueller";
            //franzl.IntorduceMyself();

            //Human sissy = new Human("Sissy", "Wagner");
            //sissy.IntorduceMyself();

            Human john = new Human("John", "Doe", "green", 29);
            john.IntorduceMyself();

            Console.ReadKey();
        }
    }
}
