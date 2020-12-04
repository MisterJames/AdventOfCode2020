using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoC2020
{
    public class Day03b
    {
        // count the trees encountered by a 3right 1down slope

        public string SolvePuzzle(string puzzleData)
        {
            var treeLines = puzzleData.Split("\n", StringSplitOptions.RemoveEmptyEntries).ToList();
            var patternWidth = treeLines[0].Length;

            var slopes = new List<(int, int)>();
            slopes.Add((1, 1));
            slopes.Add((1, 3));
            slopes.Add((1, 5));
            slopes.Add((1, 7));
            slopes.Add((2, 1));

            var results = new List<int>();

            foreach (var slope in slopes)
            {
                results.Add(GetHitCount(treeLines, patternWidth, slope.Item1, slope.Item2));
            }

            var treeCount = results.Aggregate((x, y) => x * y);

            return $"There was a result of {treeCount}";
        }

        private static int GetHitCount(List<string> treeLines, int patternWidth, int down, int right)
        {
            var treeCount = 0;
            (int x, int y) = (0, 0);

            // I don't need both a down and an i but i like it and it'll be my Christmas present to myself
            for (int i = 0; i < treeLines.Count; i += down)
            {
                if (treeLines[y][x] == "#"[0])
                {
                    treeCount++;
                }

                y += down;
                x += right;

                // correct for bounds
                if (x >= patternWidth)
                {
                    x -= patternWidth;
                }

            }

            return treeCount;
        }
    }
}
