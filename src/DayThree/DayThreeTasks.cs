using AdventOfCode.Tasks.Sdk;
using DayThree.Domain;

namespace DayThree;

public class DayThreeTasks : ITasks
{
    public int DayNumber => 3;

    [TaskResultDescription("sum of priorities of items that appears in both compartments")]
    public int GetBasicTaskResult(IEnumerable<string> input) =>
        RucksackPriorityCalculator.CalculateSumOfPrioritiesForEncodedRucksacks(input);

    [TaskResultDescription("sum of priorities of badge items")]
    public int GetAdvancedTaskResult(IEnumerable<string> input) =>
        RucksackPriorityCalculator.CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks(input);
}
