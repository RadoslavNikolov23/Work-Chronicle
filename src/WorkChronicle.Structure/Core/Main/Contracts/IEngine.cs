namespace WorkChronicle.Structure.Core.Main.Contracts
{
    public interface IEngine<T> where T:class
    {
        Task <T> CalculateShifts (ScheduleConfiguration sc);

        Task<IList<IYearSchedule>> GeneratedYearSchedule(ScheduleConfiguration sc);

        Task<ISchedule<IShift>> BlankCalendar();
    }
}
