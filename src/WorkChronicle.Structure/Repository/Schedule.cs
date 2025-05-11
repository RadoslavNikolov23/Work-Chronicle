namespace WorkChronicle.Structure.Repository
{
    public class Schedule : ISchedule<IShift>
    {
        private ObservableCollection<IShift> workSchedule;

        public Schedule()
        {
            //Some of the data is hidden.
        }

        public ObservableCollection<IShift> WorkSchedule { get => workSchedule; }

        public Task AddShift(IShift shift)
        {
            workSchedule.Add(shift);
            return Task.CompletedTask;
        }

        public Task RemoveShift(IShift shiftToRemove)
        {
            workSchedule.Remove(shiftToRemove);
            return Task.CompletedTask;
        }

        public Task<int> IndexOfShift(IShift shift)
        {
            return Task.FromResult(workSchedule.IndexOf(shift));
        }

        public Task<DateTime> GetLastWorkingShift()
        {

         //Some of the data is hidden.

            return Task.FromResult(date);
        }

        public  Task<ShiftType> GetTypeOfTheLastWorkingShift()
        {
        
            //Some of the data is hidden.

            return Task.FromResult(shift.ShiftType);
        }

        public Task<int> TotalShifts()
        {
            return Task.FromResult(workSchedule.Count);
        }

        public Task<int> TotalCompensatedShifts()
        {
            return Task.FromResult(workSchedule.Count(s => s.IsCompensated == true));
        }

        public async Task<int> CalculateTotalSickDaysHours()
        {
           
            //Some of the data is hidden.

            return totalHours;
        }

        public async Task<int> CalculateTotalVacationDaysHours()
        {
            //Some of the data is hidden.

            return totalHours;
        }

        public async Task<int> CalculateTotalWorkHours()
        {
            //Some of the data is hidden.

            return totalHours;
        }

        private Task<int> CalculateShiftHours(IShift shift)
        {
            //Some of the data is hidden.
        }

        private double GetNightShiftMultiplier(int currentHour)
        {
            return currentHour >= 22 || currentHour < 6 ? HourCoefficient.NightShiftCoefficient : 0.0;
        }
    }
}
