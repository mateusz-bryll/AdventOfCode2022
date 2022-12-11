namespace DayEleven.Domain;

public delegate ulong MonkeyOperation(ulong old);

internal class Monkey
{
    public ulong InspectionsCount { get; private set; } = 0;
    
    private readonly Queue<ulong> items;
    private readonly MonkeyOperation monkeyOperation;

    public MonkeyStrategy Strategy { get; }

    public Monkey(MonkeyOperation monkeyOperation, MonkeyStrategy monkeyStrategy, IEnumerable<ulong> initialItems)
    {
        this.monkeyOperation = monkeyOperation;
        this.Strategy = monkeyStrategy;
        this.items = new Queue<ulong>(initialItems);
    }

    public void PlayRound(Monkey[] monkeys, Func<ulong, ulong> adjustWorryLevel)
    {
        while (items.Count > 0)
        {
            var item = items.Dequeue();
            var worryLevel = monkeyOperation(item);
            InspectionsCount++;
            worryLevel = adjustWorryLevel(worryLevel);
            var toWhichMonkeyToThrowTheItem = Strategy.ToWhichMonkeyToThrowTheItem(worryLevel);
            monkeys[toWhichMonkeyToThrowTheItem].CatchItem(worryLevel);
        }
    }

    public void CatchItem(ulong item)
    {
        items.Enqueue(item);
    }
}

internal class MonkeyStrategy
{
    private readonly int throwToMonkeyIfTestTrue;
    private readonly int throwToMonkeyIfTestFalse;

    public uint Divider { get; }

    public MonkeyStrategy(uint divider, int throwToMonkeyIfTestTrue, int throwToMonkeyIfTestFalse)
    {
        this.Divider = divider;
        this.throwToMonkeyIfTestTrue = throwToMonkeyIfTestTrue;
        this.throwToMonkeyIfTestFalse = throwToMonkeyIfTestFalse;
    }

    public int ToWhichMonkeyToThrowTheItem(ulong worryLevel) =>
        worryLevel % Divider == 0 ? throwToMonkeyIfTestTrue : throwToMonkeyIfTestFalse;
}
