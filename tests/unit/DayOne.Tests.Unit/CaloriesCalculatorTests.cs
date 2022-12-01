using FluentAssertions;
using Xunit;

namespace DayOne.Tests.Unit;

public class CaloriesCalculatorTests
{
    [Fact]
    public void FindElfCarryingMostCalories_ShouldReturnCorrectAnswer_ForExampleData()
    {
        var result = CaloriesCalculator.FindElfCarryingMostCalories("./test");

        result.Should().BeEquivalentTo(new ElfCalories(4, 24_000));
    }
    
    [Fact]
    public void CalculateHowManyCaloriesTopThreeElfsCarryingInTotal_ShouldReturnCorrectAnswer_ForExampleData()
    {
        var result = CaloriesCalculator.CalculateHowManyCaloriesTopThreeElfsCarryingInTotal("./test");

        result.Should().Be(45_000);
    }
}