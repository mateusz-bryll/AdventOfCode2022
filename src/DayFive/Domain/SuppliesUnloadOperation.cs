using DayFive.Domain.CargoCraneFeatures;

namespace DayFive.Domain;

public static class SuppliesUnloadOperation
{
    public static void RearrangeCrates(SupplyStacks supplyStacks, CargoCrane cargoCrane, IEnumerable<CargoCraneMoveOperation> cratesRearrangeProcedure)
    {
        foreach (var cargoCraneMoveOperation in cratesRearrangeProcedure)
            cargoCrane.MoveCranes(cargoCraneMoveOperation, supplyStacks);
    }
}
