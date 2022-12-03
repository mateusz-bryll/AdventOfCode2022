using Xunit;
using DayTwo;
using FluentAssertions;

namespace DayTwo.Tests.Unit;

public class RockPaperScissorsStrategyEvaluatorTests
{
    [Fact]
    public void CalculateTotalScoreForStrategy_ShouldReturnCorrectAnswer_ForExampleData()
    {
        var strategyMoves = File.ReadLines("./test");
        
        var result = RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForStrategy(strategyMoves);

        result.Should().Be(15);
    }
    
    [Fact]
    public void GetAllRoundResultsFromStrategyFile_ShouldReturnCorrectAnswer_ForExampleData()
    {
        var strategyMoves = File.ReadLines("./test");
        
        var result = RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForResultStrategy(strategyMoves);

        result.Should().Be(12);
    }
}
