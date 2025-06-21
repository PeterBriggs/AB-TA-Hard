using System;

class Program
{
    static void Main()
    {
        // Read input until we encounter 0
        while (true)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            int x = int.Parse(input);
            if (x == 0) break;

            Console.WriteLine(x);
        }
    }

}
