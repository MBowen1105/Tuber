using Tuber.Domain.Interfaces.SystemClock;

namespace Tuber.SystemClock
{
    public class DateTimeService : IDateTimeService
    {
        public System.DateTime UtcNow() => System.DateTime.UtcNow;
    }
}
