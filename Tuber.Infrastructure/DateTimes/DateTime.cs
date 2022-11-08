using Tuber.Infrastructure.Interfaces;

namespace Tuber.Infrastructure.DateTimes
{
    public class DateTime : IDateTime
    {
        public System.DateTime UtcNow() => System.DateTime.UtcNow;
    }
}
