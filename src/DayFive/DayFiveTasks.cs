using AdventOfCode.Tasks.Sdk;
using DayFive.Domain;
using DayFive.Domain.CargoCraneFeatures;

namespace DayFive;

public class DayFiveTasks : ITasks<string>
{
    public int DayNumber => 5;
    
    [TaskResultDescription("are the crates on top of each stack (CrateMover 9000)")]
    public string GetBasicTaskResult(IEnumerable<string> input)
    {
        var (supplyStacks, cratesRearrangeProcedure) = InputParser.ParseInput(input);

        SuppliesUnloadOperation.RearrangeCrates(supplyStacks, new CargoCrane(new CrateMover9000MovingStrategy()), cratesRearrangeProcedure); 

        return supplyStacks.GetCratesFromTopOfEveryStack();
    }

    [TaskResultDescription("are the crates on top of each stack (CrateMover 9001)")]
    public string GetAdvancedTaskResult(IEnumerable<string> input)
    {
        var (supplyStacks, cratesRearrangeProcedure) = InputParser.ParseInput(input);

        SuppliesUnloadOperation.RearrangeCrates(supplyStacks, new CargoCrane(new CrateMover9001MovingStrategy()), cratesRearrangeProcedure); 

        return supplyStacks.GetCratesFromTopOfEveryStack();
    }
}
