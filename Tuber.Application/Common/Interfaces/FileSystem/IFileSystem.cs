﻿namespace Tuber.Application.Common.Interfaces.FileSystem;
public interface IFileSystem
{
    string[] ReadAllLines(string textFile);
    bool Exists(string fileName);
    void Delete(string fileName);
    string CurrentDirectory();
    DirectoryInfo GetParent(string path);
}
