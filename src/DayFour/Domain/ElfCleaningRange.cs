namespace DayFour.Domain;

public readonly ref struct ElfCleaningRange
{
    public int Start { get; }
    public int End { get; }

    internal ElfCleaningRange(int start, int end)
    {
        Start = start;
        End = end;
    }

    public bool Contains(ElfCleaningRange range) => Start <= range.Start && End >= range.End;
    public bool Overlaps(ElfCleaningRange range) => (range.Start >= Start && range.Start <= End) || (range.End >= Start && range.End <= End);

    public static ElfCleaningRange Parse(ReadOnlySpan<char> rangeString)
    {
        var dashIndex = rangeString.IndexOf('-');
        var start = int.Parse(rangeString[..dashIndex]);
        var end = int.Parse(rangeString[(dashIndex+1)..]);

        return new ElfCleaningRange(start, end);
    }
}