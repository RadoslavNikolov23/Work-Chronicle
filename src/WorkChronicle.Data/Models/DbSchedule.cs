namespace WorkChronicle.Data.Models
{
    public class DbSchedule
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        //Some of the models properties are hidden.

        [Ignore]
        public virtual ICollection<DbShift> ShiftRecords { get; set; } = new HashSet<DbShift>();
    }
}
