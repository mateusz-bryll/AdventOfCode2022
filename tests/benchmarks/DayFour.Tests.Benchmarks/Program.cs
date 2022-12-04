using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DayFour.Domain;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [ParamsSource(nameof(Data))]
    public IEnumerable<string> AssignmentStrings { get; set; } = default!;
    
    [Benchmark]
    public int CountHowManyAssignmentPairsDoesOneRangeFullyContainTheOther()
    {
        return CampCleanup.CountHowManyAssignmentPairsDoesOneRangeFullyContainTheOther(AssignmentStrings);
    }
    
    [Benchmark]
    public int CountHowManyAssignmentPairsDoesOneRangeOverlapTheOther()
    {
        return CampCleanup.CountHowManyAssignmentPairsDoesOneRangeOverlapTheOther(AssignmentStrings);
    }
    
    public IEnumerable<IEnumerable<string>> Data => new[]
    {
        File.ReadLines("./day-04.inputdata").ToArray(),
        File.ReadLines("./day-04.testdata").ToArray()
    };
}
