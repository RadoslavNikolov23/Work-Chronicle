namespace WorkChronicle.Structure.Tests
{
    using System.Collections.ObjectModel;
    using System.Reflection;
    using WorkChronicle.Common.Enums;
    using WorkChronicle.Common.HoursCoefficients;
    using WorkChronicle.Structure.Models;
    using WorkChronicle.Structure.Models.Contracts;
    using WorkChronicle.Structure.Repository;
    using WorkChronicle.Structure.Repository.Contracts;

    [TestFixture]
    public class RepositoryScheduleTest
    {
        private ISchedule<IShift> schedule;

        [SetUp]
        public void Setup()
        {
            schedule = new Schedule();
        }

        [Test]
        public void Test_Initialization_Works_Correctly()
        {
            ISchedule<IShift> scheduleFirst = new Schedule();

            Assert.IsNotNull(scheduleFirst);
            Assert.IsInstanceOf<Schedule>(scheduleFirst);
            Assert.IsInstanceOf<ISchedule<IShift>>(scheduleFirst);
            Assert.IsInstanceOf<ObservableCollection<IShift>>(scheduleFirst.WorkSchedule);
        }

        [Test]
        public async Task Do_Add_Method_Works_Correctly()
        {
            //Some of the code is hidden.
        }

        [Test]
        public async Task Do_Remove_Method_Works_Correctly()
        {
            I//Some of the code is hidden.
        }

        [Test]
        public async Task Do_IndexOf_Method_Works_Correctly()
        {
           //Some of the code is hidden.
        }

        [Test]
        public async Task Do_GetLastWorkingShift_Method_Works_Correctly()
        {
           //Some of the code is hidden.
        }

        [Test]
        public async Task Do_GetTypeOfTheLastWorkingShift_Method_Works_Correctly()
        {
           //Some of the code is hidden.
        }


        [Test]
        public async Task Do_TotalShifts_Method_Works_Correctly()
        {
           //Some of the code is hidden.
        }

        [Test]
        public async Task Do_TotalCompensatedShifts_Method_Works_Correctly()
        {
           //Some of the code is hidden.
        }

        [Test]
        public async Task Do_CalculateTotalSickDaysHours_Method_Works_Correctly_DayHours()
        {
           //Some of the code is hidden.
            
        }

        [Test]
        public async Task Do_CalculateTotalSickDaysHours_Method_Works_Correctly_NightHours()
        {
           //Some of the code is hidden.
        }

        [Test]
        public async Task Do_CalculateTotalVacationDaysHours_Method_Works_Correctly_DayHours()
        {
           //Some of the code is hidden.
        }

        [Test]
        public async Task Do_CalculateTotalVacationDaysHours_Method_Works_Correctly_NightHours()
        {
          //Some of the code is hidden.
        }


        [Test]
        public async Task Do_CalculateTotalWorkHours_Method_Works_Correctly()
        {
           //Some of the code is hidden.
        }

        [Test]
        public async Task Do_CalculateShiftHoursMethod_Works_Correctly()
        {
           //Some of the code is hidden.
        }

        [Test]
        public void Do_GetNightShiftMultiplier_Works_Correctly()
        {
           //Some of the code is hidden.
        }
    }
}