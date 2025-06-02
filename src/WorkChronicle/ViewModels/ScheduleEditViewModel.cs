namespace WorkChronicle.ViewModels
{
    public partial class ScheduleEditViewModel : BaseViewModel
    {
        private IDbShiftServices dbShiftServices;

        [ObservableProperty]
        private ISchedule<IShift> schedule;

        public IRelayCommand<SelectionChangedEventArgs> ShiftSelectedCommand { get; }

        [ObservableProperty]
        private IShift? selectedShift;

        [ObservableProperty]
        private string textMessage = "";

        [ObservableProperty]
        private string hoursMessage = "";

        [ObservableProperty]
        private string calendarMonthYear = "";

        DateTime startDate;

        public ScheduleEditViewModel()

             //Some of the code is removed
        }
        public async Task RefreshThePage()
        {
           //The main method of refreshing the page UI element
        }

        private async Task OnShiftSelected(SelectionChangedEventArgs args)
        {
            if (this.SelectedShift == null)
            {
                return;
            }

            if (this.SelectedShift.IsCurrentMonth == false)
            {
                await ShowPopupMessage(AppResources.Information,
                                       AppResources.ThisShiftIsNotInTheCurrentMonth);

                this.SelectedShift = null;
                return;
            }
        }

        private async Task GenerateTotalHours()
        {
            //This methods genetrates information in the main info box
            // - 1) Calculates the work hours of the month schedule
            // - 2) Get and dispalies the total working hour for the current month
            // - 3) Calculates if there are hour for compensation or not - and show the
            //user that how much hours are under or over the total work hours for the month
            // - 4) Calculates Sick leaves and Paid/Unpaid leaves hours.
        }

        private async Task UpdateCalendarMonthYear()
        {
            await Task.Delay(10);

            int year = this.startDate.Year;
            int month = this.startDate.Month;

            this.CalendarMonthYear = String.Format(AppResources.CalendarWorkScheduleFor,
                                                  CulturalProvider.GetMonthName(month), year);
        }

        private async Task ShowPopupMessage(string title, string text)
        {
            await Shell.Current.DisplayAlert(title, text, "OK");
        }

        private async Task<bool> IsSelectedShiftRestType(string text)
        {
            if (this.SelectedShift!.ShiftType == ShiftType.RestDay)
            {
                await ShowPopupMessage(AppResources.Information, text);
                this.SelectedShift = null;
                return true;
            }

            return false;
        }

        private async Task<bool> IsSelectedShiftSickDay(string text)
        {
            if (this.SelectedShift!.IsSickDay == true)
            {
                await ShowPopupMessage(AppResources.Information, text);
                this.SelectedShift = null;
                return true;
            }

            return false;
        }

        private async Task<bool> IsSelectedShiftVacationDay(string text)
        {
            if (this.SelectedShift!.IsVacationDay == true)
            {
                await ShowPopupMessage(AppResources.Information, text);
                this.SelectedShift = null;
                return true;
            }

            return false;
        }

        private async Task<bool> IsSelectedShiftCompensated(string text)
        {
            if (this.SelectedShift!.IsCompensated == true)
            {
                await ShowPopupMessage(AppResources.Information, text);
                this.SelectedShift = null;
                return true;
            }

            return false;
        }

        private Task<IShift?> GetFirstShiftFromSchedule()
        {
            IShift? shift = this.Schedule.WorkSchedule
                                             .Where(s => s.Year == this.SelectedShift!.Year
                                                         && s.Month == this.SelectedShift.Month
                                                         && s.Day == this.SelectedShift.Day)
                                             .FirstOrDefault();

            return Task.FromResult(shift);
        }
    }
}
