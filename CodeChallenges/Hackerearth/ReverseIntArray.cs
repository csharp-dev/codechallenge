using System.Runtime.CompilerServices;
using System;

/**
 * Problem: hackerearth.com/practice/data-structures/arrays/1-d
 * 
 * 
 */
namespace Hackerearth
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

    public interface IReverse
    {
        int readNumberFromConsole(IConsole consoleReader);
    }


    public class ReverseIntArray : IReverse
    {
        public void solution() {
        
            try {
                ConsoleImpl console = new ConsoleImpl();
                int numbers = readNumberFromConsole(console);
                int[] intArr = readInts(numbers, console);
                int[] revArr = reversedIntArr(intArr);
                for (int i = 0; i < revArr.Length; i++)
                    Console.WriteLine(revArr[i]);
                
            } catch (FormatException e) {

                Console.WriteLine($"Unable to parse '{e.Message}'");
            }
        }

        public int[] readInts(int numberOfInt, IConsole console) {
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

        int[] reversedIntArr(int[] originalArr) {
            int lenOfOrgArr = originalArr.Length;
            int[] reversedArr = new int[lenOfOrgArr];
            int index = lenOfOrgArr - 1;

            for ( int i = 0; i <= index; i++ )
                reversedArr[i] = originalArr[--lenOfOrgArr];
            
            return reversedArr;
        }

        public int readNumberFromConsole(IConsole console) {
            return int.Parse(console.readLine());
        }


    }
}
