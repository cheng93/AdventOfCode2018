﻿using System;
using AdventOfCode.Abstractions;
using AdventOfCode2020.Day01;
using AdventOfCode2020.Day02;
using AdventOfCode2020.Day03;
using AdventOfCode2020.Day04;
using AdventOfCode2020.Day05;

namespace AdventOfCode2020
{
    public class Year2020PuzzleFactory : IPuzzleFactory
    {
        public IPuzzle Create(int day)
            => day switch
            {
                1 => new Day01Puzzle(),
                2 => new Day02Puzzle(),
                3 => new Day03Puzzle(),
                4 => new Day04Puzzle(),
                5 => new Day05Puzzle(),
                _ => throw new ArgumentException(nameof(day))
            };
    }
}
