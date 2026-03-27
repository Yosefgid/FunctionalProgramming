using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public static class Exercises001
    {

        //Delegate Type function
        //Takes an int and returns an int 
        //delegates are reference types that hold reference methods with compatible signatures(<>)
        //Allows us to pass methods as arguments to other methods
        //
        public static Func<int, int> SquareIt = num => num * num;
        public static Func<int, int> AddTen = num => num + 10;
        // now we move to the Predicate Type delegate Type
        public static Predicate<string> GrammarCheck = 
            str => str.Length > 0 && str[0] == 'A' && str[^1] == '!';
        //You can also use str.StartWith() and .EndWith() methods
        public static Func<string, string, int> SumIndices =
            (str1, str2) => str1.IndexOf('a') + str2.IndexOf('e');


        public static Predicate<string> IsValidDomain =
            email => email.EndsWith("@northcoders.co.uk");
        public static Predicate<string> IsValidUserName =
            email => email.Split('@')[0].Length >= 5;
        public const string ifValid =
            "Email domain and user valid, please continue";
        public const string ifnotValid =
            "Email domain and user name invalid, please check your input";

        public static string CheckValidEmail(string email)
        {
            bool isValidDomain = IsValidDomain(email);
            bool isValidUserName = IsValidUserName(email);

            if(isValidDomain && isValidUserName)
            {
                return ifValid;
            }
            return ifnotValid;
        }
    }

}
