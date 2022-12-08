using System.Collections.Immutable;
using AdventOfCode.Tasks.Sdk;

namespace DayEight;

public class DayEightTasks : ITasks
{
    public int DayNumber => 8;
    
    [TaskResultDescription("trees are visible from outside the grid")]
    public int GetBasicTaskResult(IEnumerable<string> input)
    {
        var map = input.ToImmutableArray();
        var rowsCount = map.Length;
        var columnsCount = map[0].Length;
        var visibleTrees = (2 * rowsCount) + (2 * (columnsCount - 2));

        Span<char> columnSpan = stackalloc char[rowsCount];
        for (var column = 1; column < columnsCount - 1; column++)
        {
            for (var i = 0; i < rowsCount; i++)
                columnSpan[i] = map[i][column];
            
            for (var row = 1; row < rowsCount - 1; row++)
            {
                var rowSpan = map[row].AsSpan();
                var element = rowSpan[column];
                
                if (IsVisible(ref element, rowSpan[..column]) ||
                    IsVisible(ref element, rowSpan[(column + 1)..]) ||
                    IsVisible(ref element, columnSpan[..row]) ||
                    IsVisible(ref element, columnSpan[(row + 1)..]))
                {
                    visibleTrees++;
                }
            }
        }

        return visibleTrees;

        bool IsVisible(ref char element, ReadOnlySpan<char> elements)
        {
            for (var i = 0; i < elements.Length; i++)
            {
                if (element <= elements[i])
                    return false;
            }

            return true;
        }
    }

    [TaskResultDescription("is the highest scenic score possible for any tree")]
    public int GetAdvancedTaskResult(IEnumerable<string> input)
    {
        var map = input.ToImmutableArray();
        var rowsCount = map.Length;
        var columnsCount = map[0].Length;
        var scenicScore = 0;

        Span<char> columnSpan = stackalloc char[rowsCount];
        for (var column = 1; column < columnsCount - 1; column++)
        {
            for (var i = 0; i < rowsCount; i++)
                columnSpan[i] = map[i][column];
            
            for (var row = 1; row < rowsCount - 1; row++)
            {
                var rowSpan = map[row].AsSpan();
                var element = rowSpan[column];

                var scoreLeft = CalculateScenicScore(ref element, rowSpan[..column], ScoreCalculationStrategy.Backward);
                var scoreRight = CalculateScenicScore(ref element, rowSpan[(column + 1)..], ScoreCalculationStrategy.Forward);
                var scoreUp = CalculateScenicScore(ref element, columnSpan[..row], ScoreCalculationStrategy.Backward);
                var scoreDown = CalculateScenicScore(ref element, columnSpan[(row + 1)..], ScoreCalculationStrategy.Forward);
                var score = scoreLeft * scoreRight * scoreUp * scoreDown;

                if (score > scenicScore)
                    scenicScore = score;
            }
        }

        return scenicScore;

        int CalculateScenicScore(ref char element, ReadOnlySpan<char> elements, ScoreCalculationStrategy strategy)
        {
            var score = 0;

            if (strategy == ScoreCalculationStrategy.Forward)
            {
                for (var i = 0; i < elements.Length; i++)
                {
                    if (element > elements[i])
                        score++;

                    if (element <= elements[i])
                        return ++score;
                }
            }
            else
            {
                for (var i = elements.Length - 1; i >= 0; i--)
                {
                    if (element > elements[i])
                        score++;

                    if (element <= elements[i])
                        return ++score;
                }
            }

            return score;
        }
    }

    private enum ScoreCalculationStrategy
    {
        Forward,
        Backward
    }
}
