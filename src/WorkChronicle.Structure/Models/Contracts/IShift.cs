namespace WorkChronicle.Structure.Models.Contracts
{
    public interface IShift
    {
        public ShiftType ShiftType { get; set; }

        //Some of the data is hidden.

        public DateTime GetDateShift();


    }
}
