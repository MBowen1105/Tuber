using Tuber.Application.Interfaces.SystemClock;

namespace Tuber.SystemClock
{
    public class SystemClock : ISystemClock
    {
        public System.DateTime UtcNow() => System.DateTime.UtcNow;
    }
}
