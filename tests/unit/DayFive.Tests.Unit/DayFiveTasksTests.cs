using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DayFive.Tests.Unit;

public class DayFiveTasksTests : TestWithDataFor<DayFiveTasks, string>
{
    public DayFiveTasksTests() : base(new DayFiveTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(string result)
    {
        result.Should().Be("CMZ");
    }

    protected override void AssertGetAdvancedTaskResult(string result)
    {
        result.Should().Be("MCD");
    }
}
