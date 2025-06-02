namespace WorkChronicle.Data.RepositoryDB.Contracts
{
    public interface IWorkShiftRepositoryDB
    {
        Task<int> AddShift(DbShift shift);

        Task<List<DbShift>> GetAllShifts();

        Task<List<DbShift>> GetShiftsForSchedule(int scheduleId);

        Task<DbShift> GetSingleShifts(int scheduleId, int year, int month, int day);

        Task<int> UpdateShift(DbShift shift);

        Task<int> DeleteShift(DbShift shift);

        Task<int> DeleteShiftsFromSchedule(int scheduleId);
    }
}
