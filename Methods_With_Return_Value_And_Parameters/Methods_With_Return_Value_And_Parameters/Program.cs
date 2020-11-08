using System;

namespace Methods_With_Return_Value_And_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {

            string friend1 = "Frank";
            string friend2 = "Michael";
            string friend3 = "Wald";

            GreetFriend(friend1);

            GreetFriend(friend2);

            GreetFriend(friend3);
            Console.Read();

            Console.WriteLine(Devide(25,13));
            Console.WriteLine(Multiply(25,25));
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            int result = Add(15, 31);
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(result);
        }

        public static int Add(int num1, int num2)
        {

            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + ", my friend!");
        }

        //public static void GreetFriend(string friendName1, string friendName2, string friendName3 )
        //{
        //    Console.WriteLine("Hi " + friendName1 + ", my friend!");
        //    Console.WriteLine("Hi " + friendName2 + ", my friend!");
        //    Console.WriteLine("Hi " + friendName3 + ", my friend!");
        //}
    }
}
