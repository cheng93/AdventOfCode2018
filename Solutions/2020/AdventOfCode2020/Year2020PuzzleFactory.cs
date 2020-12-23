﻿using System;
using AdventOfCode.Abstractions;
using AdventOfCode2020.Day01;
using AdventOfCode2020.Day02;
using AdventOfCode2020.Day03;
using AdventOfCode2020.Day04;
using AdventOfCode2020.Day05;
using AdventOfCode2020.Day06;
using AdventOfCode2020.Day07;
using AdventOfCode2020.Day08;
using AdventOfCode2020.Day09;
using AdventOfCode2020.Day10;
using AdventOfCode2020.Day11;
using AdventOfCode2020.Day12;
using AdventOfCode2020.Day13;
using AdventOfCode2020.Day14;
using AdventOfCode2020.Day15;
using AdventOfCode2020.Day16;
using AdventOfCode2020.Day17;
using AdventOfCode2020.Day18;
using AdventOfCode2020.Day19;
using AdventOfCode2020.Day20;
using AdventOfCode2020.Day21;
using AdventOfCode2020.Day22;
using AdventOfCode2020.Day23;

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
                6 => new Day06Puzzle(),
                7 => new Day07Puzzle(),
                8 => new Day08Puzzle(),
                9 => new Day09Puzzle(),
                10 => new Day10Puzzle(),
                11 => new Day11Puzzle(),
                12 => new Day12Puzzle(),
                13 => new Day13Puzzle(),
                14 => new Day14Puzzle(),
                15 => new Day15Puzzle(),
                16 => new Day16Puzzle(),
                17 => new Day17Puzzle(),
                18 => new Day18Puzzle(),
                19 => new Day19Puzzle(),
                20 => new Day20Puzzle(),
                21 => new Day21Puzzle(),
                22 => new Day22Puzzle(),
                23 => new Day23Puzzle(),
                _ => throw new ArgumentException(nameof(day))
            };
    }
}
