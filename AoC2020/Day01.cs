using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    public class Day01
    {
        // Find the two entries that sum to 2020 and then multiply those two numbers together.

        public string SolvePuzzle(string puzzleData)
        {
            List<int> expenses = puzzleData.Split("\n", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(s => int.Parse(s)).ToList();

            foreach (var expense in expenses)
            {
                var otherExpense = 2020 - expense;
                if(expenses.Contains(otherExpense))
                {
                    // we have a match
                    return $"The answer is {expense * otherExpense} ({expense} * {otherExpense})";
                }
            }

            return "Not found";
        }
    }
}
