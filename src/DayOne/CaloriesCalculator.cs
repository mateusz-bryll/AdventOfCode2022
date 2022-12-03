namespace DayOne;

public readonly record struct ElfCalories(int Id, int Calories);

public static class CaloriesCalculator
{
    public static ElfCalories FindElfCarryingMostCalories(IEnumerable<string> caloriesList) =>
        GetTotalCaloriesForEachElf(caloriesList).MaxBy(elf => elf.Calories);

    public static int CalculateHowManyCaloriesTopThreeElvesCarryingInTotal(IEnumerable<string> caloriesList) =>
        GetTotalCaloriesForEachElf(caloriesList)
            .OrderByDescending(elf => elf.Calories)
            .Take(3)
            .Sum(elf => elf.Calories);

    private static IEnumerable<ElfCalories> GetTotalCaloriesForEachElf(IEnumerable<string> caloriesList)
    {
        var id = 1;
        var totalCalories = 0;
        foreach(var caloriesListItem in caloriesList)
        {
            if (int.TryParse(caloriesListItem, out var calories))
            {
                totalCalories += calories;
            }
            else
            {
                yield return new ElfCalories(id, totalCalories);

                totalCalories = 0;
                id++;
            }
        }
    }
}