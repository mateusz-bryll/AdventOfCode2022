using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DayOne;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [Benchmark]
    public object FindElfCarryingMostCalories_TestData()
    {
        return CaloriesCalculator.FindElfCarryingMostCalories("./test");
    }
    
    [Benchmark]
    public object CalculateHowManyCaloriesTopThreeElvesCarryingInTotal_TestData()
    {
        return CaloriesCalculator.CalculateHowManyCaloriesTopThreeElvesCarryingInTotal("./test");
    }
    
    [Benchmark]
    public object FindElfCarryingMostCalories_RealData()
    {
        return CaloriesCalculator.FindElfCarryingMostCalories("./input");
    }
    
    [Benchmark]
    public object CalculateHowManyCaloriesTopThreeElvesCarryingInTotal_RealData()
    {
        return CaloriesCalculator.CalculateHowManyCaloriesTopThreeElvesCarryingInTotal("./input");
    }
}