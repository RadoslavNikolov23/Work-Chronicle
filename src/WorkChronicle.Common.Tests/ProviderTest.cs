namespace WorkChronicle.Common.Tests
{
    using WorkChronicle.Common.Providers;

    [TestFixture]
    public class ProviderTest
    {
        [Test]
        public void DoGetMonthName_Work_From_January_To_December_And_Other_Cases()
        {
            //Some of the test are removed

            Assert.That(Provider.GetMonthName(13), Is.EqualTo("Unknown"));
            Assert.That(Provider.GetMonthName(20), Is.EqualTo("Unknown"));
        }


        [Test]
        public void DoGetMonthHoursTotal_Work_From_January()
        {
            //Some of the test are altered

            DateTime startDate = new DateTime(....,...,....);

            KeyValuePair<int,string[]> result = Provider.GetMonthHoursTotal(.......);

            Assert.IsNotNull(.......);
            Assert.That(result.Key, Is.EqualTo(....));
            Assert.That(result.Value[0], Is.EqualTo("......"));
            Assert.That(result.Value[1], Is.EqualTo("....."));

        }

        [Test]
        public void DoGetMonthHoursTotal_Work_In_Other_Cases_Outside_The_Years_Given()
        {
            //Some of the test are altered

            DateTime startDate = new DateTime(....,...,....);

            KeyValuePair<int,string[]> result = Provider.GetMonthHoursTotal(......);

            Assert.IsNotNull(.......);
            Assert.That(result.Key, Is.EqualTo(.......));
            Assert.That(result.Value, .........);
        }
    }
}