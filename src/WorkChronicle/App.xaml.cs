namespace WorkChronicle
{
    public partial class App : Application
    {
        public App(AppShell appShell)
        {
            InitializeComponent();

            AppTheme currentTheme = Application.Current!.RequestedTheme;

            if (currentTheme == AppTheme.Unspecified || currentTheme == AppTheme.Dark)
            {
                Application.Current!.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                Application.Current!.UserAppTheme = AppTheme.Light;
            }



            var lang = Preferences.Get("AppLanguage", "en");
            LocalizationHelper.SetCulture(lang);

            MainPage = appShell;
        }

    }
}
