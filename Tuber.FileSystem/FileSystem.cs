using Tuber.Application.Common.Interfaces.FileSystem;

namespace Tuber.FileSystem;
internal class FileSystem : IFileSystem
{
    public bool Exists(string fileName)
    {
        return File.Exists(fileName);
    }

   
    public string[] ReadAllLines(string textFile)
    {
        return File.ReadAllLines(textFile);
    }

    public void Delete(string fileName)
    {
        File.Delete(fileName);
    }

}
