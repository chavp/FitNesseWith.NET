using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzTest.BusinessModels
{
    /// <summary>
    /// http://en.wikipedia.org/wiki/Fizz_buzz
    /// </summary>
    public class FizzBuzzGame
    {
        public string Say(int number)
        {
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }
    }
}
