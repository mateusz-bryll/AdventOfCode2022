namespace DayOne;

internal readonly record struct ElfCalories(int Id, int Calories);

internal static class CaloriesCalculator
{
    public static ElfCalories FindElfCarryingMostCalories(string inputFilePath) =>
        GetTotalCaloriesForEachElf(inputFilePath).MaxBy(elf => elf.Calories);

    public static int CalculateHowManyCaloriesTopThreeElfsCarryingInTotal(string inputFilePath) =>
        GetTotalCaloriesForEachElf(inputFilePath)
            .OrderByDescending(elf => elf.Calories)
            .Take(3)
            .Sum(elf => elf.Calories);

    private static IEnumerable<ElfCalories> GetTotalCaloriesForEachElf(string inputFilePath)
    {
        var id = 1;
        var totalCalories = 0;
        foreach(var line in File.ReadLines(inputFilePath))
        {
            if (int.TryParse(line, out var calories))
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