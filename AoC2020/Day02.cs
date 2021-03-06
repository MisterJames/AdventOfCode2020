﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC2020
{
    public class Day02
    {
        // find the passwords that match the policy on the given line
        // 1-3 a: abcde             valid
        // 1-3 b: cdefg             invalid
        // 2-9 c: ccccccccc         valid

        public string SolvePuzzle(string puzzleData)
        {
            List<string> policies = puzzleData.Split("\n", StringSplitOptions.RemoveEmptyEntries).ToList();

            var validCount = 0;

            foreach (var policy in policies)
            {
                (string minmax, string character, string password) evaluation = Deconstruct(policy.Split(" "));
                validCount += IsValid(evaluation.minmax, evaluation.character, evaluation.password) ? 1 : 0;
            }

            return $"There were {validCount} passwords following the rules.";
        }

        public bool IsValid (string minmax, string character, string password)
        {
            (int min, int max) range = BuildRange(minmax.Split("-"));
            var theChar = character.Replace(":","");

            var count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == theChar[0])
                {
                    count++;
                }
            }

            return range.min <= count && count <= range.max;
        }

        public static (int min, int max) BuildRange(string[] list)
        {

            return (min: int.Parse(list[0]), max: int.Parse(list[1]));

        }


        public static (string minmax, string character, string password) Deconstruct(string[] list)
        {

            return (minmax : list[0], character: list[1], password: list[2]);

        }
    }
}
