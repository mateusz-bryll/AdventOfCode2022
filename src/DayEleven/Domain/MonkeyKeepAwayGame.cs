namespace DayEleven.Domain;

internal class MonkeyKeepAwayGame
{
    private readonly Monkey[] monkeys;
    private readonly WorryLevelAdjustmentStrategy strategy;
    private readonly ulong lcm;

    public MonkeyKeepAwayGame(Monkey[] monkeys, WorryLevelAdjustmentStrategy strategy)
    {
        this.monkeys = monkeys;
        this.strategy = strategy;

        lcm = 1;
        foreach (var monkey in this.monkeys)
            lcm *= monkey.Strategy.Divider;
    }

    public void PlayRounds(int roundsCount)
    {
        Func<ulong, ulong> adjustWorryLevelStrategy = strategy == WorryLevelAdjustmentStrategy.Basic
            ? BasicWorryLevelAdjustmentStrategy
            : AdvancedWorryLevelAdjustmentStrategy;
        
        for (var i = 0; i < roundsCount; i++)
        {
            foreach (var monkey in monkeys)
                monkey.PlayRound(monkeys, adjustWorryLevelStrategy);
        }
    }

    private static ulong BasicWorryLevelAdjustmentStrategy(ulong worryLevel) => (ulong)Math.Floor(worryLevel / 3.0);
    private ulong AdvancedWorryLevelAdjustmentStrategy(ulong worryLevel) => worryLevel % lcm;

    public enum WorryLevelAdjustmentStrategy
    {
        Basic,
        Advanced
    }
}
