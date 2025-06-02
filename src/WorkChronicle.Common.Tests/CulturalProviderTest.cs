namespace WorkChronicle.Common.Tests
{
    using WorkChronicle.Common.Providers;

    [TestFixture]
    public class CulturalProviderTest
    {
        [Test]
        public void GetMonthName_ValidMonth_ReturnsCorrectMonthName()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            int month = 1; 
            string result = CulturalProvider.GetMonthName(month);

            Assert.That(result, Is.EqualTo("January"));

        }

        [Test]
        public void GetMonthName_InvalidMonth_ReturnsEmptyString()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            int month = 13; 
            string result = CulturalProvider.GetMonthName(month);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetMonthName_InvalidMonth_ReturnsUnknown()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            object month = "13.9";
            string result=string.Empty;
            Assert.Throws<InvalidCastException>(
                                             () => result = CulturalProvider.GetMonthName((int)month));
        }

        [Test]
        public void GetMonthName_BGCulture_ReturnsCorrectMonthName()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            int month = 08; 

            string result = CulturalProvider.GetMonthName(month);

            Assert.That(result,Is.EqualTo("август"));
        }
    }
}
