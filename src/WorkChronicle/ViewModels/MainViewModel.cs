namespace WorkChronicle.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ICommonServices commonServices;

        private IDbScheduleServices dbScheduleServices;

        private IDbShiftServices dbShiftServices;

        private DbSchedule? dbSchedule;

        private List<DbShift>? dbShifts;

        [ObservableProperty]
        private ISchedule<IShift> schedule;

        [ObservableProperty]
        private IShift? selectedShift;

        [ObservableProperty]
        private string calendarMonthYear = "";

        [ObservableProperty]
        private string textMessage = "";

        public IRelayCommand<SelectionChangedEventArgs> ShiftSelectedCommand { get; }

            public MainViewModel(ISchedule<IShift> schedule) //Using Dependency injection in the constructor for the services as well.
        { 
            //Some of the code in the constructor is removed.
            
            this.schedule = schedule;

            this.dbSchedule = new DbSchedule();
            this.dbShifts = new List<DbShift>();

            this.ShiftSelectedCommand = new AsyncRelayCommand<SelectionChangedEventArgs>(OnShiftSelected!);
        }

        public async Task RefreshThePage()
        {
            if (this.Schedule.WorkSchedule.Count == 0 || this.Schedule == null)
            {
                try
                {
                    //--Method to get the CurrentMonthSchedule from the DB repo.

                    // Check if the DB repo is not empty through the services and 
                    // calls the method LoadFromTheDBSchedule and the method GenerateCalendarMonthYearAndTotalHours.
                    
                    //if the DB Repo is empty calls the method from the DB Repo GetClosestSchedule
                    //if it is not empty repeats the LoadFromTheDBSchedule and GenerateCalendarMonthYearAndTotalHours
                    //if  is empty call the method GenerateBlankCalendar.

                }
                catch (Exception ex)
                {
                    await Logger.LogAsync(ex, "Error in .......... in the MainViewMode.cs");
                    await ShowPopupMessage(AppResources.Error,
                                           AppResources.SomethingWentWrongPleaseTryAgain);
                }
            }
            else
            {
                // Checks if the schedule is blank or a work schedule 
                // and creates the the calendar name and the info box information.
            }
        }

        private async Task LoadFromDBToSchedule()
        {
            this.Schedule.WorkSchedule.Clear();

             try
            {
                // Get the shifts for the DB repo through the services for the required schedule
                // and adds them in the schedule.WorkSchedule, that is bind with the UI.
                
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .......... in the MainViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }

            // If the Schedule is null or somethins else, the GenerateBlankCalendar method is called.
        }

        private async Task OnShiftSelected(SelectionChangedEventArgs args)
        {
            if (this.SelectedShift == null)
                return;

            if (this.SelectedShift.IsCurrentMonth == false)
            {
                await ShowPopupMessage(AppResources.Information,
                                       AppResources.ThisShiftIsNotInTheCurrentMonth);
                this.SelectedShift = null;
                return;
            }

            if (this.SelectedShift.ShiftType == ShiftType.RestDay)
            {
                if (this.SelectedShift.IsSickDay == true)
                {
                    await ShowPopupMessage(AppResources.Information,
                                           AppResources.ThisIsARestDayAndSickLeave);
                }
                else if (this.SelectedShift.IsVacationDay == true)
                {
                    await ShowPopupMessage(AppResources.Information,
                                           AppResources.ThisIsARestDayAndPaidUnpaidLeave);
                }
                else
                {
                    await ShowPopupMessage(AppResources.Information,
                                          AppResources.ThisIsARestDay);
                }
 
                this.SelectedShift = null;
                return;
            }

            try
            {
                var popup = new ShiftInfoPopup(this.SelectedShift);
                await Shell.Current.CurrentPage.ShowPopupAsync(popup);

            }
            catch (Exception ex)
            {
               await Logger.LogAsync(ex, "Error in ........ in the MainViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgai
            }

            this.SelectedShift = null;
            return;
        }

        private async Task GenerateBlankCalendar()
        {
            await UpdateCalendarMonthYear(DateTime.Now.Month, DateTime.Now.Year);

             try
            {

                //Generates a Blank Calendar for the current month.
                // Calls the Main engine class through the services from the Structured class library.

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... class");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }

            this.TextMessage = String.Format(AppResources.TextMessageThisIsACalendar,
                                            CulturalProvider.GetMonthName(DateTime.Now.Month),
                                            DateTime.Now.Year);
        }

        private async Task GenerateCalendarMonthYearAndTotalHours()
        {
             //This Method generates the calendar month and year hours
            // They are displayed in the info text box.
        }

        private async Task UpdateCalendarMonthYear(int month, int year)
        {
            await Task.Delay(10);
            this.CalendarMonthYear = String.Format(AppResources.CalendarWorkScheduleFor,
                                                   CulturalProvider.GetMonthName(month), year);
        }

        private async Task ShowPopupMessage(string title, string text)
        {
            await Shell.Current.DisplayAlert(title, text, "OK");
        }

        [RelayCommand]
        private async Task GoToEditSchedule()
        {
            var loadingPopup = new LoadingPopup();
            Shell.Current.ShowPopup(loadingPopup);
            await Task.Delay(100);

            await Shell.Current.GoToAsync(nameof(SchedulePage));
            loadingPopup.Close();
        }
    }
}
