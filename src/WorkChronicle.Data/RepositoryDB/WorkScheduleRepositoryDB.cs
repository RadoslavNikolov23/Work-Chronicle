namespace WorkChronicle.Data.RepositoryDB
{
    public class WorkScheduleRepositoryDB: IWorkScheduleRepositoryDB
    {

        public WorkScheduleRepositoryDB()
        {
            //Some of the code is removed.
        }

        private async Task EnsureInitialized() => await dbContext.Init();

        public async Task<int> AddSchedule(DbSchedule schedule)
        {
            try
            {
                //Add to the a Schedule in the DB

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<int> UpdateSchedule(DbSchedule schedule)
        {
            try
            {
                //Updates a Schedule in the DB
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<bool> ExistsSchedule(string scheduleName)
        {
            try
            {
                //Return a boolen of a existing schedule in the DB

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<DbSchedule> GetLastSchedule()
        {
            try
            {
                //Get the last added schedule in the DB
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<DbSchedule> GetCurrentMonthSchedule()
        {
            try
            {
                //Get the current month schedule in the DB (for the current month)

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<DbSchedule> GetClosestSchedule()
        {
            try
            {
                //Get the closest to the current month schedule in the DB.
                //First searchest from the current year, then goes to the next
                // and finaly goes from the previous years

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<DbSchedule> GetScheduleByName(string name)
        {
            try
            {
                //Get the concreate schedule by name, if there is not returns null
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<List<string>> GetAllScheduleNames()
        {
            try
            {
                // Get the all the schedules by name, using RAW QUERY "SELECT ****** FROM DbSchedule ORDER BY ****, ****"
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }

        public async Task<int> DeleteSchedule(DbSchedule schedule)
        {
            try
            {
               // Deleting the current schedule, alongside the shifts it has reference to!

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class.");
                throw;
            }
        }
    }
}