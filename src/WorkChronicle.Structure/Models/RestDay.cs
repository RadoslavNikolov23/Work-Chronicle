namespace WorkChronicle.Structure.Models
{
    public class RestDay : Shift
    {

        //Some of the data is hidden.

        public RestDay() : base ()
        {
        }

        public override string ToString()
        {
            return $"Rest day: {Day:d2}/{Month:d2}/{Year}";
        }
    }
}