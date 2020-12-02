using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    public class Day01b
    {
        // Find the two entries that sum to 2020 and then multiply those two numbers together.

        public string SolvePuzzle(string puzzleData)
        {
            List<int> expenses = puzzleData.Split("\n", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(s => int.Parse(s)).ToList();

            foreach (var expense in expenses)
            {
                var balance = 2020 - expense;
                // 1200
                var eligibleExpenses = expenses.Where(e => e < balance);

                foreach (var secondExpense in eligibleExpenses)
                {
                    var remaining = balance - secondExpense;
                    if (expenses.Contains(remaining))
                    {
                        // we have a match
                        return $"The answer is {expense * secondExpense * remaining} ({expense} * {secondExpense} * {remaining})";
                    }
                }

            }

            return "Not found";
        }
    }
}
