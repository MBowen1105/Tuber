﻿using Tuber.Core.Common;

namespace Tuber.BLL.Subcategories.Commands.SubcategoryDelete;

public class SubcategoryDeleteCommandResponse : CommandQueryResponseBase
{
	public SubcategoryDeleteCommandResponse()
	{
	}

	public SubcategoryDeleteCommandResponse(Exception exception)
	{
		DeletedCount = 0;
		Exceptions.Add(exception);
	}
    public int DeletedCount { get; init; }
}
