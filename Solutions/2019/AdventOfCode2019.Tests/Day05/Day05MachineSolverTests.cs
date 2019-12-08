using System.Linq;
using AdventOfCode2019.Day05;
using Xunit;

namespace AdventOfCode2019.Tests.Day05
{
    public class Day05MachineSolverTests
    {
        private readonly Day05MachineSolver subject = new Day05MachineSolver();

        [Theory]
        [InlineData(1, 8, 3, 9, 8, 9, 10, 9, 4, 9, 99, -1, 8)]
        [InlineData(0, 9, 3, 9, 8, 9, 10, 9, 4, 9, 99, -1, 8)]
        [InlineData(1, 7, 3, 9, 7, 9, 10, 9, 4, 9, 99, -1, 8)]
        [InlineData(0, 8, 3, 9, 7, 9, 10, 9, 4, 9, 99, -1, 8)]
        [InlineData(1, 8, 3, 3, 1108, -1, 8, 3, 4, 3, 99)]
        [InlineData(0, 9, 3, 3, 1108, -1, 8, 3, 4, 3, 99)]
        [InlineData(1, 7, 3, 3, 1107, -1, 8, 3, 4, 3, 99)]
        [InlineData(0, 8, 3, 3, 1107, -1, 8, 3, 4, 3, 99)]
        [InlineData(0, 0, 3, 12, 6, 12, 15, 1, 13, 14, 13, 4, 13, 99, -1, 0, 1, 9)]
        [InlineData(1, 8, 3, 12, 6, 12, 15, 1, 13, 14, 13, 4, 13, 99, -1, 0, 1, 9)]
        [InlineData(0, 0, 3, 3, 1105, -1, 9, 1101, 0, 0, 12, 4, 12, 99, 1)]
        [InlineData(1, 8, 3, 3, 1105, -1, 9, 1101, 0, 0, 12, 4, 12, 99, 1)]
        [InlineData(999, 7, 3, 21, 1008, 21, 8, 20, 1005, 20, 22, 107, 8, 21, 20, 1006, 20, 31, 1106, 0, 36, 98, 0, 0, 1002, 21, 125, 20, 4, 20, 1105, 1, 46, 104, 999, 1105, 1, 46, 1101, 1000, 1, 20, 4, 20, 1105, 1, 46, 98, 99)]
        [InlineData(1000, 8, 3, 21, 1008, 21, 8, 20, 1005, 20, 22, 107, 8, 21, 20, 1006, 20, 31, 1106, 0, 36, 98, 0, 0, 1002, 21, 125, 20, 4, 20, 1105, 1, 46, 104, 999, 1105, 1, 46, 1101, 1000, 1, 20, 4, 20, 1105, 1, 46, 98, 99)]
        [InlineData(1001, 9, 3, 21, 1008, 21, 8, 20, 1005, 20, 22, 107, 8, 21, 20, 1006, 20, 31, 1106, 0, 36, 98, 0, 0, 1002, 21, 125, 20, 4, 20, 1105, 1, 46, 104, 999, 1105, 1, 46, 1101, 1000, 1, 20, 4, 20, 1105, 1, 46, 98, 99)]
        public void PuzzleTwo(int expected, int systemId, params int[] input)
        {
            var actual = this.subject.PuzzleTwo(input, systemId).First();

            Assert.Equal(expected, actual);
        }

    }
}