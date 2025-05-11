namespace WorkChronicle.Data.RepositoryDB
{
    public class WorkShiftRepositoryDB: IWorkShiftRepositoryDB
    {

        public WorkShiftRepositoryDB()
        {
            //Some of the code is removed.
        }

        private async Task EnsureInitialized() => await dbContext.Init();

        public async Task<int> AddShift(DbShift shift)
        {
            try
            {
                //Add to the a shift in the DB and attaches it to a concreate schedule

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<List<DbShift>> GetAllShifts()
        {
            try
            {
                //Gets all the shifts in the DB

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<List<DbShift>> GetShiftsForSchedule(int scheduleId)
        {
            try
            {
                //returs all the shifts from the wanted schedule
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<DbShift> GetSingleShifts(int scheduleId, int year, int month, int day)
        {
            try
            {
                //Gets a single shift depending on the year, month and day
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<int> UpdateShift(DbShift shift)
        {
            try
            {
                //Updates  a shift in the DB

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<int> DeleteShift(DbShift shift)
        {
            try
            {
                //Deletes a concreate shift
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }
        public async Task<int> DeleteShiftsFromSchedule(int scheduleId)
        {

            try
            {
                //Deletes all the shifts that reference the given schedule Id
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }
    }
}
