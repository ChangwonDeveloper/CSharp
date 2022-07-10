using System;

namespace String
{
    internal class Program
    {
        // consts are immutable values which are known
        // at compile time and do not change for the life of the program

        // consts as fields
        const double PI = 3.13159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "1998/09/01";
        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be : {0}", myBirthday);


            string s1 = "Hello";
            string s2 = " world";
            // 1. String concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine(s1 + s2);

            // 2. String formatting
            //string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("{0} {1}", s1, s2);
            
            // 3. String interpoliation
            // string interpolation uses $ at the start which will allow us to write our
            // variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"{s1}{s2}");

            // 4. Verbatim Strings.
            // verbatim strings start with @ and tells the compilkekr to take the string
            // literally and ignore and spaces and escape characters like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"wdkgmaelkgmsaf sefgalsdkgmelskgds a;klmslafg salkf a fgaslgmsdlag'masolkgm
sadlkfgmsdalkfmsdklfmsll lkwmglksdfagmsdagl gsldkgmalsk");

            // intead of using \\ to write file paths we can use verbatim strings to make it easier
            Console.Write("Please enter your name and press enter : ");
            string user_input = Console.ReadLine();
            Console.WriteLine(user_input.ToUpper());
            Console.WriteLine(user_input.ToLower());
            Console.WriteLine(user_input.Trim());
            Console.WriteLine(user_input.Substring(2));

            
            Console.Write("Please enter your name and press enter : ");
            string user_input2 = Console.ReadLine();
            Console.WriteLine(user_input2.IndexOf('g'));
            Console.Write("Please enter your first name : ");
            string user_input3 = Console.ReadLine();
            Console.Write("Please enter your last name : ");
            string user_input4 = Console.ReadLine();
            Console.WriteLine(string.Concat(user_input3, " ", user_input4));

            int intVal = 1;
            double doubleVal = 0.5;
            float floatVal = 0.25f;
            bool boolVal = true;
            char charVal = 'a';
            string text1 = "I control text";
            string text2 = "456";

            Console.WriteLine(intVal);
            Console.WriteLine(doubleVal);
            Console.WriteLine(floatVal);
            Console.WriteLine(charVal);
            Console.WriteLine(text1);
            Console.WriteLine(int.Parse(text2));



        }
    }
}
