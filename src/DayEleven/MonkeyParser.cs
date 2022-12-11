using DayEleven.Domain;

namespace DayEleven;

internal static class MonkeyParser
{
    private static MonkeyOperation CreateMultiplyOperation(uint multiplyBy) => x => x * multiplyBy;
    private static MonkeyOperation CreateAddOperation(uint multiplyBy) => x => x + multiplyBy;
    private static MonkeyOperation Square => x => x * x;

    public static Monkey ParseMonkeyFromNotes(string[] monkeyNotes)
    {
        var items = ParseStartingItems(monkeyNotes[1]);
        var operation = ParseOperation(monkeyNotes[2]);
        var strategy = ParseStrategy(monkeyNotes[3..]);
        
        return new Monkey(operation, strategy, items);
    }

    private static IEnumerable<ulong> ParseStartingItems(string startingItemsLine)
    {
        var itemsCommaSeparated = startingItemsLine[18..];
        var items = itemsCommaSeparated.Split(", ", StringSplitOptions.RemoveEmptyEntries);

        return items.Select(ulong.Parse);
    }
    
    private static MonkeyOperation ParseOperation(string operationLine)
    {
        var span = operationLine.AsSpan();
        var operand = span.Slice(23, 1);
        var rhs = span[25..];

        if (operand[0] == '+')
            return CreateAddOperation(uint.Parse(rhs));
        
        return rhs.SequenceEqual("old") ? Square : CreateMultiplyOperation(uint.Parse(rhs));
    }
    
    private static MonkeyStrategy ParseStrategy(string[] strategyLines)
    {
        var divider = uint.Parse(strategyLines[0].AsSpan()[21..]);
        var throwToMonkeyIfTestTrue = int.Parse(strategyLines[1].AsSpan()[29..]);
        var throwToMonkeyIfTestFalse = int.Parse(strategyLines[2].AsSpan()[30..]);
        
        return new MonkeyStrategy(divider, throwToMonkeyIfTestTrue, throwToMonkeyIfTestFalse);
    }
}
