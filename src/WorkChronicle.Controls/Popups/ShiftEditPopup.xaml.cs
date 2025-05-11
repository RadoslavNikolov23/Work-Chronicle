namespace WorkChronicle.Controls.Popups
{
    public partial class ShiftEditPopup : Popup, INotifyPropertyChanged
    {
        private readonly IShift shift;

        private IList<string> shiftTypes = new List<string>()
        {
            ControlAppResources.DayShift,
            ControlAppResources.NightShift,
            ControlAppResources.RestDay
        };

        public ShiftEditPopup(IShift shift)
        {
            InitializeComponent();

            //Some of the code is hidden
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            //Some of the code is hidden
        }
    }
}