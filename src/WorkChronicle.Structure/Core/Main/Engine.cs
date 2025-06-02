namespace WorkChronicle.Structure.Core.Main
{
    public class Engine : IEngine<ISchedule<IShift>>
    {
        private readonly IEngineHelper<ISchedule<IShift>> helper;

        private readonly EngineStrategyFactory factory;

        private ISchedule<IShift> schedule = new Schedule();

        public Engine()
        {
            //Some of the code is hidden

            helper = new EngineHelper();
            factory = new EngineStrategyFactory(helper);
        }

        public async Task<ISchedule<IShift>> CalculateShifts()
        {
            try
            {
                 //The method calls check which of the current shift patters ("strategy")
                 // the user has selected and goes to call the other helper methods
                 //and in the end returs the final schedule


                return schedule;
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ........, in the Engine class.");
                throw;
            }
        }

        public async Task<IList<IYearSchedule>> GeneratedYearSchedule(ScheduleConfiguration sc)
        {
            try
            {
                //The methods generates a year long schedule for evry month
                // by the selected year, based on the selected shift pattert ("strategy")

                return listYearWorkSchedule;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                await Logger.LogAsync(ex, "ArgumentOutOfRangeException Error in ........, in the Engine.cs");
                throw;
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .......... Engine class.");
                throw;
            }
        }

        public async Task<ISchedule<IShift>> BlankCalendar()
        {
            try
            {
                schedule = await helper.GenerateBlankCalendar(schedule);

                return schedule;
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .............., in the Engine class");
                throw;
            }
        }
    }
}