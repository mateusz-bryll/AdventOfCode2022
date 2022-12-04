using DayFour.Domain;
using FluentAssertions;
using Xunit;

namespace DayFour.Tests.Unit;

public class ElvesAssignmentPairTests
{
    [Fact]
    public void Parse_ReturnsCorrectElvesAssignmentPair_ForCorrectAssignmentString()
    {
        const string assignmentString = "123-456,789-1012";

        var result = ElvesAssignmentPair.Parse(assignmentString);

        result.FirstElfRange.Start.Should().Be(123);
        result.FirstElfRange.End.Should().Be(456);
        result.SecondElfRange.Start.Should().Be(789);
        result.SecondElfRange.End.Should().Be(1012);
    }
    
    [Theory]
    [InlineData("2-4,6-8")]
    [InlineData("2-3,4-5")]
    [InlineData("5-7,7-9")]
    [InlineData("2-6,4-8")]
    public void Contains_ReturnsFalse_WhenRangesNotContainsOneAnother(string assignmentString)
    {
        var elvesAssignmentPair = ElvesAssignmentPair.Parse(assignmentString);

        var result = elvesAssignmentPair.IsOneRangeContainsOther();

        result.Should().Be(false);
    }
    
    [Theory]
    [InlineData("2-8,3-7")]
    [InlineData("6-6,4-6")]
    public void Contains_ReturnsTru_WhenRangesContainsOneAnother(string assignmentString)
    {
        var elvesAssignmentPair = ElvesAssignmentPair.Parse(assignmentString);

        var result = elvesAssignmentPair.IsOneRangeContainsOther();

        result.Should().Be(true);
    }
    
    [Theory]
    [InlineData("2-4,6-8")]
    [InlineData("2-3,4-5")]
    public void Overlaps_ReturnsFalse_WhenRangesNotOverlapsOneAnother(string assignmentString)
    {
        var elvesAssignmentPair = ElvesAssignmentPair.Parse(assignmentString);

        var result = elvesAssignmentPair.IsOneRangeOverlapsOther();

        result.Should().Be(false);
    }
    
    [Theory]
    [InlineData("5-7,7-9")]
    [InlineData("2-8,3-7")]
    [InlineData("6-6,4-6")]
    [InlineData("2-6,4-8")]
    public void Overlaps_ReturnsTru_WhenRangesOverlapsOneAnother(string assignmentString)
    {
        var elvesAssignmentPair = ElvesAssignmentPair.Parse(assignmentString);

        var result = elvesAssignmentPair.IsOneRangeOverlapsOther();

        result.Should().Be(true);
    }
}
