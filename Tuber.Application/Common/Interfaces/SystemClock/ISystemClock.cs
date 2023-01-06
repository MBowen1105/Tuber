namespace Tuber.Application.Interfaces.SystemClock;
public interface ISystemClock
{
    DateTime UtcNow();
    DateTime Today();
}
