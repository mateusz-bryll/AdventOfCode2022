using System.Reflection;
using System.Text;
using AdventOfCode.Tasks.Sdk;

namespace Runner.Utils;

public static class TaskRunner
{
    public static void RunTasks(ITasksMetadata tasks, StringBuilder taskResults)
    {
        var inputFilePath = Path.Combine(AppContext.BaseDirectory, $"day-{tasks.DayNumber:D2}.inputdata");
        var input = File.ReadLines(inputFilePath, Encoding.UTF8);

        var firstTaskMethod = tasks.GetType().GetMethod(nameof(ITasks.GetBasicTaskResult));
        var secondTaskMethod = tasks.GetType().GetMethod(nameof(ITasks.GetAdvancedTaskResult));

        taskResults.AppendLine($"Results for day {tasks.DayNumber:D2}:");
        taskResults.AppendLine($"\tBasic solution:\t\t{GetResult(tasks, firstTaskMethod, input)}");
        taskResults.AppendLine($"\tAdvanced solution:\t{GetResult(tasks, secondTaskMethod, input)}");
    }

    public static string RunTasks(ITasksMetadata tasks)
    {
        var results = new StringBuilder();
        RunTasks(tasks, results);
        return results.ToString();
    }

    private static string GetResult(ITasksMetadata tasks, MethodInfo? method, IEnumerable<string> input)
    {
        if (tasks is null || method is null)
            throw new InvalidOperationException();
        
        var description = method.GetCustomAttributes(typeof(TaskResultDescriptionAttribute), false).FirstOrDefault() as TaskResultDescriptionAttribute;
        try
        {
            var result = method.Invoke(tasks, new object[] { input });
            return description is not null ? $"{result} {description.Text}" : result?.ToString() ?? "NULL";
        }
        catch (TargetInvocationException e) when (e.InnerException is NotImplementedException) 
        {
            return "Not implemented yet!";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}
