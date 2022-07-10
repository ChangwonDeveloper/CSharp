using System;

namespace EnhacnedIfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // condition ? first_expression : second_expression;
            // condition has to be either true of fasle
            // the condition operator is right - associative
            // The expression a ? b : c? d : e
            // is evaluated as a ? b : (c ? d : e), not as (a? b: c) ? d :e)
            // the conditional operator cannot be overloaded
            int temperature = -5;
            string stateOfMatter;
            if(temperature < 0)
            {
                stateOfMatter = "solid";
            }
            else
            {
                stateOfMatter = "liquid";
            }
            Console.WriteLine("State of the matter is {0}", stateOfMatter);
            temperature += 50;
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of the matter is {0}", stateOfMatter);
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of the matter is {0}", stateOfMatter);
            Console.ReadKey();
        }
    }
}
