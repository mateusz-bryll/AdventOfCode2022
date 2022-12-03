using DayOne;

var caloriesList = File.ReadLines("./input");

Console.WriteLine($"Part 1 answer: {CaloriesCalculator.FindElfCarryingMostCalories(caloriesList).Calories}");
Console.WriteLine($"Part 2 answer: {CaloriesCalculator.CalculateHowManyCaloriesTopThreeElvesCarryingInTotal(caloriesList)}");
