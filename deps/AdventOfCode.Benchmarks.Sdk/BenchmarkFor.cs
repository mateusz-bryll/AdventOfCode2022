using System.Text;
using AdventOfCode.Tasks.Sdk;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode.Benchmarks.Sdk;

[MemoryDiagnoser]
public abstract class BenchmarkFor<TTasks> : IBenchmark
    where TTasks : ITasks
{
    public int DayNumber => tasks.DayNumber;
    private readonly TTasks tasks;

    protected BenchmarkFor(TTasks tasks)
    {
        this.tasks = tasks;
    }
    
    [ParamsSource(nameof(Data))]
    public IEnumerable<string> BenchmarkInputData { get; set; } = default!;
    
    [Benchmark]
    public int Basic()
    {
        return tasks.GetBasicTaskResult(BenchmarkInputData);
    }

    [Benchmark]
    public int Advanced()
    {
        return tasks.GetAdvancedTaskResult(BenchmarkInputData);
    }
    
    public IEnumerable<IEnumerable<string>> Data => new[]
    {
        File.ReadLines(Path.Combine(AppContext.BaseDirectory, $"day-{tasks.DayNumber:D2}.inputdata"), Encoding.UTF8).ToArray(),
        File.ReadLines(Path.Combine(AppContext.BaseDirectory, $"day-{tasks.DayNumber:D2}.testdata"), Encoding.UTF8).ToArray()
    };
}
