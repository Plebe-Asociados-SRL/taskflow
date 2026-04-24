using System.IO;

namespace TaskFlow.Services;

public class FileManager : IFileManager
{
    public void WriteAllText(string path, string contents)
    {
        File.WriteAllText(path, contents);
    }
}
