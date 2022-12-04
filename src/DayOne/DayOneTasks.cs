using AdventOfCode.Tasks.Sdk;

namespace DayOne;

public class DayOneTasks : ITasks
{
    public int DayNumber => 1;

    [TaskResultDescription("total calories carried by an Elf")]
    public int GetBasicTaskResult(IEnumerable<string> input) =>
        CaloriesCalculator.FindElfCarryingMostCalories(input).Calories;

    [TaskResultDescription("total calories carried by 3 Elves")]
    public int GetAdvancedTaskResult(IEnumerable<string> input) =>
        CaloriesCalculator.CalculateHowManyCaloriesTopThreeElvesCarryingInTotal(input);
}
