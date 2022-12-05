using DayFive.Domain.CargoCraneFeatures;

namespace DayFive.Domain;

public class CargoCrane
{
    private readonly ICargoCraneMovingStrategy cargoCraneMovingStrategy;

    public CargoCrane(ICargoCraneMovingStrategy cargoCraneMovingStrategy)
    {
        this.cargoCraneMovingStrategy = cargoCraneMovingStrategy;
    }

    public void MoveCranes(CargoCraneMoveOperation operation, SupplyStacks supplyStacks)
    {
        var source = supplyStacks[operation.FromStack];
        var destination = supplyStacks[operation.ToStack];
        
        cargoCraneMovingStrategy.Execute(source, destination, operation.HowMany);
    }
}