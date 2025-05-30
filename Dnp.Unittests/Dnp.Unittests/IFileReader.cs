namespace Dnp.Unittests;

public interface IFileReader
{
    Task<string> ReadTextFileAsync(string fileName);
}
