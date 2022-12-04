using DayFour.Domain;
using FluentAssertions;
using Xunit;

namespace DayFour.Tests.Unit;

public class CampCleanupTests
{
    [Fact]
    public void CountHowManyAssignmentPairsDoesOneRangeFullyContainTheOther_ShouldReturnTwo_ForTestData()
    {
        var assignmentStrings = File.ReadLines("./test");

        var result = CampCleanup.CountHowManyAssignmentPairsDoesOneRangeFullyContainTheOther(assignmentStrings);

        result.Should().Be(2);
    }
    
    [Fact]
    public void CountHowManyAssignmentPairsDoesOneRangeOverlapTheOther_ShouldReturnTwo_ForTestData()
    {
        var assignmentStrings = File.ReadLines("./test");

        var result = CampCleanup.CountHowManyAssignmentPairsDoesOneRangeOverlapTheOther(assignmentStrings);

        result.Should().Be(4);
    }
}
