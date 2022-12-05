namespace DayFive.Domain.CargoCraneFeatures;

public class CrateMover9001MovingStrategy : ICargoCraneMovingStrategy
{
    public void Execute(Stack<char> source, Stack<char> destination, int howMany)
    {
        Span<char> buffer = stackalloc char[howMany];
        
        for (var i = 0; i < howMany; i++)
            buffer[i] = source.Pop();
        
        for (var i = howMany - 1; i >= 0; i--)
            destination.Push(buffer[i]);
    }
}
