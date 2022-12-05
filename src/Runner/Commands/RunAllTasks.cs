using System.Text;
using AdventOfCode.Tasks.Sdk;
using CommandLine;
using Runner.Utils;
using Runner.Utils.Commands;

namespace Runner.Commands;

[Verb("run-all-tasks", isDefault: true, HelpText = "Run all tasks for Advent of Code 2022")]
public class RunAllTasks : ICommand
{
}

public class RunAllTasksHandler : ICommandHandler<RunAllTasks>
{
    private readonly IEnumerable<ITasksMetadata> tasks;

    public RunAllTasksHandler(IEnumerable<ITasksMetadata> tasks)
    {
        this.tasks = tasks;
    }
    
    public void Handle(RunAllTasks command)
    {
        var results = new StringBuilder();
        foreach (var task in tasks.OrderBy(day => day.DayNumber))
        {
            TaskRunner.RunTasks(task, results);
        }

        Console.WriteLine(results.ToString());
    }
}
