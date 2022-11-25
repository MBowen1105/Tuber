using Tuber.Domain.Interfaces.FileSystem;
using Tuber.Domain.Models;

namespace Tuber.Infrastructure.FileSystem;
public class FileSystemRetrievalService : IFileSystemRetrievalService
{
    public ServiceResult<List<string>> LoadTextFile(string textFileLocation)
    {
        return new ServiceResult<List<string>>(
            payload: new List<string>()
             {
                 "Date,Description,Type,Money In, Money Out, Balance",
                 "2022-08-05,M&S BANK,DD,,176.24,255.17",
                 "2022-08-04,CYRUS SOLUTIONS LT EXPENSES E003,CREDIT,283.89,,431.41",
                 "2022-08-04,M Bowen            Gas top-up 25PAR,CREDIT,30.00,,147.52"
             });
    }
}
