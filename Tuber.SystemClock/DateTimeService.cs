using Tuber.Domain.Interfaces.Infrastructure.DateTimes;

namespace Tuber.SystemClock
{
    public class DateTimeService : IDateTimeService
    {
        public System.DateTime UtcNow() => System.DateTime.UtcNow;
    }
}
