namespace WorkChronicle.ViewModels
{
    public partial class PickerDateViewModel : BaseViewModel
    {
        private ICommonServices commonServices;

        private IDbScheduleServices dbScheduleServices;

        [ObservableProperty]
        private ISchedule<IShift> schedule;

        [ObservableProperty]
        private DateTime selectedStartDate;

        [ObservableProperty]
        private string selectedSchedule = "";

        [ObservableProperty]
        private string resultsMessage = "";

        [ObservableProperty]
        private string selectedFirstShift = "";

        [ObservableProperty]
        private TimeSpan dayShiftStartTime;

        [ObservableProperty]
        private TimeSpan nightShiftStartTime;

        [ObservableProperty]
        private TimeSpan totalShiftHours;

        public ObservableCollection<string> WorkSchedules { get; } = new()
        {
            AppResources.Day24Hour,
            AppResources.DayDay,
            AppResources.DayNight,
            AppResources.DayNightNight
        };

        [ObservableProperty]
        private ObservableCollection<string> workShift = new()
        {
            AppResources.DayShift,
            AppResources.NightShift,
        };

        [ObservableProperty]
        private bool isFirstShiftEnabled = true;

        [ObservableProperty]
        private bool isStatNightShiftEnabled = true;

        public PickerDateViewModel()
        {
            //Some of the code is removed
        }

        partial void OnSelectedScheduleChanged(string value)
        {
            UpdateShiftOptions(value);
        }

        private void UpdateShiftOptions(string selectedSchedule)
        {
            if (selectedSchedule == AppResources.Day24Hour)
            {
                this.WorkShift = new ObservableCollection<string>()
                                        {
                                            AppResources.DayShift,
                                        };
                this.IsFirstShiftEnabled = true;
                this.IsStatNightShiftEnabled = false;
            }
            else if (selectedSchedule == AppResources.DayDay)
            {
                this.WorkShift = new ObservableCollection<string>
                                        {
                                            AppResources.DayShift,
                                            AppResources.DayShiftSecond
                                        };
                this.SelectedFirstShift = this.WorkShift[0];
                this.IsFirstShiftEnabled = true;
                this.IsStatNightShiftEnabled = false;

            }
            else if (selectedSchedule == AppResources.DayNightNight)
            {
                this.WorkShift = new ObservableCollection<string>
                                        {
                                            AppResources.DayShift,
                                            AppResources.NightShift,
                                            AppResources.NightShiftSecond
                                        };
                this.SelectedFirstShift = this.WorkShift[0];

                this.IsFirstShiftEnabled = true;
                this.IsStatNightShiftEnabled = true;
            }
            else
            {
                this.WorkShift = new ObservableCollection<string>
                                        {
                                            AppResources.DayShift,
                                            AppResources.NightShift
                                        };
                this.SelectedFirstShift = this.WorkShift[0];

                this.IsFirstShiftEnabled = true;
                this.IsStatNightShiftEnabled = true;
            }
        }

        private async Task<string[]> ValidateSchedule()
        {
            await Task.Yield();

            string selectedScheduleString = string.Empty;

            if (this.SelectedSchedule == AppResources.Day24Hour)
            {
                selectedScheduleString = "Day24Hour";
            }
            else if (this.SelectedSchedule == AppResources.DayDay)
            {
                selectedScheduleString = "Day-Day";
            }
            else if (this.SelectedSchedule == AppResources.DayNight)
            {
                selectedScheduleString = "Day-Night";
            }
            else if (this.SelectedSchedule == AppResources.DayNightNight)
            {
                selectedScheduleString = "Day-Night-Night";
            }
            else
            {
                return [];
            }

            string[] cycle = selectedScheduleString.Split('-');

            if (cycle.Length == 0)
            {
                return [];
            }

            return cycle;
        }

        private async Task ShowPopupMessage(string title, string text)
        {
            await Shell.Current.DisplayAlert(title, text, "OK");
        }
    }
}
