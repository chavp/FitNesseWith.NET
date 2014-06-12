using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzTest
{
    using fit;

    public class FizzBuzzColumnFixture : ColumnFixture
    {
        // source -> http://en.wikipedia.org/wiki/Fizz_buzz

        public int Number { get; set; }

        public string FizzBuzzSay()
        {
            if (Number % 3 == 0) return "Fizz";
            if (Number % 5 == 0) return "Buzz";
            return Number.ToString();
        }
    }
}
