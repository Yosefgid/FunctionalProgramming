using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public static class Exercises001
    {

        //Delegate Type function
        //Takes an int and returns an int 
        //delegates are refernce types that hold refernce methods with compatible signatures(<>)
        //Allows us to pass methods as arguments to other methods
        //
        public static Func<int, int> SquareIt = num => num * num;
    }
}
