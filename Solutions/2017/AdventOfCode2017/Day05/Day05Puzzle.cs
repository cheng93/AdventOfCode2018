namespace AdventOfCode2017.Day05
{
    using System.Threading.Tasks;
    using AdventOfCode.Abstractions;

    public class Day05Puzzle : Puzzle
    {
        public async override Task<string> PuzzleOne()
        {
            var resource = "AdventOfCode2017.Day05.Input.txt";

            var input = await this.ReadResource(resource);

            return new Day05Solver().PuzzleOne(input).ToString();
        }

        public async override Task<string> PuzzleTwo()
        {
            var resource = "AdventOfCode2017.Day05.Input.txt";

            var input = await this.ReadResource(resource);

            return new Day05Solver().PuzzleTwo(input).ToString();
        }
    }
}