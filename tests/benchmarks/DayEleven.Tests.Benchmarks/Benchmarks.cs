using AdventOfCode.Benchmarks.Sdk;

namespace DayEleven.Tests.Benchmarks;

public class Benchmarks : BenchmarkFor<DayElevenTasks, ulong>
{
    public Benchmarks() : base(new DayElevenTasks())
    {
    }
}
