namespace WorkChronicle.Data.Tests
{
    using WorkChronicle.Common.Enums;
    using WorkChronicle.Data.Connection;
    using WorkChronicle.Data.Models;
    using WorkChronicle.Data.RepositoryDB;

    [TestFixture]
    public class WorkShiftRepositoryDBTests
    {

        [SetUp]
        public void Setup()
        {
            // Set to in-memory for this test run
            DatabaseConfiguration.TestOverridePath = ":memory:";
        }

        [Test]
        public async Task Init_CreatesTables_Works_Correctly()
        {
            var db = new WorkScheduleDB();
            await db.Init();

            //Some of the code is removed.
            var tableInfo = await db.Database.GetTableInfoAsync("...........");
            Assert.IsNotEmpty(tableInfo);
        }

        [Test]
        public async Task Do_AddShiftMethod_Works_Correctly()
        {
            //Some of the code is removed.

        }

        [Test]
        public async Task Do_GetAllShiftsMethod_Works_Correctly()
        {
           
            //Some of the code is removed.


            for (int i = 0; i < 10; i++)
            {
                DbShift shift = DBShiftInitializationRandom();
                result+=await ............
            }

            Assert.That(result, Is.EqualTo(10));

             //Some of the code is removed.

            await dbContext.Database.DropTableAsync<DbShift>();
        }

        [Test]
        public async Task Do_GetShiftsForScheduleMethod_Works_Correctly()
        {
            //Some of the code is removed.

           
        }

        [Test]
        public async Task Do_GetSingleShiftsMethod_Works_Correctly()
        {
            //Some of the code is removed.
        }

        [Test]
        public async Task Do_UpdateShiftMethod_Works_Correctly()
        {
            //Some of the code is removed.
        }

        [Test]
        public async Task Do_DeleteShiftMethod_Works_Correctly()
        {
            //Some of the code is removed.
        }

        [Test]
        public async Task Do_DeleteShiftsFromScheduleMethod_Works_Correctly()
        {
            //Some of the code is removed.
        }

        private DbShift DBShiftInitialization()
        {
           //Some of the code is removed.
        }

        private DbShift DBShiftInitializationRandom()
        {
           //Some of the code is removed.
        }

        [TearDown]
        public void Cleanup()
        {
            DatabaseConfiguration.TestOverridePath = null;
        }
    }
}
