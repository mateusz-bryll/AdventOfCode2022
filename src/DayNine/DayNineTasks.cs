using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using AdventOfCode.Tasks.Sdk;

namespace DayNine;

public sealed class DayNineTasks : ITasks
{
    public int DayNumber => 9;

    [TaskResultDescription("unique points the tail visited at least once when rope length is equal to 2")]
    public int GetBasicTaskResult(IEnumerable<string> input) =>
        CalculateHowManyPointsLastKnotVisited(2, input);

    [TaskResultDescription("unique points the tail visited at least once when rope length is equal to 10")]
    public int GetAdvancedTaskResult(IEnumerable<string> input) =>
        CalculateHowManyPointsLastKnotVisited(10, input);

    internal static int CalculateHowManyPointsLastKnotVisited(int knotsCount, IEnumerable<string> moves)
    {
        var result = new HashSet<(int X, int Y)>();
        var knots = new (int X, int Y)[knotsCount];
        Array.Fill(knots, (0, 0));

        result.Add((0, 0));
        foreach (var move in moves)
        {
            var moveSpan = move.AsSpan();
            var direction = moveSpan[0];
            var steps = int.Parse(moveSpan[2..]);

            for (var i = 0; i < steps; i++)
            {
                MoveHead(ref knots[0], ref direction);
                for (var j = 1; j < knots.Length; j++)
                {
                    MoveTailAccordingToHead(ref knots[j], ref knots[j - 1]);
                }
                result.Add(knots.Last());
            }
        }
        
        return result.Count;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void MoveHead(ref (int X, int Y) head, ref char direction)
    {
        head = direction switch
        {
            'R' => (++head.X, head.Y),
            'L' => (--head.X, head.Y),
            'U' => (head.X, ++head.Y),
            'D' => (head.X, --head.Y),
            _ => throw new UnreachableException()
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void MoveTailAccordingToHead(ref (int X, int Y) tail, ref (int X, int Y) head)
    {
        var offsetX = head.X - tail.X;
        var offsetY = head.Y - tail.Y;

        switch (Math.Abs(offsetX), Math.Abs(offsetY))
        {
            case (0, 0):
                break;
            case (0, _):
                tail.Y += offsetY < 0 ? offsetY + 1 : offsetY - 1;
                break;
            case (_, 0):
                tail.X += offsetX < 0 ? offsetX + 1 : offsetX - 1;
                break;
            case (2, _):
                tail.X += offsetX > 0 ? 1 : -1;
                tail.Y += offsetY > 0 ? 1 : -1;
                break;
            case (_, 2):
                tail.X += offsetX > 0 ? 1 : -1;
                tail.Y += offsetY > 0 ? 1 : -1;
                break;
        }
    }
}
