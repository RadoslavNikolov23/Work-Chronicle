namespace WorkChronicle.Structure.Core.Helpers
{
    public class EngineHelper : IEngineHelper<ISchedule<IShift>>
    {
        public async Task<ISchedule<IShift>> AddShiftsToSchedule()
        {
            //Some of the code is removed.


            await shiftPattern.CheckTheShiftPattern(sc.Cycle);

            try
            {
                //This method puts together the generated working days to the schedule
                // with the rest days in between them
               
                return schedule;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                await Logger.LogAsync(ex, "ArgumentOutOfRangeException Error ........, in the EngineHelper.cs");
                throw;
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ........., in the EngineHelper.cs");
                throw;
            }
        }

        public async Task<ISchedule<IShift>> GenerateMonthSchedule(ISchedule<IShift> schedule, ScheduleConfiguration sc)
        {
           //The method creates the final work schedule with all the current and
           //not current dates, so that i can be a perfect calendar month.

            return schedule;
        }

        private Task<ISchedule<IShift>> GeneratePreviousMonthDays(ISchedule<IShift> schedule, DateTime firstDayOfMonth)
        {
            //Some of the code is hidden
        }

        private Task<ISchedule<IShift>> GenerateNextMonthDays(ISchedule<IShift> schedule, DateTime firstDayOfMonth)
        {
            //Some of the code is hidden

        }

        private bool HasShiftMonthChanged(int shiftMonth, int startDateMonth)
        {
            return shiftMonth != startDateMonth;
        }
    }
}
