using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;

namespace DayEleven.Tests.Unit;

public class DayElevenTasksTests : TestWithDataFor<DayElevenTasks, ulong>
{
    public DayElevenTasksTests() : base(new DayElevenTasks())
    {
    }

    protected override void AssertGetBasicTaskResult(ulong result)
    {
        result.Should().Be(10605);
    }

    protected override void AssertGetAdvancedTaskResult(ulong result)
    {
        result.Should().Be(2713310158);
    }
}
