using System;
using System.Collections.Generic;

class EnterNumbers
{
    private static int startNumber = 10;
    private const int endNumber = 100;
    private static List<int> numbers;
    private static int numbersLeft  = 10;

    static void Main()
    {
        numbers = new List<int>();

        Console.WriteLine("You must enter 10 numbers!");

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(ReadNumber(startNumber, endNumber));
        }

        string output = "The entered numbers are: ";

        foreach (var num in numbers)
        {
            output += num + " ";
        }

        Console.WriteLine(output.Substring(0, output.Length - 1));
    }

    public static int ReadNumber(int startNum, int endNum)
    {
        Console.Write("Input a number in the range [{0}...{1}] and below {2}(in order to avoid an infinite loop)!: ", startNum, endNum, endNum - numbersLeft + 1);
        while (true)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num <= startNum || num >= endNum || endNum - numbersLeft + 1 <= num)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("The number must be in the range [{0}...{1}] and below {2}(because otherwise the program will be unable to end)!", startNum, endNum,
                            endNum - numbersLeft + 1));
                }

                startNumber = num;
                numbersLeft--;
                Console.WriteLine("{{{0}}} Succesfully added", 10 - numbersLeft);
                return num;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.Write("Invalid input! {0} Please try again: ", ex.Message);
            }

            catch (FormatException)
            {
                Console.Error.Write("Invalid input! You must enter a number: ");
            }
            catch (OverflowException)
            {
                Console.Error.Write("The number is big to fit in 32 bit integer. Please try again: ");
            }
        }
    }
}