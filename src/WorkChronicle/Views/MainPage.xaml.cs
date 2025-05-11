namespace WorkChronicle.Views
{
    public partial class MainPage : ContentPage
    {
        private DateTime lastBackPressed;
        private readonly TimeSpan backPressThreshold = TimeSpan.FromSeconds(2);

        public MainPage(MainViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is MainViewModel mv)
            {
                await mv.RefreshThePage();
            }
        }

        protected override bool OnBackButtonPressed()
        {
            var now = DateTime.Now;

            if (now - this.lastBackPressed <= this.backPressThreshold)
            {
                Application.Current!.Quit();
            }
            else
            {
                this.lastBackPressed = now;
                ShowToast(AppResources.PressBackAgainToExit);
            }

            return true;
        }

        private async void ShowToast(string message)
        {
            await Toast.Make(message, ToastDuration.Short).Show();
        }
    }
}
