using AdventOfCode.Tasks.Sdk;
using CommandLine;
using Runner.Utils;
using Runner.Utils.Commands;

namespace Runner.Commands;

public enum Day
{
    
}

[Verb("run-tasks", isDefault: false, HelpText = "Run all tasks for Advent of Code 2022")]
public class RunDayTasks : ICommand
{
    [Option('d', "day", Required = true, HelpText = "Day number")]
    public uint Day { get; set; }
}

public class RunDayTasksHandler : ICommandHandler<RunDayTasks>
{
    private readonly IEnumerable<ITasks> tasks;

    public RunDayTasksHandler(IEnumerable<ITasks> tasks)
    {
        this.tasks = tasks;
    }
    
    public void Handle(RunDayTasks command)
    {
        if (command.Day > 25)
        {
            Console.WriteLine($"There are only 25 days in the AoC calendar ;)");
            return;
        }
        
        var tasksToExecute = tasks.FirstOrDefault(t => t.DayNumber == command.Day);

        if (tasksToExecute is null)
        {
            Console.WriteLine($"Sorry tasks for day {command.Day:D2} are not implemented yet :(");
            return;
        }
        
        Console.WriteLine(TaskRunner.RunTasks(tasksToExecute));
    }
}
