using Moq;
using Tuber.Application.Common.Interfaces.Authentication;
using Tuber.Application.Models;

namespace Persistence.UnitTests.Common;
internal static class MockCurrentUserService
{
    public static readonly Guid RegularUserId = Guid.Parse("7e1bf8f0-10b6-4afd-95bb-1e5c9aae5a03");
    public static readonly Guid AdminUserId = Guid.Parse("55f4a90c-25c1-4264-9bf9-d250ae9eb846");

    public static Mock<ICurrentUserService> Setup()
    {
        var mockCurrentUserService = new Mock<ICurrentUserService>();

        mockCurrentUserService.Setup(x => x.User()).Returns(new User
        {
            UserId = RegularUserId,
            FullName = "Mark Bowen",
            IsCoreUser = false,
            IsDeleted = false,
        });

        mockCurrentUserService.Setup(x => x.AdminUser()).Returns(new User
        {
            UserId = AdminUserId,
            FullName = "Administrator",
            IsCoreUser = true,
            IsDeleted = false,
        });

        return mockCurrentUserService;
    }
}
