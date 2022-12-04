using DayFour.Domain;

var assignmentStrings = File.ReadLines("./input");

Console.WriteLine($"Part 1 answer: {CampCleanup.CountHowManyAssignmentPairsDoesOneRangeFullyContainTheOther(assignmentStrings)}");
Console.WriteLine($"Part 2 answer: {CampCleanup.CountHowManyAssignmentPairsDoesOneRangeOverlapTheOther(assignmentStrings)}");
