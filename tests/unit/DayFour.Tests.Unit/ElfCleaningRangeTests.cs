using DayFour.Domain;
using FluentAssertions;
using Xunit;

namespace DayFour.Tests.Unit;

public class ElfCleaningRangeTests
{
    [Fact]
    public void Parse_ReturnsCorrectElfCleaningRange_ForCorrectRangeString()
    {
        const string rangeString = "123-456";

        var result = ElfCleaningRange.Parse(rangeString);

        result.Start.Should().Be(123);
        result.End.Should().Be(456);
    }

    [Theory]
    [InlineData("1-10", "11-20")]
    [InlineData("1-10", "10-20")]
    [InlineData("1-10", "5-20")]
    [InlineData("1-10", "1-20")]
    [InlineData("20-30", "1-10")]
    [InlineData("20-30", "1-20")]
    [InlineData("20-30", "1-25")]
    [InlineData("20-30", "1-30")]
    public void Contains_ReturnsFalse_WhenSecondRangeIsNotIncludedInFirstRange(string firstRangeString, string secondRangeString)
    {
        var firstRange = ElfCleaningRange.Parse(firstRangeString);
        var secondRange = ElfCleaningRange.Parse(secondRangeString);

        var result = firstRange.Contains(secondRange);

        result.Should().Be(false);
    }
    
    [Theory]
    [InlineData("10-30", "10-30")]
    [InlineData("10-30", "10-25")]
    [InlineData("10-30", "15-30")]
    [InlineData("10-30", "15-25")]
    public void Contains_ReturnsTrue_WhenSecondRangeIsIncludedInFirstRange(string firstRangeString, string secondRangeString)
    {
        var firstRange = ElfCleaningRange.Parse(firstRangeString);
        var secondRange = ElfCleaningRange.Parse(secondRangeString);

        var result = firstRange.Contains(secondRange);

        result.Should().Be(true);
    }
    
    [Theory]
    [InlineData("1-10", "11-20")]
    [InlineData("20-30", "1-10")]
    public void Overlaps_ReturnsFalse_WhenSecondRangeIsNotIncludedInFirstRange(string firstRangeString, string secondRangeString)
    {
        var firstRange = ElfCleaningRange.Parse(firstRangeString);
        var secondRange = ElfCleaningRange.Parse(secondRangeString);

        var result = firstRange.Overlaps(secondRange);

        result.Should().Be(false);
    }
    
    [Theory]
    [InlineData("10-30", "10-30")]
    [InlineData("10-30", "10-25")]
    [InlineData("10-30", "15-30")]
    [InlineData("10-30", "15-25")]
    [InlineData("1-10", "10-20")]
    [InlineData("1-10", "5-20")]
    [InlineData("1-10", "1-20")]
    [InlineData("20-30", "1-20")]
    [InlineData("20-30", "1-25")]
    [InlineData("20-30", "1-30")]
    public void Overlaps_ReturnsTrue_WhenSecondRangeIsIncludedInFirstRange(string firstRangeString, string secondRangeString)
    {
        var firstRange = ElfCleaningRange.Parse(firstRangeString);
        var secondRange = ElfCleaningRange.Parse(secondRangeString);

        var result = firstRange.Overlaps(secondRange);

        result.Should().Be(true);
    }
}
