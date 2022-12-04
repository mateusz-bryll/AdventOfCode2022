using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DayTwo;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [ParamsSource(nameof(Data))]
    public IEnumerable<string> StrategyMoves { get; set; } = default!;
    
    [Benchmark]
    public int CalculateTotalScoreForStrategy()
    {
        return RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForStrategy(StrategyMoves);
    }
    
    [Benchmark]
    public int CalculateTotalScoreForResultStrategy()
    {
        return RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForResultStrategy(StrategyMoves);
    }
    
    public IEnumerable<IEnumerable<string>> Data => new[]
    {
        File.ReadLines("./day-02.inputdata").ToArray(),
        File.ReadLines("./day-02.testdata").ToArray()
    };
}
