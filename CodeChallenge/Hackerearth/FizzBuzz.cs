using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerearth.FizzBuzzN
{
    public interface IConsole
    {
        string readLine();
    }

    public class ConsoleImpl : IConsole
    {
        public string readLine()
        {
            return Console.ReadLine();
        }
    }

    public class FizzBuzz
    {
        public void solution() {
            try {
                ConsoleImpl console = new ConsoleImpl();
                int numbers = readNumberFromConsole(console);
                int[] intArr = convertSpaceSepratedString(numbers);

                List<string[]> fizzBuzzStringList = makeAListOfFizzBuzz(intArr);
                printFizzBuzzList(numbers, fizzBuzzStringList);


            } catch (FormatException e) {

                Console.WriteLine($"Unable to parse '{e.Message}'");
            }
        }

        private void printFizzBuzzList(int numbers, List<string[]> fizzBuzzStringList) {
            for (int i = 0; i < numbers; i++) {
                for (int j = 0; j < fizzBuzzStringList[i].Length; j++) {
                    Console.WriteLine(fizzBuzzStringList[i][j]);
                }
            }
        }
           
        public List<string[]> makeAListOfFizzBuzz(int[] fizzBuzzNumbers) {
            List<string[]> listOfString = new List<string[]>();

            for (int i = 0; i < fizzBuzzNumbers.Length; i++)
                listOfString.Add(makeStringArrOfFizzBuzzOrInt(fizzBuzzNumbers[i]));

            return listOfString;
        }

        public String[] makeStringArrOfFizzBuzzOrInt(int number) {
            String[] listOfString = new String[number];

            for (int i = 1; i <= number; i++) {

                if (isDivisibleByThreeAndFive(i))
                    listOfString[i - 1] =  "FizzBuzz";

                else if (isDivisibleByThree(i))
                    listOfString[i - 1] = "Fizz";

                else if (isDivisibleByFive(i))
                    listOfString[i - 1] = "Buzz";

                else
                    listOfString[i - 1] = i.ToString();
            }

            return listOfString;
        }

        private bool isDivisibleByThreeAndFive(int number) {
            if (number % 3 == 0 && number % 5 == 0)
                return true;
            return false;
        }

        private bool isDivisibleByThree(int number) {
            if ( number % 3 == 0 )
                return true;
            return false;
        }

        private bool isDivisibleByFive(int number) {
            if (number % 5 == 0)
                return true;
            return false;
        }

        public int[] convertSpaceSepratedString(int numberOfInt)
        {
            int[] numbers = new int[numberOfInt];
            String strOfSpaceSepNums = Console.ReadLine();

            numbers = strOfSpaceSepNums.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            return numbers;
        }

        public int[] convertASingleInputWord(int numberOfInt, IConsole console)
        {
            int[] numbers = new int[numberOfInt];
            int count = 0;

            while (numberOfInt > 0)
            {
                int num = readNumberFromConsole(console);
                numbers[count] = num;
                count++;
                numberOfInt--;
            }

            return numbers;
        }

        public int readNumberFromConsole(IConsole console) {
            return int.Parse(console.readLine());
        }

        int[] reverseIntArr(int[] originalArr)
        {
            int lenOfOrgArr = originalArr.Length;
            int[] reversedArr = new int[lenOfOrgArr];
            int index = lenOfOrgArr - 1;

            for (int i = 0; i <= index; i++)
                reversedArr[i] = originalArr[--lenOfOrgArr];

            return reversedArr;
        }

    }
}
