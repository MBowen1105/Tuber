using Tuber.Domain.Interfaces.Infrastructure;

namespace Tuber.Infrastructure.DateTimes
{
    public class DateTimeService : IDateTimeService
    {
        public System.DateTime UtcNow() => System.DateTime.UtcNow;
    }
}
