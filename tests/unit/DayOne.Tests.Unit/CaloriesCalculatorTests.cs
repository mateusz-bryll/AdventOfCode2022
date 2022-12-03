using System.IO;
using FluentAssertions;
using Xunit;

namespace DayOne.Tests.Unit;

public class CaloriesCalculatorTests
{
    [Fact]
    public void FindElfCarryingMostCalories_ShouldReturnCorrectAnswer_ForExampleData()
    {
        var caloriesList = File.ReadLines("./test");
        
        var result = CaloriesCalculator.FindElfCarryingMostCalories(caloriesList);

        result.Should().BeEquivalentTo(new ElfCalories(4, 24_000));
    }
    
    [Fact]
    public void CalculateHowManyCaloriesTopThreeElvesCarryingInTotal_ShouldReturnCorrectAnswer_ForExampleData()
    {
        var caloriesList = File.ReadLines("./test");
        
        var result = CaloriesCalculator.CalculateHowManyCaloriesTopThreeElvesCarryingInTotal(caloriesList);

        result.Should().Be(45_000);
    }
}