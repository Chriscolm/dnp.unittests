using System.IO.Abstractions;

namespace Dnp.Unittests;

public class FileReader(IFileSystem fileSystem) : IFileReader
{
    public async Task<string> ReadTextFileAsync(string fileName)
    {
        var result = await fileSystem.File.ReadAllTextAsync(fileName);
        return result;
    }
}
