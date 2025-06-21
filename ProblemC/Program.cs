using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string? inputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputLine)) break;

            int kaboomCurrent = int.Parse(inputLine);
            if (kaboomCurrent == 0) break;

            int worstCaseTests = CalculateMinTests(kaboomCurrent);
            Console.WriteLine(worstCaseTests);
        }
    }

    static int CalculateMinTests(int kaboomThreshold)
    {
        // The formula for minimum tests with 2 batteries is derived from:
        // k(k+1)/2 ≥ kaboomThreshold
        // Where k is the number of tests

        double quadraticValue = 1 + 8 * kaboomThreshold;
        return (int)Math.Ceiling((-1 + Math.Sqrt(quadraticValue)) / 2);
    }
}
