using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DayFour.Tests.Unit;

public class CampCleanupTests : TestWithDataFor<DayFourTasks>
{
    public CampCleanupTests() : base(new DayFourTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(int result)
    {
        result.Should().Be(2);
    }

    protected override void AssertGetAdvancedTaskResult(int result)
    {
        result.Should().Be(4);
    }
}
