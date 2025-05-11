namespace WorkChronicle.Structure.Core.Schedules
{
    public class ShiftsDayNightNight:IEngineStrategy
    {
        private readonly IEngineHelper<ISchedule<IShift>> helper;
        public ShiftsDayNightNight(IEngineHelper<ISchedule<IShift>> helper)
        {
            this.helper = helper;
        }

        public int RestDays => RestDaysBetweenShifts.DayNightNight;

        public Task ApplySchedule()
        {
            //Creates the first part of the selected schedule pattern ("strategy")

            return Task.CompletedTask;
        }
    }
}
