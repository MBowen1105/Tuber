namespace Tuber.Application.Common.Interfaces;
public interface IFileSystem
{
    string[] ReadAllLines(string textFile);
    bool Exists(string fileName);
    void Delete(string fileName);

}
