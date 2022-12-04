using System.Reflection;
using System.Text;
using AdventOfCode.Tasks.Sdk;

namespace Runner.Utils;

public static class TaskRunner
{
    public static void RunTasks(ITasks tasks, StringBuilder taskResults)
    {
        var inputFilePath = Path.Combine(AppContext.BaseDirectory, $"day-{tasks.DayNumber:D2}.inputdata");
        var input = File.ReadLines(inputFilePath, Encoding.UTF8);

        taskResults.AppendLine($"Results for day {tasks.DayNumber:D2}:");
        taskResults.AppendLine($"\tBasic solution:\t\t{GetResult(tasks.GetBasicTaskResult, input)}");
        taskResults.AppendLine($"\tAdvanced solution:\t{GetResult(tasks.GetAdvancedTaskResult, input)}");
    }

    public static string RunTasks(ITasks tasks)
    {
        var results = new StringBuilder();
        RunTasks(tasks, results);
        return results.ToString();
    }

    private static string GetResult(Delegate task, IEnumerable<string> input)
    {
        var description = task.Method.GetCustomAttributes(typeof(TaskResultDescriptionAttribute), false).FirstOrDefault() as TaskResultDescriptionAttribute;
        try
        {
            var result = task.DynamicInvoke(input);
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
