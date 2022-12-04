using AdventOfCode.Benchmarks.Sdk;
using DayThree;

public class Benchmarks : BenchmarkFor<DayThreeTasks>
{
    public Benchmarks() : base(new DayThreeTasks())
    {
    }
}
