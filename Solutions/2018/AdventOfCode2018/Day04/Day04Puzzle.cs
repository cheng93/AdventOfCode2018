namespace AdventOfCode2018.Day04
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AdventOfCode.Abstractions;

    public class Day04Puzzle : Puzzle
    {
        public async override Task<string> PuzzleOne()
        {
            var resource = "AdventOfCode2018.Day04.PuzzleOne.txt";

            var input = await this.GetInput(resource);

            return new Day04Solver().PuzzleOne(input).ToString();
        }

        public async override Task<string> PuzzleTwo()
        {
            var resource = "AdventOfCode2018.Day04.PuzzleOne.txt";

            var input = await this.GetInput(resource);

            return new Day04Solver().PuzzleTwo(input).ToString();
        }

        private async Task<IEnumerable<string>> GetInput(string resource)
        {
            return (await this.ReadResource(resource))
                .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}