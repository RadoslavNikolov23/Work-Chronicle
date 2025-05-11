namespace WorkChronicle
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(PickerDatePage), typeof(PickerDatePage));
            Routing.RegisterRoute(nameof(YearSchedulePage), typeof(YearSchedulePage));
            Routing.RegisterRoute(nameof(SchedulePage), typeof(SchedulePage));
            Routing.RegisterRoute(nameof(LoadSchedulePage), typeof(LoadSchedulePage));

        }

        private async void OnChangeLanguageClicked(object sender, EventArgs e)
        {
           // The method changes the app language from english to bulgarian 
           // The app default language is set to english, but is also set
           // to the region of the phone, so i will be change as well
        }

        private async Task ChangeLanguageAsync(string langCode)
        {
            // A privete method that helpes change the app language

            //Note: the user will have to restart the app, because the code Application.Current.MainPage = new AppShell();
            // DOES NOT WORK - does not change the UI elements!
            //The alter code is a popup info box that informs the user that the app
            // will be closed and he need to open it again.
 
        }

        private async void OnAboutGitHubClicked(object sender, EventArgs e)
        {
            var url = "https://github.com/RadoslavNikolov23/Work-Chronicle";
            await Launcher.Default.OpenAsync(url);
        }

        private async void OnReportAProblemClicked(object sender, EventArgs e)
        {

            try
            {


                var logFilePath = Logger.GetLogFilePath();

                EmailMessage? message = null;

                
                // The method sends a report to the given email

                if (File.Exists(logFilePath))
                {
                    // and if there where some errors, a file will be generated
                    // and will be sent with the email.
                }
                else
                {
                    // if there where no error the file will not be created
                    // and will not be sent with the email.

                }

                await Email.Default.ComposeAsync(message);

                Logger.ClearLog();
            }
            catch (FeatureNotSupportedException)
            {
                await Application.Current!.MainPage!
                                          .DisplayAlert("Error",
                                                        "Email is not supported on this device.",
                                                        "OK");
            }
            catch (Exception ex)
            {
                await Application.Current!.MainPage!
                                          .DisplayAlert("Error",
                                                        $"An unexpected error occurred: {ex.Message}",
                                                        "OK");
            }
        }

        private async void OnExitClicked(object sender, EventArgs e)
        {
            await Task.Delay(100);
            Application.Current!.Quit();
        }
    }
}
