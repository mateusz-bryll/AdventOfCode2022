using AdventOfCode.Benchmarks.Sdk;

namespace DayTen.Tests.Benchmarks;

public class Benchmarks : BenchmarkFor<DayTenTasks, int, string>
{
    public Benchmarks() : base(new DayTenTasks())
    {
    }
}
