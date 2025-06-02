namespace WorkChronicle.Structure.Core.Schedules
{
    public class ShiftsDayDay : IEngineStrategy
    {
        private readonly IEngineHelper<ISchedule<IShift>> helper;

        public ShiftsDayDay(IEngineHelper<ISchedule<IShift>> helper)
        {
            this.helper = helper;
        }

        public int RestDays => RestDaysBetweenShifts.DayDay;

        public Task ApplySchedule()
        {
            //Creates the first part of the selected schedule pattern ("strategy")

            return Task.CompletedTask;
        }
    }
}