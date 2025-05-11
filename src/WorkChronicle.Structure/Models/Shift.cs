namespace WorkChronicle.Structure.Models
{
    public abstract partial class Shift : ObservableObject, IShift
    {

        //Some of the data is hidden.

        [ObservableProperty]
        private ShiftType shiftType;

       

        public Shift(): this ()
        {
        }

        public Shift()
        {

        }

        partial void OnShiftTypeChanged(ShiftType value)
        {
            UpdateBackgroundColor();
        }

        
        //Some of the data is hidden.


        private void UpdateBackgroundColor()
        {
            //Some of the data is hidden.
        }

        public DateTime GetDateShift()
        {
            return new DateTime(...., ...., ......);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Day:d2}/{Month:d2}/{Year}");

            return sb.ToString().Trim();
        }
    }
}
