using Tuber.Core.Common;

namespace Tuber.Application.Categories.Commands.CategoryDelete;

public class CategoryDeleteCommandResponse : CommandQueryResponseBase
{
    public int DeletedCount { get; init; }
}
