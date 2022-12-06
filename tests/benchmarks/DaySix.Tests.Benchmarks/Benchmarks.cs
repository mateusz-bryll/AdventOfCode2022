using AdventOfCode.Benchmarks.Sdk;

namespace DaySix.Tests.Benchmarks;

public class Benchmarks : BenchmarkFor<DaySixTasks>
{
    public Benchmarks() : base(new DaySixTasks())
    {
    }

    protected override InputSize InputSize => InputSize.AverageLineLength;
}
