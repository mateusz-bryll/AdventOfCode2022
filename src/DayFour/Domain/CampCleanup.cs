namespace DayFour.Domain;

public static class CampCleanup
{
    public static int CountHowManyAssignmentPairsDoesOneRangeFullyContainTheOther(IEnumerable<string> assignmentStrings) =>
        assignmentStrings.Count(assignmentString => ElvesAssignmentPair.Parse(assignmentString).IsOneRangeContainsOther());
    
    public static int CountHowManyAssignmentPairsDoesOneRangeOverlapTheOther(IEnumerable<string> assignmentStrings) =>
        assignmentStrings.Count(assignmentString => ElvesAssignmentPair.Parse(assignmentString).IsOneRangeOverlapsOther());
}
