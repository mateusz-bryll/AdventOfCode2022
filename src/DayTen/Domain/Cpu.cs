namespace DayTen.Domain;

internal class Cpu
{
    public delegate void TickCallback(int cycles, int x);
    private readonly TickCallback tickCallback;

    private int registerX;
    private int cycles;
    
    public Cpu(TickCallback tickCallback)
    {
        this.tickCallback = tickCallback;
        registerX = 1;
        cycles = 0;
    }

    public void ExecuteInstruction(ReadOnlySpan<char> instruction)
    {
        switch (instruction[..4])
        {
            case "noop":
                tickCallback(++cycles, registerX);
                break;
            case "addx":
                tickCallback(++cycles, registerX);
                tickCallback(++cycles, registerX);
                registerX += int.Parse(instruction[5..]);
                break;
        }
    }
}
