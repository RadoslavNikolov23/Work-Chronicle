namespace WorkChronicle.Data.RepositoryDB.Contracts
{
    public interface IWorkScheduleRepositoryDB
    {
        Task<int> AddSchedule(DbSchedule schedule);

        Task<int> UpdateSchedule(DbSchedule schedule);

        Task<bool> ExistsSchedule(string scheduleName);

        Task<DbSchedule> GetLastSchedule();

        Task<DbSchedule> GetClosestSchedule();

        Task<DbSchedule> GetCurrentMonthSchedule();

        Task<DbSchedule> GetScheduleByName(string name);

        Task<List<string>> GetAllScheduleNames();

        Task<int> DeleteSchedule(DbSchedule schedule);
        
    }
}

