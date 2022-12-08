using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DayEight.Tests.Unit;

public class DayEightTasksTests : TestWithDataFor<DayEightTasks>
{
    public DayEightTasksTests() : base(new DayEightTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(int result)
    {
        result.Should().Be(21);
    }

    protected override void AssertGetAdvancedTaskResult(int result)
    {
        result.Should().Be(8);
    }
}
