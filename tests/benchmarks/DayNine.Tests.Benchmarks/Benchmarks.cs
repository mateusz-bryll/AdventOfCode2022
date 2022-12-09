using AdventOfCode.Benchmarks.Sdk;

namespace DayNine.Tests.Benchmarks;

public class Benchmarks : BenchmarkFor<DayNineTasks>
{
    public Benchmarks() : base(new DayNineTasks())
    {
    }
}
