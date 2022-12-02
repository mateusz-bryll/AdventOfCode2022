using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DayTwo;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [Benchmark]
    public int CalculateTotalScoreForStrategy_TestData()
    {
        return RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForStrategy("./test");
    }
    
    [Benchmark]
    public int CalculateTotalScoreForResultStrategy_TestData()
    {
        return RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForResultStrategy("./test");
    }
    
    [Benchmark]
    public int CalculateTotalScoreForStrategy_RealData()
    {
        return RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForStrategy("./input");
    }
    
    [Benchmark]
    public int CalculateTotalScoreForResultStrategy_RealData()
    {
        return RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForResultStrategy("./input");
    }
}
