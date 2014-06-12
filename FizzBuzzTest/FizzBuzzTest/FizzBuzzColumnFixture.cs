using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzTest
{
    using fit;
using FizzBuzzTest.BusinessModels;

    public class FizzBuzzColumnFixture : ColumnFixture
    {
        FizzBuzzGame _fizzBuzzGameUT = null;

        public FizzBuzzColumnFixture()
        {
            _fizzBuzzGameUT = new FizzBuzzGame();
        }

        public int Number { get; set; }

        public string FizzBuzzSay()
        {
            return _fizzBuzzGameUT.Say(Number);
        }
    }
}
