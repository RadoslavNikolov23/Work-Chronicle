namespace WorkChronicle.Structure.Core.Schedules
{
    public class ShiftsDay24: IEngineStrategy
    {
        private readonly IEngineHelper<ISchedule<IShift>> helper;

        public ShiftsDay24(IEngineHelper<ISchedule<IShift>> helper)
        {
            this.helper = helper;
        }

        public int RestDays => RestDaysBetweenShifts.Day24hours;

        public Task ApplySchedule()
        { 
            //Creates the first part of the selected schedule pattern ("strategy")
            return Task.CompletedTask;
        }

    }

}