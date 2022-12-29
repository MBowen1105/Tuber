using Tuber.Application.Common.Interfaces.FileSystem;

namespace Tuber.FileSystem;
internal class FileSystem : IFileSystem
{
    #region "System.IO.File"
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

    #endregion

    #region "System.Environment"
    public string CurrentDirectory() => Environment.CurrentDirectory;
    #endregion

    #region"System.IO.Directory"
    public DirectoryInfo GetParent(string path) => Directory.GetParent(path)!;
    #endregion

}
