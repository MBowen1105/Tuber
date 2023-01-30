using Tuber.Application.Common.Interfaces.Clock;

namespace Tuber.Clock
{
    public class Clock : IClock
    {
        public DateTime NowUtc() => DateTime.UtcNow;

        public DateTime TodayUtc() => DateTime.Today;
    }
}
