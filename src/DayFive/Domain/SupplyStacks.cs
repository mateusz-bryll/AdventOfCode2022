namespace DayFive.Domain;

public class SupplyStacks
{
    private readonly Stack<char>[] stacks;
    
    public Stack<char> this[int stackNumber] => stacks[stackNumber - 1];
    
    public SupplyStacks(int numberOfStacks)
    {
        stacks = new Stack<char>[numberOfStacks];
        for (var i = 0; i < numberOfStacks; i++)
            stacks[i] = new Stack<char>();
    }

    public string GetCratesFromTopOfEveryStack() => new (stacks.Select(stack => stack.Peek()).ToArray());
    
    public void PlaceCrateOnStack(int stackNumber, char crate) => this[stackNumber].Push(crate);
}
