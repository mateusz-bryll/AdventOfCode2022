using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DayThree.Tests.Unit;

public class RucksackPriorityCalculatorTests : TestWithDataFor<DayThreeTasks>
{
    public RucksackPriorityCalculatorTests() : base(new DayThreeTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(int result)
    {
        result.Should().Be(157);
    }

    protected override void AssertGetAdvancedTaskResult(int result)
    {
        result.Should().Be(70);
    }
}
