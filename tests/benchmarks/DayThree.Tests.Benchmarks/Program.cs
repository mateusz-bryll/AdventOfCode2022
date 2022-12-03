using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DayThree.Domain;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [ParamsSource(nameof(Data))]
    public IEnumerable<string> EncodedRucksacks { get; set; }
    
    [Benchmark]
    public int CalculateSumOfPrioritiesForEncodedRucksacks()
    {
        return RucksackPriorityCalculator.CalculateSumOfPrioritiesForEncodedRucksacks(EncodedRucksacks);
    }
    
    [Benchmark]
    public int CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks()
    {
        return RucksackPriorityCalculator.CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks(EncodedRucksacks);
    }
    

    public IEnumerable<IEnumerable<string>> Data => new[]
    {
        File.ReadLines("./input").ToArray(),
        File.ReadLines("./test").ToArray()
    };
}
