namespace WorkChronicle.Structure.Models
{
    public class DayShift : Shift
    {
        //Some of the data is hidden.

        public DayShift() : base(s)
        {
        }


        public override string ToString()
        {
            return $"You work Day Shift at: " + base.ToString();
        }
    }
}