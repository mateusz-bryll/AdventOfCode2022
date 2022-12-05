using AdventOfCode.Tasks.Sdk;
using CommandLine;
using FluentValidation;
using Runner.Utils;
using Runner.Utils.Commands;

namespace Runner.Commands;

[Verb("run-tasks", isDefault: false, HelpText = "Run tasks for specific day for Advent of Code 2022")]
public class RunDayTasks : ICommand
{
    [Option('d', "day", Required = true, HelpText = "Day number")]
    public int Day { get; set; }
}

public class RunDayTasksValidator : AbstractValidator<RunDayTasks>
{
    public RunDayTasksValidator()
    {
        RuleFor(x => x.Day)
            .GreaterThanOrEqualTo(1)
            .LessThanOrEqualTo(25)
            .WithErrorCode("DayOutOfRange");
    }
}

public class RunDayTasksHandler : ICommandHandler<RunDayTasks>
{
    private readonly IEnumerable<ITasksMetadata> tasks;

    public RunDayTasksHandler(IEnumerable<ITasksMetadata> tasks)
    {
        this.tasks = tasks;
    }
    
    public void Handle(RunDayTasks command)
    {
        var tasksToExecute = tasks.FirstOrDefault(t => t.DayNumber == command.Day);

        if (tasksToExecute is null)
        {
            Console.WriteLine($"Sorry tasks for day {command.Day:D2} are not implemented yet :(");
            return;
        }
        
        Console.WriteLine(TaskRunner.RunTasks(tasksToExecute));
    }
}
