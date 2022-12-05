namespace DayFive.Domain.CargoCraneFeatures;

public class CrateMover9000MovingStrategy : ICargoCraneMovingStrategy
{
    public void Execute(Stack<char> source, Stack<char> destination, int howMany)
    {
        for (var i = 0; i < howMany; i++)
            destination.Push(source.Pop());
    }
}
