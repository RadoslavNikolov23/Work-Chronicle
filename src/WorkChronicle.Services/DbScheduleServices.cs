namespace WorkChronicle.Services
{
    public class DbScheduleServices : IDbScheduleServices
    {
        private readonly IWorkScheduleRepositoryDB scheduleRepo;

        private readonly IWorkShiftRepositoryDB shiftRepo;

        public DbScheduleServices()
        {
          //Some of the code is removed
        }

        public async Task<IList<string>> LoadScheduleNameFromDB()
        {
            try
            {
                IList<string> dbScheduleNames = await this.scheduleRepo
                                                                    .GetAllScheduleNames();
                return dbScheduleNames;
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ............, in the DbScheduleServices class.");
                throw;
            }
        }

        public async Task<bool> ScheduleAndShiftSaveToDB(ISchedule<IShift> schedule)
        {
            try
            {
                // First check if the current schedule is saved in the DB
                        // If it is deletes it, then it saves it
                        // If it is not saved, saves it
                
            }

            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ............, in the DbScheduleServices class.");
                throw;
            }
        }


        public async Task<bool> YearScheduleAndShiftSaveToDB(IYearSchedule schedule)
        {

            try
            {
                // Goes through all the months schedule
                // and check if the current schedule is saved in the DB
                        // If it is deletes it, then it saves it
                        // If it is not saved, saves it
                
            }

            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .............., in the DbScheduleServices class.");
                throw;
            }
        }

        public async Task<DbSchedule> ReturnCurrentMonthScheduleFromDB()
        {
            try
            {
                return await this.scheduleRepo
                                        .GetCurrentMonthSchedule();
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .............., in the DbScheduleServices class.");
                throw;
            }
        }

        public async Task<DbSchedule> ReturnClosestScheduleFromDB()
        {
            try
            {
                return await this.scheduleRepo
                                        .GetClosestSchedule();
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .................., in the DbScheduleServices class.");
                throw;
            }
        }

        public async Task<DbSchedule> ReturnScheduleFromDB(string scheduleName)
        {
            try
            {
                return await this.scheduleRepo
                                            .GetScheduleByName(scheduleName);
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ...................., in the DbScheduleServices class.");
                throw;
            }
        }

        public async Task<int> DeleteScheduleFromDB(DbSchedule schedule)
        {
            try
            {
                return await this.scheduleRepo
                                            .DeleteSchedule(schedule);
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ........................, in the DbScheduleServices class.");
                throw;
            }
        }
    }
}
