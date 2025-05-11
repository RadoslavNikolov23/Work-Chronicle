namespace WorkChronicle.Data.Tests
{
    using WorkChronicle.Common.Providers;
    using WorkChronicle.Data.Connection;
    using WorkChronicle.Data.Models;
    using WorkChronicle.Data.RepositoryDB;

    [TestFixture]
    public class WorkScheduleRepositoryDBTests
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
            var tableInfo = await db.........
            Assert.IsNotEmpty(tableInfo);
        }

        [Test]
        public async Task Do_AddScheduleMethod_Works_Correctly()
        {
            //Some of the code is removed.

            DbSchedule? scheduleFromDb = await dbScheduleRepo.GetScheduleByName("TestSchedule");

            Assert.That(scheduleFromDb, Is.Not.Null);
            Assert.That(scheduleFromDb.ScheduleName, Is.EqualTo("TestSchedule"));
            Assert.That(scheduleFromDb.Year, Is.EqualTo(.....));
            Assert.That(scheduleFromDb.Month, Is.EqualTo(........));

            await dbContext.Database.DropTableAsync<DbSchedule>();
        }

        [Test]
        public async Task Do_UpdateScheduleMethod_Works_Correctly()
        {
            //Some of the code is removed.
        }

        [Test]
        public async Task Do_ExistsScheduleMethod_Works_Correctly()
        {
            //Some of the code is removed.
        }

        [Test]
        public async Task Do_GetLastScheduleMethod_Works_Correctly()
        {
            //Some of the code is removed.
        }

        [Test]
        public async Task Do_GetCurrentMonthScheduleMethod_Works_Correctly()
        {
            
            //Some of the code is removed.

        }

        [Test]
        public async Task Do_GetClosestScheduleMethod_Works_Correctly()
        {
            
            //Some of the code is removed.

        }

        [Test]
        public async Task Do_GetCurrentMonthScheduleMethod_Works_Correctly_But_ReturnsNull()
        {
           //Some of the code is removed.
        }

        [Test]
        public async Task Do_GetScheduleByNameMethod_Works_Correctly()
        {  
           //Some of the code is removed.
        }

        [Test]
        public async Task DoGetAllScheduleNamesMethod_Works_Correctly()
        {
            //Some of the code is removed.
        }

        [Test]
        public async Task Do_DeleteScheduleMethod_Works_Correctly()
        {
            //Some of the code is removed.
        }

        private DbSchedule DbScheduleInitializationInitializationRandom()
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
