using Tuber.SystemClock.Interfaces;

namespace Tuber.SystemClock
{
    public class SystemClock : ISystemClock
    {
        public System.DateTime UtcNow() => DateTime.UtcNow;
    }
}
