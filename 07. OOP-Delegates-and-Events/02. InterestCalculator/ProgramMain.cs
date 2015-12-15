using System;

namespace _02.InterestCalculator
{
    class ProgramMain
    {
        private const int N = 12;

        public static void Main()
        {
            var compound = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine(compound);

            var simple = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine(simple);
        }

        private static double GetSimpleInterest(double sum, double interest, int years)
        {
            return sum * (1 + (interest / 100) * years);
        }

        private static double GetCompoundInterest(double sum, double interest, int years)
        {
            return sum * Math.Pow((1 + (interest / 100) / N), N * years);
        }
    }
}
