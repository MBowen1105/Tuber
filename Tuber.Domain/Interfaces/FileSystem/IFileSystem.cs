namespace Tuber.Domain.Interfaces.FileSystem;
public interface IFileSystem
{
    string[] ReadAllLines(string textFile);
    bool Exists(string fileName);
    void Delete(string fileName);

}
