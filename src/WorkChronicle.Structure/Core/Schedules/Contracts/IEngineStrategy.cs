namespace WorkChronicle.Structure.Core.Schedules.Contracts
{
    public interface IEngineStrategy
    {
        int RestDays { get; }

        Task ApplySchedule(ISchedule<IShift> schedule, ScheduleConfiguration sc, bool isCurrentMonth);
    }
}
