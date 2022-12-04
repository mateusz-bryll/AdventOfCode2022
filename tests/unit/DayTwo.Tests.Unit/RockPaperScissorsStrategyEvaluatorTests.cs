using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DayTwo.Tests.Unit;

public class RockPaperScissorsStrategyEvaluatorTests : TestWithDataFor<DayTwoTasks>
{
    public RockPaperScissorsStrategyEvaluatorTests() : base(new DayTwoTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(int result)
    {
        result.Should().Be(15);
    }

    protected override void AssertGetAdvancedTaskResult(int result)
    {
        result.Should().Be(12);
    }
}
