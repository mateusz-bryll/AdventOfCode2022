using AdventOfCode.Benchmarks.Sdk;

namespace DayEight.Tests.Benchmarks;

public class Benchmarks : BenchmarkFor<DayEightTasks>
{
    public Benchmarks() : base(new DayEightTasks())
    {
    }
}
