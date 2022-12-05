namespace AdventOfCode.Tasks.Sdk;

public interface ITasks : ITasks<int>
{
}

public interface ITasks<out TTasksResult> : ITasks<TTasksResult, TTasksResult>
{
}

public interface ITasks<out TFirstTaskResult, out TSecondTaskResult> : ITasksMetadata
{
    TFirstTaskResult GetBasicTaskResult(IEnumerable<string> input);
    TSecondTaskResult GetAdvancedTaskResult(IEnumerable<string> input);
}

public interface ITasksMetadata
{
    int DayNumber { get; }
}