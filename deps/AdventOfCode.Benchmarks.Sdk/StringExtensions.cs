namespace AdventOfCode.Benchmarks.Sdk;

internal static class StringExtensions
{
    public static Input ToInput(this string fileName, InputSize inputSize) => new Input(fileName, inputSize);
}
