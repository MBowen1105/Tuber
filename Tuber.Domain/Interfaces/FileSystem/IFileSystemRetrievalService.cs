using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.FileSystem;
public interface IFileSystemRetrievalService
{
    ServiceResult<List<string>> LoadTextFile(string textFileLocation);
}
