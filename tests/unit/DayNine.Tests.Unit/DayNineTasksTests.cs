using AdventOfCode.UnitTests.Sdk;
using FluentAssertions;
using Xunit;

namespace DayNine.Tests.Unit;

public class DayNineTasksTests : TestWithDataFor<DayNineTasks>
{
    public DayNineTasksTests() : base(new DayNineTasks())
    {
    }

    [CustomTestDataFileSuffix("basic")]
    protected override void AssertGetBasicTaskResult(int result)
    {
        result.Should().Be(13);
    }

    [CustomTestDataFileSuffix("advanced")]
    protected override void AssertGetAdvancedTaskResult(int result)
    {
        result.Should().Be(36);
    }

    [Theory]
    [InlineData(1,0,0,0,0,0)] // Move right 1 step
    [InlineData(2,0,0,0,1,0)] // Move right 2 steps
    [InlineData(-1,0,0,0,0,0)] // Move left 1 step
    [InlineData(-2,0,0,0,-1,0)] // Move left 1 steps
    [InlineData(0,1,0,0,0,0)] // Move up 1 step
    [InlineData(0,2,0,0,0,1)] // Move up 2 steps
    [InlineData(0,-1,0,0,0,0)] // Move down 1 step
    [InlineData(0,-2,0,0,0,-1)] // Move down 2 steps
    [InlineData(1,1,0,0,0,0)] // Move right 1 step up 1 step
    [InlineData(2,1,0,0,1,1)] // Move right 2 steps up 1 step
    [InlineData(1,2,0,0,1,1)] // Move right 1 step up 2 steps
    [InlineData(-1,1,0,0,0,0)] // Move left 1 step up 1 step
    [InlineData(-2,1,0,0,-1,1)] // Move left 2 steps up 1 step
    [InlineData(-1,2,0,0,-1,1)] // Move left 1 step up 2 steps
    [InlineData(1,-1,0,0,0,0)] // Move right 1 step down 1 step
    [InlineData(2,-1,0,0,1,-1)] // Move right 2 steps down 1 step
    [InlineData(1,-2,0,0,1,-1)] // Move right 1 step down 2 steps
    [InlineData(-1,-1,0,0,0,0)] // Move left 1 step down 1 step
    [InlineData(-2,-1,0,0,-1,-1)] // Move left 2 steps down 1 step
    [InlineData(-1,-2,0,0,-1,-1)] // Move left 1 step down 2 steps
    [InlineData(0,0,0,0,0,0)] // Head is on tail
    public void MoveTailAccordingToHead_ShouldReturnCorrectTailPosition_ForMove(int headX, int headY, int tailX, int tailY, int expectedTailX, int expectedTailY)
    {
        var head = (X: headX, Y: headY);
        var tail = (X: tailX, Y: tailY);
        
        DayNineTasks.MoveTailAccordingToHead(ref tail, ref head);

        tail.Should().Be((expectedTailX, expectedTailY));
    }

    [Theory]
    [InlineData(0,0,'R',1,0)]
    [InlineData(0,0,'L',-1,0)]
    [InlineData(0,0,'U',0,1)]
    [InlineData(0,0,'D',0,-1)]
    public void MoveHead_ShouldReturnCorrectHeadPosition_ForDirection(int headX, int headY, char direction, int expectedHeadX, int expectedHeadY)
    {
        var head = (X: headX, Y: headY);
        
        DayNineTasks.MoveHead(ref head, ref direction);

        head.Should().Be((expectedHeadX, expectedHeadY));
    }
}
