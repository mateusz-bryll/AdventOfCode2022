using AdventOfCode.Tasks.Sdk;
using DayTen.Domain;

namespace DayTen;

public sealed class DayTenTasks : ITasks<int, string>
{
    public int DayNumber => 10;
    
    [TaskResultDescription("is the sum of the six signal strengths")]
    public int GetBasicTaskResult(IEnumerable<string> input)
    {
        var result = 0;
        
        var cpu = new Cpu((cycles, x) =>
        {
            if (cycles is 20 or 60 or 100 or 140 or 180 or 220)
                result += (cycles * x);
        });

        foreach (var instruction in input)
            cpu.ExecuteInstruction(instruction);

        return result;
    }

    public string GetAdvancedTaskResult(IEnumerable<string> input)
    {
        var crt = new Crt();
        var cpu = new Cpu(crt.RenderPixel);

        foreach (var instruction in input)
            cpu.ExecuteInstruction(instruction);
        
        return crt.GetRenderedPicture();
    }
}