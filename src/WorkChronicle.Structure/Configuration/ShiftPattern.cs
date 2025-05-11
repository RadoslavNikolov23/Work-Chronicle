namespace WorkChronicle.Structure.Configuration
{
    public class ShiftPattern
    {
        public bool Is24Dayshift { get; set; }
        public bool IsDayDayShift { get; set; }
        public bool IsDayNightShift { get; set; }
        public bool IsDayNightNightShift { get; set; }

        public ShiftPattern()
        {
            Is24Dayshift = false;
            IsDayDayShift = false;
            IsDayNightShift = false;
            IsDayNightNightShift = false;
        }

        public Task CheckTheShiftPattern(string[] cycle)
        {
            //Some of the code is removed.
        }
    }
}
