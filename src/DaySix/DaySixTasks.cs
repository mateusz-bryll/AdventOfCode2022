using AdventOfCode.Tasks.Sdk;
using DaySix.Domain;

namespace DaySix;

public class DaySixTasks : ITasks
{
    public int DayNumber => 6;
    
    [TaskResultDescription("characters need to be processed before the first start-of-packet marker is detected")]
    public int GetBasicTaskResult(IEnumerable<string> input)
    {
        return SignalDecoder.GetIndexOfFirstPacketDataCharacter(input.First());
    }

    [TaskResultDescription("characters need to be processed before the first start-of-message marker is detected")]
    public int GetAdvancedTaskResult(IEnumerable<string> input)
    {
        return SignalDecoder.GetIndexOfFirstMessageDataCharacter(input.First());
    }
}
