namespace WorkChronicle.Structure.Core.Schedules
{
    public class ShiftsDayNight: IEngineStrategy
    {
        private readonly IEngineHelper<ISchedule<IShift>> helper;
        public ShiftsDayNight(IEngineHelper<ISchedule<IShift>> helper)
        {
            this.helper = helper;
        }

        public int RestDays => RestDaysBetweenShifts.DayNight;

        public Task ApplySchedule()
        {
            //Creates the first part of the selected schedule pattern ("strategy")

            return Task.CompletedTask;
        }
    }
}