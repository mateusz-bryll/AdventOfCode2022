using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DaySeven.Domain;

public record Directory(string Name, Directory ParentDirectory)
{
    private int sizeOfFilesInDirectory = 0;
    private List<Directory> Subdirectories { get; } = new();

    public IEnumerable<Directory> GetDirectories()
    {
        for (var i = 0; i < Subdirectories.Count; i++)
        {
            var subdirectory = Subdirectories[i];
            yield return subdirectory;
            
            for (var j = 0; j < subdirectory.Subdirectories.Count; j++)
            {
                yield return subdirectory.Subdirectories[j];
            }
        }
    }

    public int Size => sizeOfFilesInDirectory + CalculateSizeOfSubdirectories();

    public void AddFile(int fileSize) => sizeOfFilesInDirectory += fileSize;
    
    public void AddSubdirectory(Directory directory) => Subdirectories.Add(directory);

    public Directory? GetDirectory(string name)
    {
        return name switch
        {
            ".." => ParentDirectory,
            "." => this,
            _ => Find(name)
        };

        Directory? Find(string directoryName)
        {
            for (var i = 0; i < Subdirectories.Count; i++)
            {
                var subdirectory = Subdirectories[i];
                if (subdirectory.Name == directoryName)
                    return subdirectory;
            }

            return null;
        }
    }

    private int CalculateSizeOfSubdirectories()
    {
        var sum = 0;
        var directories = CollectionsMarshal.AsSpan(Subdirectories);
        ref var directoryReference = ref MemoryMarshal.GetReference(directories);
        for (var i = 0; i < directories.Length; i++)
        {
            var directory = Unsafe.Add(ref directoryReference, i);
            sum += directory.Size;
        }

        return sum;
    }
}

public record RootDirectory() : Directory("/", null)
{
}
