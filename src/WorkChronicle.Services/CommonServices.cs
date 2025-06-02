namespace WorkChronicle.Services
{
    public class CommonServices: ICommonServices
    {

        public async Task<ISchedule<IShift>> ReturnCalculatedShifts (ScheduleConfiguration sc)
        {
            try
            {
                IEngine<ISchedule<IShift>> engine = new Engine();
                return await engine.CalculateShifts(sc);
            }

            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ................, in the CommonServices class.");
                throw;
            }
        }

        public async Task<IList<IYearSchedule>> ReturnGeneratedYearSchedule(ScheduleConfiguration sc)
        {
            try
            {
                IEngine<ISchedule<IShift>> engine = new Engine();
                return await engine.GeneratedYearSchedule(sc);
            }

            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ..............., in the CommonServices class.");
                throw;
            }
        }

        public async Task<ISchedule<IShift>> ReturnBlankCalendar()
        {
            try
            {
                IEngine<ISchedule<IShift>> engine = new Engine();
                return await engine.BlankCalendar();
            }

            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ..............., in the CommonServices class.");
                throw;
            }
        }


        public async Task<ISchedule<IShift>> ReturnWorkingSchedule(IList<DbShift> scheduleDb) 
        {
            try
            {

                // Creates a working schedule from the a generated List of shifts.
               
            }

            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ............., in the CommonServices class.");
                throw;
            }
        }
    }
}
