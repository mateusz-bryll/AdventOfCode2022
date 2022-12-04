namespace AdventOfCode.Tasks.Sdk;

public interface ITasks
{
    int DayNumber { get; }

    int GetBasicTaskResult(IEnumerable<string> input);
    int GetAdvancedTaskResult(IEnumerable<string> input);
}