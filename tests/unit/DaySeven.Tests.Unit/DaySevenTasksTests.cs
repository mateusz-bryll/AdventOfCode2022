using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DaySeven.Tests.Unit;

public class DaySevenTasksTests : TestWithDataFor<DaySevenTasks>
{
    public DaySevenTasksTests() : base(new DaySevenTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(int result)
    {
        result.Should().Be(95_437);
    }

    protected override void AssertGetAdvancedTaskResult(int result)
    {
        result.Should().Be(24_933_642);
    }
}
