namespace WorkChronicle.Services.Contracts
{ 
    public interface IDbScheduleServices
    {
        Task<IList<string>> LoadScheduleNameFromDB();

        Task<bool> ScheduleAndShiftSaveToDB(ISchedule<IShift> schedule);

        Task<bool> YearScheduleAndShiftSaveToDB(IYearSchedule schedule);

        Task<DbSchedule> ReturnCurrentMonthScheduleFromDB();

        Task<DbSchedule> ReturnClosestScheduleFromDB();

        Task<DbSchedule> ReturnScheduleFromDB(string scheduleName);

        Task<int> DeleteScheduleFromDB(DbSchedule schedule);

    }
}
