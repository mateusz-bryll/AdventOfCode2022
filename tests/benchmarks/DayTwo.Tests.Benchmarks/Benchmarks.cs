using AdventOfCode.Benchmarks.Sdk;
using DayTwo;

public class Benchmarks : BenchmarkFor<DayTwoTasks>
{
    public Benchmarks() : base(new DayTwoTasks())
    {
    }
}
