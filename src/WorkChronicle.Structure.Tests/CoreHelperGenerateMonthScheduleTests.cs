namespace WorkChronicle.Structure.Tests
{
    using WorkChronicle.Common.Enums;
    using WorkChronicle.Structure.Configuration;
    using WorkChronicle.Structure.Core.Helpers;
    using WorkChronicle.Structure.Core.Helpers.Contracts;
    using WorkChronicle.Structure.Core.Schedules.Contracts;
    using WorkChronicle.Structure.Core.StrategyFactory;
    using WorkChronicle.Structure.Models.Contracts;
    using WorkChronicle.Structure.Repository;
    using WorkChronicle.Structure.Repository.Contracts;

    [TestFixture]   
    public class CoreHelperGenerateMonthScheduleTests
    {
        //Some of the data is hidden.


        [SetUp]
        public void Setup()
        {
            //Some of the code is hidden.
        }

        //-------------------- GenerateMonthSchedule Tests:---------------------------------------
        //This Methods is the second of the EngineHelper class, and the last in the line of the CalculateShifts in the Engine class and will return a full working schedule.

        [Test]
        public async Task GenerateMonthSchedule_Works_Correctly_For_Day24Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GenerateMonthSchedule_Works_Correctly_For_DayDaychedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GenerateMonthSchedule_Works_Correctly_For_DayNightchedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GenerateMonthSchedule_Works_Correctly_For_DayNightschedule_And_FirstChoice_IsNightShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GenerateMonthSchedule_Works_Correctly_For_DayNightNightSchedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GenerateMonthSchedule_Works_Correctly_For_DayNightNightSchedule_And_FirstChoice_IsNightShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GenerateMonthSchedule_Works_Correctly_For_DayNightNightSchedule_And_FirstChoice_IsSecondNightShift()
        {
            //Some of the code is hidden.
        }
    }
}
