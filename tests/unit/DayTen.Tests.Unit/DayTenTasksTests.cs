using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DayTen.Tests.Unit;

public class DayTenTasksTests : TestWithDataFor<DayTenTasks, int, string>
{
    public DayTenTasksTests() : base(new DayTenTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(int result)
    {
        result.Should().Be(13140);
    }

    protected override void AssertGetAdvancedTaskResult(string result)
    {
        result.Should().NotBeEmpty();
    }
}
