using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int[]> monthlyData = new Dictionary<string, int[]>()
        {
            { "January",  new int[] { 1, 2, 4, 4, 5, 1, 5 } },
            { "February", new int[] { 1, 5, 4 } },
            { "March",    new int[] { 1, 3, 5, 4, 5, 2, 4, 5 } },
            { "April",    new int[] { 5, 1, 2, 4, 5 } },
            { "May",      new int[] { 1 } },
            { "June",     new int[] { 5, 4, 4, 3 } }
        };

        foreach (var month in monthlyData)
        {
            Console.WriteLine($"Month of {month.Key}:");
            foreach (var code in month.Value)
            {
                Console.WriteLine($"Enter transportation code: {code}");
            }
        }

        foreach (var month in monthlyData)
        {
            Console.Write($"{month.Key,-10}");
            foreach (var code in month.Value)
            {
                Console.Write($"  {code}");
            }
            Console.WriteLine();
        }
    }
}