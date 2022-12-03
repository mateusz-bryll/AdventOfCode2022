using DayThree.Domain;
using FluentAssertions;
using Xunit;

namespace DayThree.Tests.Unit;

public class RucksackTests
{
    [Theory]
    [InlineData("vJrwpWtwJgWrhcsFMMfFFhFp", 16)]
    [InlineData("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", 38)]
    [InlineData("PmmdzqPrVvPwwTWBwg", 42)]
    [InlineData("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", 22)]
    [InlineData("ttgJtRGJQctTZtZT", 20)]
    [InlineData("CrZsJsPPZsGzwwsLwLmpwMDw", 19)]
    public void GetPriorityOfItemThatAppearsInBothCompartments_ShouldReturnCorrectPriority_ForTestData(string input, int expectedPriority)
    {
        var rucksack = new Rucksack(input);

        var priority = rucksack.GetPriorityOfItemThatAppearsInBothCompartments();

        priority.Should().Be(expectedPriority);
    }

    [Theory]
    [InlineData("vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg", 18)]
    [InlineData("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw", 52)]
    public void FindPriorityOfCommonItem_ShouldReturnCorrectPriority_ForTestData(string encodedRucksackA, string encodedRucksackB, string encodedRucksackC, int expectedPriority)
    {
        var rucksackA = new Rucksack(encodedRucksackA);
        var rucksackB = new Rucksack(encodedRucksackB);
        var rucksackC = new Rucksack(encodedRucksackC);

        var result = Rucksack.FindPriorityOfBadgeItem(rucksackA, rucksackB, rucksackC);

        result.Should().Be(expectedPriority);
    }
}
