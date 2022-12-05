using AdventOfCode.Tasks.Sdk;
using DayFive.Domain;

namespace DayFive;

public class DayFiveTasks : ITasks<string>
{
    public int DayNumber => 5;
    
    [TaskResultDescription("are the crates on top of each stack (CrateMover 9000)")]
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

    [TaskResultDescription("are the crates on top of each stack (CrateMover 9001)")]
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
