namespace WorkChronicle.Structure.Tests
{
    using WorkChronicle.Common.Enums;
    using WorkChronicle.Structure.Configuration;
    using WorkChronicle.Structure.Core.Main;
    using WorkChronicle.Structure.Core.Main.Contracts;
    using WorkChronicle.Structure.Models.Contracts;
    using WorkChronicle.Structure.Repository.Contracts;
    using WorkChronicle.Structure.YearScheduleModels.Contracts;

    [TestFixture]
    public class CoreEngineTests
    {
        
        //Some of the data is hidden.


        [SetUp]
        public void Setup()
        {
            //Some of the data is hidden.
        }

        [Test]
        public void Do_Engine_Initialize_Correctly()
        {
            IEngine<ISchedule<IShift>> engineNew = new Engine();

            Assert.IsNotNull(engineNew);
            Assert.IsInstanceOf<Engine>(engineNew);
            Assert.IsInstanceOf<IEngine<ISchedule<IShift>>>(engineNew);

        }

        //--------------------MonthScheduleMethod Tests:---------------------------------------

        [Test]
        public async Task CalculateShifts_ShouldReturn_24Hour_Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task CalculateShifts_ShouldReturn_DayDay_Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task CalculateShifts_ShouldReturn_DayNight_Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task CalculateShifts_ShouldReturn_DayNight_Schedule_And_FirstChoice_NightShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task CalculateShifts_ShouldReturn_DayNightNight_Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task CalculateShifts_ShouldReturn_DayNightNight_Schedule_And_FirstChoice_NightShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task CalculateShifts_ShouldReturn_DayNightNight_Schedule_And_FirstChoice_SecondNightShift()
        {
            //Some of the code is hidden.
        }

        //--------------------YearScheduleMethod Tests:---------------------------------------

        [Test]
        public async Task GeneratedYearSchedule_ShouldReturn_24Hour_Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GeneratedYearSchedule_ShouldReturn_DayDay_Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GeneratedYearSchedule_ShouldReturn_DayNight_Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GeneratedYearSchedule_ShouldReturn_DayNight_Schedule_And_FirstChoice_NightShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GeneratedYearSchedule_ShouldReturn_DayNightNight_Schedule()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GeneratedYearSchedule_ShouldReturn_DayNightNight_Schedule_And_FirstChoice_NightShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GeneratedYearSchedule_ShouldReturn_DayNightNight_Schedule_And_FirstChoice_SecondNightShift()
        {
            //Some of the code is hidden.
        }


        [Test]
        public async Task BlankCalendar_ShouldReturn_BlankCalendar()
        {
            //Some of the data is hidden.
        }
    }
}