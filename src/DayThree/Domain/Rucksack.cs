using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DayThree.Domain;

internal readonly ref struct Rucksack
{
    private readonly ReadOnlySpan<char> allItems;
    private const int LowerLetterAsciiOffset = 96;
    private const int UpperLetterAsciiOffset = 38;
    private int ItemsCount => allItems.Length;

    public Rucksack(ReadOnlySpan<char> allItems)
    {
        if (allItems.Length % 2 != 0)
            throw new InvalidOperationException();
        
        this.allItems = allItems;
    }

    public int GetPriorityOfItemThatAppearsInBothCompartments()
    {
        ref var allItemsReference = ref MemoryMarshal.GetReference(allItems);
        for (var i = 0; i < ItemsCount / 2; i++)
        {
            for (var j = ItemsCount / 2; j < ItemsCount; j++)
            {
                var firstCompartmentItem = Unsafe.Add(ref allItemsReference, i);
                var secondCompartmentItem = Unsafe.Add(ref allItemsReference, j);
                if (firstCompartmentItem == secondCompartmentItem)
                    return CalculateItemPriority(ref secondCompartmentItem);
            }
        }

        throw new UnreachableException();
    }

    public static int FindPriorityOfBadgeItem(Rucksack rucksackA, Rucksack rucksackB, Rucksack rucksackC)
    {
        var maximumCommonItemsInTwoFirstRucksacks = Math.Min(rucksackA.ItemsCount, rucksackB.ItemsCount);
        Span<char> commonItemsInFirstTwoRucksacks = stackalloc char[maximumCommonItemsInTwoFirstRucksacks];
        FindCommonItems(rucksackA.allItems, rucksackB.allItems, commonItemsInFirstTwoRucksacks, out var commonItemsInFirstTwoRucksacksCount);
        
        var maximumCommonItemsInTwoLastRucksacks = Math.Min(commonItemsInFirstTwoRucksacksCount, rucksackC.ItemsCount);
        Span<char> commonItemsInLastTwoRucksacks = stackalloc char[maximumCommonItemsInTwoLastRucksacks];
        FindCommonItems(commonItemsInFirstTwoRucksacks[..commonItemsInFirstTwoRucksacksCount], rucksackC.allItems, commonItemsInLastTwoRucksacks, out _);
        
        return CalculateItemPriority(ref commonItemsInLastTwoRucksacks[0]);

        void FindCommonItems(ReadOnlySpan<char> firstSequence, ReadOnlySpan<char> secondSequence, Span<char> result, out int resultItemCount)
        {
            ref var firstItemsSequenceReference = ref MemoryMarshal.GetReference(firstSequence);
            ref var secondItemsSequenceReference = ref MemoryMarshal.GetReference(secondSequence);
            
            var index = 0;
            for (var i = 0; i < firstSequence.Length; i++)
            {
                for (var j = 0; j < secondSequence.Length; j++)
                {
                    var firstItem = Unsafe.Add(ref firstItemsSequenceReference, i);
                    var secondItem = Unsafe.Add(ref secondItemsSequenceReference, j);
                    if (firstItem == secondItem)
                    {
                        if (result.IndexOf(firstItem) == -1)
                        {
                            result[index] = firstItem;
                            index++;
                        }
                    }
                }
            }

            resultItemCount = index;
        }
    }

    private static int CalculateItemPriority(ref char item) => 
        char.IsAsciiLetterLower(item) ? 
            item - LowerLetterAsciiOffset :
            item - UpperLetterAsciiOffset;
}