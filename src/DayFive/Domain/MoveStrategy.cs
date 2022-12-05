namespace DayFive.Domain;

public interface IMoveStrategy
{
    void Execute(Stack<char> source, Stack<char> destination, int howMany);
}

public class CrateMover9000MoveStrategy : IMoveStrategy
{
    public void Execute(Stack<char> source, Stack<char> destination, int howMany)
    {
        for (var i = 0; i < howMany; i++)
            destination.Push(source.Pop());
    }
}

public class CrateMover9001MoveStrategy : IMoveStrategy
{
    public void Execute(Stack<char> source, Stack<char> destination, int howMany)
    {
        var buffer = new Stack<char>();
        
        for (var i = 0; i < howMany; i++)
            buffer.Push(source.Pop());
        
        for (var i = 0; i < howMany; i++)
            destination.Push(buffer.Pop());
    }
}