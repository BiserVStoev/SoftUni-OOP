using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            long num = long.Parse(Console.ReadLine());
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("Number cannot be negative!");
            }

            if (num > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Number cannot be larger than 2147483647");
            }

            Console.WriteLine("Square root of {0} is {1}", num, Math.Sqrt(num));
  
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid input!");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("Invalid number!" + " " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

