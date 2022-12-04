using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DayOne;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [ParamsSource(nameof(Data))]
    public IEnumerable<string> CaloriesList { get; set; } = default!;
    
    [Benchmark]
    public ElfCalories FindElfCarryingMostCalories()
    {
        return CaloriesCalculator.FindElfCarryingMostCalories(CaloriesList);
    }
    
    [Benchmark]
    public int CalculateHowManyCaloriesTopThreeElvesCarryingInTotal()
    {
        return CaloriesCalculator.CalculateHowManyCaloriesTopThreeElvesCarryingInTotal(CaloriesList);
    }

    public IEnumerable<IEnumerable<string>> Data => new[]
    {
        File.ReadLines("./input").ToArray(),
        File.ReadLines("./test").ToArray()
    };
}