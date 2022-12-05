namespace DayFive.Domain;

public class SupplyStacksMoveCommand
{
    public int HowMany { get; }
    public int FromStackNumber { get; }
    public int ToStackNumber { get; }

    public SupplyStacksMoveCommand(int howMany, int fromStackNumber, int toStackNumber)
    {
        HowMany = howMany;
        FromStackNumber = fromStackNumber;
        ToStackNumber = toStackNumber;
    }
}

public class SupplyStacks
{
    private readonly Stack<char>[] stacks;
    private Stack<char> this[int stackNumber] => stacks[stackNumber - 1];
    
    public SupplyStacks(int numberOfStacks)
    {
        stacks = new Stack<char>[numberOfStacks];
        for (var i = 0; i < numberOfStacks; i++)
            stacks[i] = new Stack<char>();
    }

    public string GetCratesFromTopOfEveryStack() => new (stacks.Select(stack => stack.Peek()).ToArray());
    public void PlaceCrateOnStack(int stackNumber, char crate) => this[stackNumber].Push(crate);

    public void Move(SupplyStacksMoveCommand command, IMoveStrategy moveStrategy)
    {
        moveStrategy.Execute(this[command.FromStackNumber], this[command.ToStackNumber], command.HowMany);
    }
}
