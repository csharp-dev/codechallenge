
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Hackerearth;


namespace NUnitTest
{
    [TestFixture]
    class FizzBuzzTest
    {

        [TestCase(
            3,
            ExpectedResult = new String[] { "1", "2", "Fizz" }
            //ExpectedResult = new List<string>(new string[] { "element1", "element2", "element3" })
            )]
        public object validTest_CaseOne(int number)
        {
            FizzBuzz ojb = new FizzBuzz();
            return ojb.printFizzBuzz(number);
        }

        [TestCase(
            15,
            ExpectedResult = new String[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }
            //ExpectedResult = new List<string>(new string[] { "element1", "element2", "element3" })
            )]
        public object validTest_CaseTwo(int number)
        {
            FizzBuzz ojb = new FizzBuzz();
            return ojb.printFizzBuzz(number);
        }

        [TestCase(
            new int[] { 3, 5 }
            //ExpectedResult = new List<string[]>{ new string[] { "element1", "element2", "element3" } }
            )]
        public void makesValidListOfFizzBuzz(int[] number)
        {
            FizzBuzz ojb = new FizzBuzz();
            List<string[]> actual =  ojb.makeAListOfFizzBuzz(number);

            List<string[]> expected = new List<string[]> {
                new string[] { "1", "2", "Fizz" },
                new string[] { "1", "2", "Fizz", "4", "Buzz" }
            };

            Assert.AreEqual(expected, actual);
        }

    }
}
