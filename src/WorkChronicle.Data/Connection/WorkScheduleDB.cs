namespace WorkChronicle.Data.Connection
{
    public class WorkScheduleDB 
    {
        private SQLiteAsyncConnection? database;

        public async Task Init()
        {
            try
            {
                if (database is not null)
                    return;

                //some of the code is hidden

               
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error ............... ");
                throw;
            }
        }

        public SQLiteAsyncConnection Database => database!;
       
    }
}