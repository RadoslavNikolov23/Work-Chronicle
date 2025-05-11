namespace WorkChronicle.Structure.Configuration
{
    public class ScheduleConfiguration(DateTime startDate, string[] cycle, FirstShiftChoice firstShift, ShiftConfiguration shiftConfiguration)
    {
        public DateTime StartDate { get; set; } = startDate;
        public string[] Cycle { get; set; } = cycle;
        public FirstShiftChoice FirstShift { get; set; } = firstShift;
        public ShiftConfiguration ShiftConfiguration { get; set; } = shiftConfiguration;
    }
}
