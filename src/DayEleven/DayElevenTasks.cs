using AdventOfCode.Tasks.Sdk;
using DayEleven.Domain;

namespace DayEleven;

public class DayElevenTasks : ITasks<ulong>
{
    public int DayNumber => 11;
    
    [TaskResultDescription("is the monkey business for basic task")]
    public ulong GetBasicTaskResult(IEnumerable<string> input)
    {
        var monkeys = input.Select((line, index) => (line, index))
            .GroupBy(x => x.index / 7)
            .Select(batch => MonkeyParser.ParseMonkeyFromNotes(batch.Select(x => x.line).ToArray()))
            .ToArray();

        var game = new MonkeyKeepAwayGame(monkeys, MonkeyKeepAwayGame.WorryLevelAdjustmentStrategy.Basic);
        game.PlayRounds(20);

        var monkeyBusiness = monkeys.OrderByDescending(monkey => monkey.InspectionsCount)
            .Take(2)
            .Aggregate(1ul, (x, y) => x * y.InspectionsCount);

        return monkeyBusiness;
    }

    [TaskResultDescription("is the monkey business for advanced task")]
    public ulong GetAdvancedTaskResult(IEnumerable<string> input)
    {
        var monkeys = input.Select((line, index) => (line, index))
            .GroupBy(x => x.index / 7)
            .Select(batch => MonkeyParser.ParseMonkeyFromNotes(batch.Select(x => x.line).ToArray()))
            .ToArray();

        var game = new MonkeyKeepAwayGame(monkeys, MonkeyKeepAwayGame.WorryLevelAdjustmentStrategy.Advanced);
        game.PlayRounds(10000);

        var monkeyBusiness = monkeys.OrderByDescending(monkey => monkey.InspectionsCount)
            .Take(2)
            .Aggregate(1ul, (x, y) => x * y.InspectionsCount);

        return monkeyBusiness;
    }
}