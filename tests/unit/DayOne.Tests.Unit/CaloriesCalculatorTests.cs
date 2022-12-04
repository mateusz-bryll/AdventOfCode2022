using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DayOne.Tests.Unit;

public class CaloriesCalculatorTests : TestWithDataFor<DayOneTasks>
{
    public CaloriesCalculatorTests() : base(new DayOneTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(int result)
    {
        result.Should().Be(24_000);
    }

    protected override void AssertGetAdvancedTaskResult(int result)
    {
        result.Should().Be(45_000);
    }
}