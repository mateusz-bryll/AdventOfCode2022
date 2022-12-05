using System.Text;
using AdventOfCode.Tasks.Sdk;
using Xunit;

namespace AdventOfCode.UnitTests.Sdk;

public abstract class TestWithDataFor<TTasks> : TestWithDataFor<TTasks, int>
    where TTasks : ITasks<int>
{
    protected TestWithDataFor(TTasks tasks) : base(tasks)
    {
    }
}

public abstract class TestWithDataFor<TTasks, TTasksResult> : TestWithDataFor<TTasks, TTasksResult, TTasksResult>
    where TTasks : ITasks<TTasksResult>
{
    protected TestWithDataFor(TTasks tasks) : base(tasks)
    {
    }
}

public abstract class TestWithDataFor<TTasks, TFirstTaskResult, TSecondTaskResult>
    where TTasks : ITasks<TFirstTaskResult, TSecondTaskResult>
{
    private readonly TTasks tasks;

    protected TestWithDataFor(TTasks tasks)
    {
        this.tasks = tasks;
    }
    
    [Fact]
    public void GetBasicTaskResult()
    {
        var result = tasks.GetBasicTaskResult(TestData);
        AssertGetBasicTaskResult(result);
    }

    protected abstract void AssertGetBasicTaskResult(TFirstTaskResult result);

    [Fact]
    public void GetAdvancedTaskResult()
    {
        var result = tasks.GetAdvancedTaskResult(TestData);
        AssertGetAdvancedTaskResult(result);
    }
    
    protected abstract void AssertGetAdvancedTaskResult(TSecondTaskResult result);

    private IEnumerable<string> TestData => File.ReadLines($"day-{tasks.DayNumber:D2}.testdata", Encoding.UTF8);
}
