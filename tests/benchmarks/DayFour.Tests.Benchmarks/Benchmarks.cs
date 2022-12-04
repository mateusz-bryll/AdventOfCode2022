using AdventOfCode.Benchmarks.Sdk;
using DayFour;

public class Benchmarks : BenchmarkFor<DayFourTasks>
{
    public Benchmarks() : base(new DayFourTasks())
    {
    }
}
