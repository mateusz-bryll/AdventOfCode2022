using AdventOfCode.Benchmarks.Sdk;

namespace DayFive.Tests.Benchmarks;

public class Benchmarks : BenchmarkFor<DayFiveTasks, string>
{
    public Benchmarks() : base(new DayFiveTasks())
    {
    }
}
