using Xunit;
using DayTwo;
using FluentAssertions;

namespace DayTwo.Tests.Unit;

public class RockPaperScissorsStrategyEvaluatorTests
{
    [Fact]
    public void CalculateTotalScoreForStrategy_ShouldReturnCorrectAnswer_ForExampleData()
    {
        var result = RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForStrategy("./test");

        result.Should().Be(15);
    }
    
    [Fact]
    public void GetAllRoundResultsFromStrategyFile_ShouldReturnCorrectAnswer_ForExampleData()
    {
        var result = RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForResultStrategy("./test");

        result.Should().Be(12);
    }
}
