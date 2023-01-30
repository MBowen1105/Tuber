using Tuber.Application.Common.Interfaces.SystemClock;

namespace Tuber.SystemClock
{
    public class SystemClock : ISystemClock
    {
        public DateTime NowUtc() => DateTime.UtcNow;

        public DateTime TodayUtc() => DateTime.Today;
    }
}
