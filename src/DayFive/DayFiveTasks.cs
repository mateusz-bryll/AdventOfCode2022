using AdventOfCode.Tasks.Sdk;
using DayFive.Domain;

namespace DayFive;

public class DayFiveTasks : ITasks<string>
{
    public int DayNumber => 5;
    
    public string GetBasicTaskResult(IEnumerable<string> input)
    {
        var supplyStacks = InputParser.ParseSupplyStacksInitialState(input, out var parsedLines);
        foreach (var line in input.Skip(parsedLines))
        {
            var moveCommand = InputParser.ParseMoveCommand(line);
            supplyStacks.Move(moveCommand, new CrateMover9000MoveStrategy());
        }

        return supplyStacks.GetCratesFromTopOfEveryStack();
    }

    public string GetAdvancedTaskResult(IEnumerable<string> input)
    {
        var supplyStacks = InputParser.ParseSupplyStacksInitialState(input, out var parsedLines);
        foreach (var line in input.Skip(parsedLines))
        {
            var moveCommand = InputParser.ParseMoveCommand(line);
            supplyStacks.Move(moveCommand, new CrateMover9001MoveStrategy());
        }

        return supplyStacks.GetCratesFromTopOfEveryStack();
    }
}
