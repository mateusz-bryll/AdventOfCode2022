namespace DayThree.Domain;

internal static class RucksackPriorityCalculator
{
    public static int CalculateSumOfPrioritiesForEncodedRucksacks(IEnumerable<string> encodedRucksacks)
    {
        var sum = 0;
        foreach (var encodedRucksack in encodedRucksacks)
        {
            var rucksack = new Rucksack(encodedRucksack);
            sum += rucksack.GetPriorityOfItemThatAppearsInBothCompartments();
        }

        return sum;
    }

    public static int CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks(IEnumerable<string> encodedRucksacks)
    {
        var groups = encodedRucksacks.Select((encodedRucksack, index) => (encodedRucksack, index))
            .GroupBy(x => x.index / 3)
            .Select(x => x.Select(y => y.encodedRucksack).ToArray());

        var sum = 0;
        foreach (var group in groups)
        {
            var rucksackA = new Rucksack(group[0]);
            var rucksackB = new Rucksack(group[1]);
            var rucksackC = new Rucksack(group[2]);

            sum += Rucksack.FindPriorityOfBadgeItem(rucksackA, rucksackB, rucksackC);
        }
        
        return sum;
    }
}
