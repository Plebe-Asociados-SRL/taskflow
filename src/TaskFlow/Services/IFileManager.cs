namespace TaskFlow.Services;

public interface IFileManager
{
    void WriteAllText(string path, string contents);
}
