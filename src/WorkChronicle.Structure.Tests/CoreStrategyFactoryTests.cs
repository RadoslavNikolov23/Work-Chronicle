namespace WorkChronicle.Structure.Tests
{
    using WorkChronicle.Structure.Configuration;
    using WorkChronicle.Structure.Core.Helpers;
    using WorkChronicle.Structure.Core.Helpers.Contracts;
    using WorkChronicle.Structure.Core.Schedules;
    using WorkChronicle.Structure.Core.StrategyFactory;
    using WorkChronicle.Structure.Models.Contracts;
    using WorkChronicle.Structure.Repository.Contracts;

    [TestFixture]   
    public class CoreStrategyFactoryTests
    {
        //Some of the data is hidden.

        [SetUp]
        public void Setup()
        {
            this.engineHelper = new EngineHelper();
            this.factory = new EngineStrategyFactory(engineHelper);
        }

        [Test]
        public async Task GetStrategy_ShouldReturnShiftsDay24_WhenPatternIs24Dayshift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GetStrategy_ShouldReturnShiftsDayDay_WhenPatternIsDayDayShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GetStrategy_ShouldReturnShiftsDayNight_WhenPatternIsDayNightShift()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task GetStrategy_ShouldReturnShiftsDayNightNight_WhenPatternIsNotMatched()
        {
            //Some of the code is hidden.
        }
    }
}
