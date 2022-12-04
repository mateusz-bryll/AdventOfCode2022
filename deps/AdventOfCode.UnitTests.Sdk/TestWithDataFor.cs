using System.Text;
using AdventOfCode.Tasks.Sdk;
using Xunit;

namespace AdventOfCode.UnitTests.Sdk;

public abstract class TestWithDataFor<TTasks>
    where TTasks : ITasks
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

    protected abstract void AssertGetBasicTaskResult(int result);

    [Fact]
    public void GetAdvancedTaskResult()
    {
        var result = tasks.GetAdvancedTaskResult(TestData);
        AssertGetAdvancedTaskResult(result);
    }
    
    protected abstract void AssertGetAdvancedTaskResult(int result);

    private IEnumerable<string> TestData => File.ReadLines($"day-{tasks.DayNumber:D2}.testdata", Encoding.UTF8);
}
