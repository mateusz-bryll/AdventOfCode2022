namespace DaySeven.Domain;

public static class TerminalOutputParser
{
    public static FileSystem ParseFileSystemStructure(IEnumerable<string> terminalOutputLines)
    {
        var fileSystem = new FileSystem(70_000_000);
        var commandPrefix = "$".AsSpan();
        var directoryPrefix = "dir".AsSpan();

        foreach (var line in terminalOutputLines)
        {
            var span = line.AsSpan();

            if (span.StartsWith(commandPrefix))
                ExecuteCommand(span[2..], fileSystem);
            else if (span.StartsWith(directoryPrefix))
                AddDirectory(span[4..], fileSystem);
            else
                AddFile(span, fileSystem);
        }

        return fileSystem;
    }

    private static void ExecuteCommand(ReadOnlySpan<char> command, FileSystem fileSystem)
    {
        if (command.StartsWith("cd"))
            fileSystem.ChangeDirectory(new string(command[3..]));
    }
    
    private static void AddDirectory(ReadOnlySpan<char> directory, FileSystem fileSystem)
    {
        fileSystem.AddDirectory(new string(directory));
    }

    private static void AddFile(ReadOnlySpan<char> file, FileSystem fileSystem)
    {
        var separatorIndex = file.IndexOf(' ');
        fileSystem.AddFile(int.Parse(file[..separatorIndex]));
    }
}
