namespace WorkChronicle.Structure.Repository.Contracts
{
    public interface ISchedule<T> where T : class
    {
        public ObservableCollection<T> WorkSchedule { get; }

        Task AddShift(T shift);

        Task RemoveShift(T shift);

        Task<int> IndexOfShift(T shift);

        Task<DateTime> GetLastWorkingShift();

        Task<ShiftType> GetTypeOfTheLastWorkingShift();

        Task<int> TotalShifts();

        Task<int> CalculateTotalSickDaysHours();

        Task<int> CalculateTotalVacationDaysHours();

        Task<int> TotalCompensatedShifts();

        Task<int> CalculateTotalWorkHours();
    }
}
