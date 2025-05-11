namespace WorkChronicle.Structure.Models
{
    public class NightShift : Shift
    {
        //Some of the data is hidden.

        public NightShift() : base()
        {
        }


        public override string ToString()
        {
            return $"You work Night Shift at: " + base.ToString();
        }
    }
}
