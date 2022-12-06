namespace DaySix.Domain;

public static class SignalDecoder
{
    private const int StartPacketMarkerSize = 4;
    private const int StartMessageMarkerSize = 14;
    
    public static int GetIndexOfFirstPacketDataCharacter(string buffer) =>
        FindIndexOfFirstCharacterAfterStartSequence(buffer, StartPacketMarkerSize);
    
    public static int GetIndexOfFirstMessageDataCharacter(string buffer) =>
        FindIndexOfFirstCharacterAfterStartSequence(buffer, StartMessageMarkerSize);

    private static int FindIndexOfFirstCharacterAfterStartSequence(string buffer, int startSequenceMarkerSize)
    {
        var span = buffer.AsSpan();
        for (var i = 0; i < buffer.Length - (startSequenceMarkerSize - 1); i++)
        {
            if (AllDifferent(span.Slice(i, startSequenceMarkerSize)))
                return i + startSequenceMarkerSize;
        }

        return -1;
    }

    private static bool AllDifferent(ReadOnlySpan<char> sequence)
    {
        for (var i = 0; i < sequence.Length - 1; i++)
        {
            for (var j = i + 1; j < sequence.Length; j++)
            {
                if (sequence[i] == sequence[j])
                    return false;
            }
        }

        return true;
    }
}
