using DayFive.Domain;

namespace DayFive;

public static class InputParser
{
    public static SupplyStacks ParseSupplyStacksInitialState(IEnumerable<string> inputLines, out int parsedLines)
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
            foreach (var crate in ParseCratesLine(numberOfStacks, cratesLine))
            {
                supplyStacks.PlaceCrateOnStack(crate.StackNumber, crate.Crate);
            }
        }

        return supplyStacks;
    }

    public static SupplyStacksMoveCommand ParseMoveCommand(string moveCommandLine)
    {
        var parts = moveCommandLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return new SupplyStacksMoveCommand(int.Parse(parts[1]), int.Parse(parts[3]), int.Parse(parts[5]));
    }
    
    private static IEnumerable<(int StackNumber, char Crate)> ParseCratesLine(int numberOfStacks, string cratesLine)
    {
        const int crateSize = 4;
        for (int i = 1, j = 1; i < numberOfStacks * crateSize; i += crateSize, j++)
        {
            if (cratesLine[i] == ' ')
                continue;
            
            yield return (j, cratesLine[i]);
        }
    }
}
