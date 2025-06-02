namespace WorkChronicle.Structure.Tests
{
    using WorkChronicle.Common.Enums;
    using WorkChronicle.Structure.Configuration;
    using WorkChronicle.Structure.Core.Helpers;
    using WorkChronicle.Structure.Core.Helpers.Contracts;
    using WorkChronicle.Structure.Models;
    using WorkChronicle.Structure.Models.Contracts;
    using WorkChronicle.Structure.Repository;
    using WorkChronicle.Structure.Repository.Contracts;

    [TestFixture]
    public class CoreHelperAddShiftsTests
    {

        //Some of the data is hidden.

        [SetUp]
        public void Setup()
        {
            //Some of the data is hidden.
        }

        //-------------------- AddShiftsToSchedule Tests:---------------------------------------
        //This Methods is the first of the EngineHelper class, and the second in the line of the CalculateShifts in the Engine class and will be without the first shifts of the schedule and will generate only the working shifts of the schedule.

        [Test]
        public async Task AddShiftsToSchedule_Works_Correctly_For_Day24Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task AddShiftsToSchedule_Works_Correctly_For_DayDaySchedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task AddShiftsToSchedule_Works_Correctly_For_DayNightSchedule()
        {
            //Some of the code is hidden.
        }
  
        [Test]
        public async Task AddShiftsToSchedule_Works_Correctly_For_DayNightSchedule_And_FirstChoice_IsNightShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task AddShiftsToSchedule_Works_Correctly_For_DayNightNightSchedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task AddShiftsToSchedule_Works_Correctly_For_DayNightNightSchedule_And_FirstChoice_IsNightShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task AddShiftsToSchedule_Works_Correctly_For_DayNightNightSchedule_And_FirstChoice_IsSecondNightShift()
        {
            //Some of the code is hidden.
        }
    }
}