using System;
using System.Collections.Generic;

/*
 * Battery Explosion Problem
 * Find minimum tests needed to determine maximum safe current with two batteries
 */
public class Program
{
    public static void Main()
    {

        List<int> results = new List<int>();

        while (true)
        {
            string? inputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputLine)) break;

            int kaboomCurrent = int.Parse(inputLine);
            if (kaboomCurrent == 0) break;

            int worstCaseTests = CalculateMinTests(kaboomCurrent);
            results.Add(worstCaseTests);
        }

        foreach (int result in results)
        {
            Console.WriteLine(result);
        }
    }

    /*
     * Calculates the minimum number of tests needed to find the maximum safe current.
     * Uses the solution to the classic egg drop problem.
     *
     * @param kaboomThreshold - The current level (mA) at which the battery is known to explode
     * @return The minimum number of tests required in the worst case
     */
    public static int CalculateMinTests(int kaboomThreshold)
    {
        /*
        * The formula for minimum tests with 2 batteries is derived from:
        * k(k+1)/2 ≥ kaboomThreshold
        * Where k is the number of tests.
        */

        double quadraticValue = 1 + 8 * kaboomThreshold;
        return (int)Math.Ceiling((-1 + Math.Sqrt(quadraticValue)) / 2);
    }
}
