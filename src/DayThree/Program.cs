using DayThree.Domain;

var encodedRucksacks = File.ReadLines("./input");

Console.WriteLine($"Part 1 answer: {RucksackPriorityCalculator.CalculateSumOfPrioritiesForEncodedRucksacks(encodedRucksacks)}");
Console.WriteLine($"Part 2 answer: {RucksackPriorityCalculator.CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks(encodedRucksacks)}");