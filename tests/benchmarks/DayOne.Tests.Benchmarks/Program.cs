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
    public object CalculateHowManyCaloriesTopThreeElfsCarryingInTotal_TestData()
    {
        return CaloriesCalculator.CalculateHowManyCaloriesTopThreeElfsCarryingInTotal("./test");
    }
    
    [Benchmark]
    public object FindElfCarryingMostCalories_RealData()
    {
        return CaloriesCalculator.FindElfCarryingMostCalories("./input");
    }
    
    [Benchmark]
    public object CalculateHowManyCaloriesTopThreeElfsCarryingInTotal_RealData()
    {
        return CaloriesCalculator.CalculateHowManyCaloriesTopThreeElfsCarryingInTotal("./input");
    }
}