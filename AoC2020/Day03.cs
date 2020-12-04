using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoC2020
{
    public class Day03
    {
        // count the trees encountered by a 3right 1down slope

        public string SolvePuzzle(string puzzleData)
        {
            var treeCount = 0;
            var treeLines = puzzleData.Split("\n", StringSplitOptions.RemoveEmptyEntries).ToList();
            var patternWidth = treeLines[0].Length;

            var down = 1;
            var right = 3;

            (int x, int y) curPos = (0, 0);

            // I don't need both a down and an i but i like it and it'll be my Christmas present to myself
            for (int i = 0; i < treeLines.Count; i+=down)
            {
                if (treeLines[curPos.y][curPos.x] == "#"[0])
                {
                    treeCount++;
                }

                curPos.y += down;
                curPos.x += right;
                curPos.x %= patternWidth;

            }

            return $"There were {treeCount} trees encountered";            
        }

    }
}
