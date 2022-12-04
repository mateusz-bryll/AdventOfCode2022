using AdventOfCode.Benchmarks.Sdk;
using DayOne;

public class Benchmarks : BenchmarkFor<DayOneTasks>
{
    public Benchmarks() : base(new DayOneTasks())
    {
    }
}
