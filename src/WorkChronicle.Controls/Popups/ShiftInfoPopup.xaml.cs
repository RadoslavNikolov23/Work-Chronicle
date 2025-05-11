namespace WorkChronicle.Controls.Popups
{
    public partial class ShiftInfoPopup : Popup
    {
        public ShiftInfoPopup(IShift shift)
        {
            InitializeComponent();

            //Some of the code is hidden
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            Close();
        }

        public static string FormatTimeOfDay(double hourValue)
        {
            TimeSpan time = TimeSpan.FromHours(hourValue);
            DateTime timeOfDay = DateTime.Today.Add(time);

            var culture = Thread.CurrentThread.CurrentUICulture;
            return timeOfDay.ToString("t", culture);
        }
    }
}