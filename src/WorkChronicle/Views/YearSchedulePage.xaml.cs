namespace WorkChronicle.Views
{
    public partial class YearSchedulePage : ContentPage
    {
        public YearSchedulePage(YearScheduleViewModel yearScheduleViewModel)
        {
            InitializeComponent();
            BindingContext = yearScheduleViewModel;
        }

        protected override bool OnBackButtonPressed()
        {
            Shell.Current.GoToAsync("///MainPage");
            return true;
        }
    }
}

