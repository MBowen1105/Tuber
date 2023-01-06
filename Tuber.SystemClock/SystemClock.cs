using Tuber.Application.Interfaces.SystemClock;

namespace Tuber.SystemClock
{
    public class SystemClock : ISystemClock
    {
        public DateTime UtcNow() => DateTime.UtcNow;
        public DateTime Today() => DateTime.Today;
    }
}
