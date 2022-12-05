namespace DayFive.Domain.CargoCraneFeatures;

public class CargoCraneMoveOperation
{
    public int HowMany { get; }
    public int FromStack { get; }
    public int ToStack { get; }

    public CargoCraneMoveOperation(int howMany, int fromStack, int toStack)
    {
        HowMany = howMany;
        FromStack = fromStack;
        ToStack = toStack;
    }
}
