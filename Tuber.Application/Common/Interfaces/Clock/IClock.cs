namespace Tuber.Application.Common.Interfaces.Clock;
public interface IClock
{
    DateTime NowUtc();
    DateTime TodayUtc();
}
