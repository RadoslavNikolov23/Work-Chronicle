namespace WorkChronicle.Data.Models
{
    public class DbShift
    {
        [PrimaryKey,AutoIncrement]
        public long Id { get; set; }

        //Some of the models properties are hidden.

        [Ignore]
        public virtual DbSchedule DbSchedule { get; set; } = null!;
    }

}