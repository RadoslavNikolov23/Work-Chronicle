namespace WorkChronicle.Services
{
    public class DbShiftServices : IDbShiftServices
    {
        private readonly IWorkScheduleRepositoryDB scheduleRepo;

        private readonly IWorkShiftRepositoryDB shiftsRepo;

        public DbShiftServices()
        {
           //Some of the code is removed
        }

        public async Task<List<DbShift>> ReturnShiftsForScheduleFromDB(int scheduleId)
        {
            try
            {
                return await shiftsRepo
                                    .GetShiftsForSchedule(scheduleId);
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .............., in the DbShiftServices class.");
                throw;
            }
        }


        public async Task<(bool, bool)> EditShiftFromDB(IShift selectedShift, IShift shift)
        {
            try
            {
                //Edits the shift and saves it to the DB
               
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ............, in the DbShiftServices class.");
                throw;
            }
        }
        public async Task<(bool, bool)> CompensateShiftFromDB(IShift selectedShift, IShift shift)
        {
            try
            {
                 //Compensates the shift and saves it to the DB
               
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ................., in the DbShiftServices class.");
                throw;
            }
        }

        public async Task<(bool, bool)> SickLeaveMarkShiftFromDB(IShift selectedShift, IShift shift)
        {
            try
            {
                 //Marks the shift as a Sick Leave and saves it to the DB
               
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ................., in the DbShiftServices class.");
                throw;
            }
        }

        public async Task<(bool, bool)> VacationLeaveMarkShiftFromDB(IShift selectedShift, IShift shift)
        {
            try
            {
                //Marks the shift as a Vacation Leave and saves it to the DB

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ............, in the DbShiftServices class.");
                throw;
            }
        }

        private async Task<DbSchedule> ReturnScheduleFromDB(int month, int year)
        {
            return await this.scheduleRepo
                            .GetScheduleByName( $"{Provider.GetMonthName(month)} {year}");
        }

    }
}
