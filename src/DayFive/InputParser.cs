using DayFive.Domain;
using DayFive.Domain.CargoCraneFeatures;

namespace DayFive;

public static class InputParser
{
    public static (SupplyStacks SupplyStacks, IEnumerable<CargoCraneMoveOperation> CratesRearrangeProcedure) ParseInput(IEnumerable<string> inputLines)
    {
        var supplyStacks = ParseSupplyStacksCurrentState(inputLines, out var parsedLines);

        return (supplyStacks, inputLines.Skip(parsedLines).Select(ParseCargoCraneMoveOperation));
    }

    private static SupplyStacks ParseSupplyStacksCurrentState(IEnumerable<string> inputLines, out int parsedLines)
    {
        parsedLines = 0;
        var supplyStacksStateLines = new Stack<string>();
        foreach (var line in inputLines)
        {
            parsedLines++;
            
            if (string.IsNullOrEmpty(line))
                break;

            supplyStacksStateLines.Push(line);
        }

        var labelsLine = supplyStacksStateLines.Pop();
        var numberOfStacks = int.Parse(labelsLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).Last());

        var supplyStacks = new SupplyStacks(numberOfStacks);

        while (supplyStacksStateLines.Count > 0)
        {
            var cratesLine = supplyStacksStateLines.Pop();
            foreach (var crate in ParseCrates(numberOfStacks, cratesLine))
                supplyStacks.PlaceCrateOnStack(crate.StackNumber, crate.Crate);
        }

        return supplyStacks;
    }

    private static CargoCraneMoveOperation ParseCargoCraneMoveOperation(string moveCommandLine)
    {
        var parts = new StringParts(moveCommandLine, ' ');
        return new CargoCraneMoveOperation(int.Parse(parts[1]), int.Parse(parts[3]), int.Parse(parts[5]));
    }
    
    private static IEnumerable<(int StackNumber, char Crate)> ParseCrates(int numberOfStacks, string cratesLine)
    {
        const int gapBetweenCrates = 4;
        for (int i = 1, j = 1; i < numberOfStacks * gapBetweenCrates; i += gapBetweenCrates, j++)
        {
            if (cratesLine[i] == ' ')
                continue;
            
            yield return (j, cratesLine[i]);
        }
    }
    
    private readonly ref struct StringParts
    {
        private readonly string text;
        private readonly char separator;
    
        public StringParts(string text, char separator)
        {
            this.text = text;
            this.separator = separator;
        }
    
        public ReadOnlySpan<char> this[int index]
        {
            get
            {
                var span = text.AsSpan();
                for (var i = 0; i < index; i++)
                {
                    var separatorIndex = span.IndexOf(separator);
                    span = span[(separatorIndex + 1)..];
                }
            
                var endOfCurrentMatch = span.IndexOf(separator);
                return endOfCurrentMatch >= 0 ? span[..endOfCurrentMatch] : span;
            }
        }
    }
}
