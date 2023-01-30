namespace Tuber.Application.Common.Interfaces.SystemClock;
public interface ISystemClock
{
    DateTime NowUtc();
    DateTime TodayUtc();
}
