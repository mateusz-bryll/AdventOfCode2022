using AdventOfCode.Tasks.Sdk;
using DayFour.Domain;

namespace DayFour;

public class DayFourTasks : ITasks
{
    public int DayNumber => 4;

    [TaskResultDescription("assignment pairs that one range fully contain the other")]
    public int GetBasicTaskResult(IEnumerable<string> input) =>
        CampCleanup.CountHowManyAssignmentPairsDoesOneRangeFullyContainTheOther(input);

    [TaskResultDescription("assignment pairs that the ranges overlap")]
    public int GetAdvancedTaskResult(IEnumerable<string> input) =>
        CampCleanup.CountHowManyAssignmentPairsDoesOneRangeOverlapTheOther(input);
}
