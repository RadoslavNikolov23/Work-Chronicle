namespace WorkChronicle.Services.Contracts
{
    public interface ICommonServices
    {
        Task<ISchedule<IShift>> ReturnCalculatedShifts(ScheduleConfiguration sc);

        Task<IList<IYearSchedule>> ReturnGeneratedYearSchedule(ScheduleConfiguration sc);

        Task<ISchedule<IShift>> ReturnBlankCalendar();

        Task<ISchedule<IShift>> ReturnWorkingSchedule(IList<DbShift> scheduleDb);
    }
}
