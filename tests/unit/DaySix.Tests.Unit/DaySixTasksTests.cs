using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DaySix.Tests.Unit;

public class DaySixTasksTests : TestWithDataFor<DaySixTasks>
{
    public DaySixTasksTests() : base(new DaySixTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(int result)
    {
        result.Should().Be(7);
    }

    protected override void AssertGetAdvancedTaskResult(int result)
    {
        result.Should().Be(19);
    }
}
