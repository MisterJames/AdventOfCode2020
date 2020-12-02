using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    public class Day02
    {
        // Find the two entries that sum to 2020 and then multiply those two numbers together.

        public string SolvePuzzle(string puzzleData)
        {
            List<string> policies = puzzleData.Split("\n", StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var policy in policies)
            {
                Console.WriteLine(policy);
            }

            return "Not found";
        }
    }
}
