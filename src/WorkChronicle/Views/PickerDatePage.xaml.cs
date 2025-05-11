namespace WorkChronicle.Views
{
    public partial class PickerDatePage : ContentPage
    {
        public PickerDatePage(PickerDateViewModel pickerDatePageViewModel)
        {
            InitializeComponent();
            BindingContext = pickerDatePageViewModel;
        }

        protected override bool OnBackButtonPressed()
        {
           Shell.Current.GoToAsync("///MainPage");
           return true;
        }
    }
}