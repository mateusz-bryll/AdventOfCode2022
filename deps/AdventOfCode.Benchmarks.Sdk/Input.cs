using System.Text;

namespace AdventOfCode.Benchmarks.Sdk;

internal class Input : List<string>
{
    private readonly InputSize inputSize;

    public Input(string inputFileName, InputSize inputSize)
        : base(File.ReadLines(Path.Combine(AppContext.BaseDirectory, inputFileName), Encoding.UTF8))
    {
        this.inputSize = inputSize;
    }

    public override string ToString()
    {
        var n = inputSize switch
        {
            InputSize.FileLines => Count,
            InputSize.AverageLineLength => this.Average(line => line.Length),
            _ => throw new ArgumentOutOfRangeException()
        };

        return $"N={n:0.00}";
    }
}
