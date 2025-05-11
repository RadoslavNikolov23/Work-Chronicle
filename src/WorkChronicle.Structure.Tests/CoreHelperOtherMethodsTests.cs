namespace WorkChronicle.Structure.Tests
{
    using System.Reflection;
    using WorkChronicle.Common.Enums;
    using WorkChronicle.Structure.Configuration;
    using WorkChronicle.Structure.Core.Helpers;
    using WorkChronicle.Structure.Core.Helpers.Contracts;
    using WorkChronicle.Structure.Core.StrategyFactory;
    using WorkChronicle.Structure.Models;
    using WorkChronicle.Structure.Models.Contracts;
    using WorkChronicle.Structure.Repository;
    using WorkChronicle.Structure.Repository.Contracts;

    [TestFixture]
    public class CoreHelperOtherMethodsTests
    {
        //Some of the data is hidden.


        [SetUp]
        public void Setup()
        {
            //Some of the code is hidden.

        }


        [Test]
        public async Task GenerateBlankCalendar_WorksCorrectly_ReturnsBlankCalendar_For_TheCurrentMonth()
        {
            
            //Some of the code is hidden.

        }

        [Test]
        public async Task GeneratePreviousMonthDays_WorksCorrectly()
        {
            MethodInfo? methodGeneratePreviousMonthDays = typeof(EngineHelper).GetMethod(".......", BindingFlags.NonPublic | BindingFlags.Instance);

            //Some of the code is hidden.
        }

        [Test]
        public async Task GeneratePreviousMonthDays_WorksCorrectly_Second_Test_DifferentMonth()
        {
            MethodInfo? methodGeneratePreviousMonthDays = typeof(EngineHelper).GetMethod("........", BindingFlags.NonPublic | BindingFlags.Instance);

            //Some of the code is hidden.
        }

        [Test]
        public async Task GenerateNextMonthDays_WorksCorrectly()
        {
            //Some of the code is hidden.
            

            MethodInfo? methodGenerateNextMonthDays = typeof(EngineHelper).GetMethod(".........", BindingFlags.NonPublic | BindingFlags.Instance);

          //Some of the code is hidden.
        }

        [Test]
        public void HasShiftMonthChanged_WorksCorrectly()
        {
            MethodInfo? methodHasShiftMonthChanged = typeof(EngineHelper).GetMethod(".......", BindingFlags.NonPublic | BindingFlags.Instance);

            //Some of the code is hidden.
        }
    }
}
