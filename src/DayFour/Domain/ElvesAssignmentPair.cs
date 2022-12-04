namespace DayFour.Domain;

public readonly ref struct ElvesAssignmentPair
{
    public ElfCleaningRange FirstElfRange { get; }
    public ElfCleaningRange SecondElfRange { get; }

    internal ElvesAssignmentPair(ElfCleaningRange firstElfRange, ElfCleaningRange secondElfRange)
    {
        FirstElfRange = firstElfRange;
        SecondElfRange = secondElfRange;
    }

    public bool IsOneRangeContainsOther() => FirstElfRange.Contains(SecondElfRange) || SecondElfRange.Contains(FirstElfRange);
    public bool IsOneRangeOverlapsOther() => FirstElfRange.Overlaps(SecondElfRange) || SecondElfRange.Overlaps(FirstElfRange);

    public static ElvesAssignmentPair Parse(ReadOnlySpan<char> elvesAssignmentPairString)
    {
        var commaIndex = elvesAssignmentPairString.IndexOf(',');
        var firstElfRange = ElfCleaningRange.Parse(elvesAssignmentPairString[..commaIndex]);
        var secondElfRange = ElfCleaningRange.Parse(elvesAssignmentPairString[(commaIndex+1)..]);

        return new ElvesAssignmentPair(firstElfRange, secondElfRange);
    }
}
