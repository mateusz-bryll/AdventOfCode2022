using AdventOfCode.Benchmarks.Sdk;

namespace DaySeven.Tests.Benchmarks;

public class Benchmarks : BenchmarkFor<DaySevenTasks>
{
    public Benchmarks() : base(new DaySevenTasks())
    {
    }
}
