namespace DayFive.Domain.CargoCraneFeatures;

public interface ICargoCraneMovingStrategy
{
    void Execute(Stack<char> source, Stack<char> destination, int howMany);
}
