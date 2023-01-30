using Moq;
using Tuber.Application.Common.Interfaces.SystemClock;

namespace Persistence.UnitTests.Common;
public static class MockSystemClock
{
    public static readonly DateTime MockDateTimeUtc = new(2022, 1, 1, 12, 1, 1);
    
    public static Mock<ISystemClock> Setup()
    {
        Mock<ISystemClock> mockSystemClock = new();

        mockSystemClock.Setup(x => x.NowUtc())
                .Returns(MockDateTimeUtc);

        return mockSystemClock;
    }
}
