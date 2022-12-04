using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DayThree.Domain;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [ParamsSource(nameof(Data))]
    public IEnumerable<string> EncodedRucksacks { get; set; } = default!;
    
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
        File.ReadLines("./day-03.inputdata").ToArray(),
        File.ReadLines("./day-03.testdata").ToArray()
    };
}
