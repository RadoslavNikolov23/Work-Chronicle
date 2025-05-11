namespace WorkChronicle.Common.Tests
{
    using System.Globalization;
    using WorkChronicle.Common.Helpers;

    [TestFixture]
    public class LocalizationHelperTest
    {
        [Test]
        public void SetCulture_ValidCultureCode_SetsCulture()
        {
            string cultureCode = "en-US";
            LocalizationHelper.SetCulture(cultureCode);

            Assert.That(Thread.CurrentThread.CurrentCulture.Name, Is.EqualTo(cultureCode));
            Assert.That(Thread.CurrentThread.CurrentUICulture.Name, Is.EqualTo(cultureCode));
        }

        [Test]
        public void SetCulture_ValidCultureCode_SetsCulture_bg_BG()
        {
            string cultureCode = "bg-BG";
            LocalizationHelper.SetCulture(cultureCode);

            Assert.That(Thread.CurrentThread.CurrentCulture.Name, Is.EqualTo(cultureCode));
            Assert.That(Thread.CurrentThread.CurrentUICulture.Name, Is.EqualTo(cultureCode));
        }

        [Test]
        public void SetCulture_InvalidCultureCode_ThrowsException()
        {
            string cultureCode = "invalid-culture-code";

            Assert.Throws<CultureNotFoundException>(() => LocalizationHelper.SetCulture(cultureCode));
        }

        [Test]
        public void CurrentCulture_ReturnsCorrectCulture()
        {
            string cultureCode = "en-US";
            LocalizationHelper.SetCulture(cultureCode);
            string currentCulture = LocalizationHelper.CurrentCulture;

            Assert.That(currentCulture, Is.EqualTo("en"));
        }

        [Test]
        public void CurrentCulture_ReturnsCorrectCulture_bg_BG()
        {
            string cultureCode = "bg-BG";
            LocalizationHelper.SetCulture(cultureCode);
            string currentCulture = LocalizationHelper.CurrentCulture;

            Assert.That(currentCulture, Is.EqualTo("bg"));
        }
    }
}
