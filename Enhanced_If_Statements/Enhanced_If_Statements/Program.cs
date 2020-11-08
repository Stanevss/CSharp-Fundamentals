using System;

namespace Enhanced_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // in celcius 
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0) 
                stateOfMatter = "solid";
            else 
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 30;

            // in short
            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            // challenge - add the gas state of matter to the options
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.ReadKey();
        }
    }
}
