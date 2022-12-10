using System.Text;

namespace DayTen.Domain;

internal class Crt
{
    private readonly byte[][] videoMemory;
    private const int RowSize = 40;
    
    public Crt()
    {
        videoMemory = new[]
        {
            new byte[RowSize],
            new byte[RowSize],
            new byte[RowSize],
            new byte[RowSize],
            new byte[RowSize],
            new byte[RowSize],
        };
    }
    
    public void RenderPixel(int cycle, int spriteMiddlePoint)
    {
        var row = (int)Math.Ceiling(cycle / (double)RowSize) - 1;
        var column = (cycle - 1) % RowSize;

        var characterToPrint = column >= spriteMiddlePoint - 1 && column <= spriteMiddlePoint + 1 ? (byte)'#' : (byte)' ';
        videoMemory[row][column] = characterToPrint;
    }

    public string GetRenderedPicture()
    {
        var sb = new StringBuilder();
        
        for (var i = 0; i < videoMemory.Length; i++)
        {
            if (i == 0)
                sb.AppendLine(Encoding.ASCII.GetString(videoMemory[i]));
            else
                sb.AppendLine($"\t\t\t\t{Encoding.ASCII.GetString(videoMemory[i])}");
        }
        
        return sb.ToString();
    }
}
