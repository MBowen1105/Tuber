namespace Tuber.Application.Interfaces.SystemClock;
public interface ISystemClock
{
    DateTime NowUtc();
    DateTime TodayUtc();
}
