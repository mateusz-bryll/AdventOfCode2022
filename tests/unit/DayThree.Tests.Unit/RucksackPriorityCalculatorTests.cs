using System.Text;
using DayThree.Domain;
using FluentAssertions;
using Xunit;

namespace DayThree.Tests.Unit;

public class RucksackPriorityCalculatorTests
{
    [Fact]
    public void CalculateSumOfPrioritiesForEncodedRucksacks_ReturnsCorrectSum_ForTestData()
    {
        var encodedRucksacks = File.ReadLines("./test", Encoding.UTF8);

        var sum = RucksackPriorityCalculator.CalculateSumOfPrioritiesForEncodedRucksacks(encodedRucksacks);

        sum.Should().Be(157);
    }

    [Fact]
    public void CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks_ReturnsCorrectSum_ForTestData()
    {
        var encodedRucksacks = File.ReadLines("./test", Encoding.UTF8);

        var sum = RucksackPriorityCalculator.CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks(encodedRucksacks);

        sum.Should().Be(70);
    }
}
