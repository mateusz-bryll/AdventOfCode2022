using AdventOfCode.Tasks.Sdk;
using DaySeven.Domain;

namespace DaySeven;

public class DaySevenTasks : ITasks
{
    public int DayNumber => 7;
    
    [TaskResultDescription("is the sum of the total sizes of directories with a total size of at most 100000")]
    public int GetBasicTaskResult(IEnumerable<string> input)
    {
        const int maxDirectorySize = 100_000;
        var fileSystem = TerminalOutputParser.ParseFileSystemStructure(input);
        return fileSystem.Directories
            .Where(dir => dir.Size <= maxDirectorySize)
            .Sum(dir => dir.Size);
    }

    [TaskResultDescription("is the total size of the smallest directory to delete")]
    public int GetAdvancedTaskResult(IEnumerable<string> input)
    {
        const int requiredSpace = 30_000_000;
        var fileSystem = TerminalOutputParser.ParseFileSystemStructure(input);
        var minSizeOfDirectoryToDelete = requiredSpace - fileSystem.FreeSpace;
        return fileSystem.Directories
            .Where(dir => dir.Size >= minSizeOfDirectoryToDelete)
            .Min(dir => dir.Size);
    }
}
