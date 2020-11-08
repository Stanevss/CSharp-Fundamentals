using System;

namespace ConstantsC
{
    // Constants are immutable values wich are know 
    // at compile time and do not change for the life of the program. 
    class Program
    {
        // constans as fields 
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const int days = 365;
        const string birthday = "31.05.1988";
        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is laways going to be: {0}", birthday);
            Console.ReadKey();
        }
    }
}
