using AdventOfCode.Benchmarks.Sdk;
using BenchmarkDotNet.Running;
using CommandLine;
using FluentValidation;
using Runner.Utils.Commands;

namespace Runner.Commands;

[Verb("run-benchmark", isDefault: false, HelpText = "Run tasks benchmark for specific day for Advent of Code 2022")]
public class RunDayTasksBenchmark : ICommand
{
    [Option('d', "day", Required = true, HelpText = "Day number")]
    public int Day { get; set; }
}

public class RunDayTasksBenchmarkValidator : AbstractValidator<RunDayTasksBenchmark>
{
    public RunDayTasksBenchmarkValidator()
    {
        RuleFor(x => x.Day)
            .GreaterThanOrEqualTo(1)
            .LessThanOrEqualTo(25)
            .WithErrorCode("DayOutOfRange");
    }
}

public class RunDayTasksBenchmarkHandler : ICommandHandler<RunDayTasksBenchmark>
{
    private readonly IEnumerable<IBenchmark> benchmarks;

    public RunDayTasksBenchmarkHandler(IEnumerable<IBenchmark> benchmarks)
    {
        this.benchmarks = benchmarks;
    }
    
    public void Handle(RunDayTasksBenchmark command)
    {
        var benchmarkToExecute = benchmarks.FirstOrDefault(t => t.DayNumber == command.Day);

        if (benchmarkToExecute is null)
        {
            Console.WriteLine($"Sorry tasks benchmark for day {command.Day:D2} is not implemented yet :(");
            return;
        }

        BenchmarkRunner.Run(benchmarkToExecute.GetType());
    }
}
