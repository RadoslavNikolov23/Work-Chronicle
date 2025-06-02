namespace WorkChronicle.ViewModels
{
    public partial class LoadScheduleViewModel : BaseViewModel
    {
        private ICommonServices commonServices;

        private IDbScheduleServices dbScheduleServices;

        private IDbShiftServices dbShiftServices;

        private DbSchedule? dbSchedule;

        private List<DbShift>? dbShifts;

        [ObservableProperty]
        private ISchedule<IShift> schedule;

        [ObservableProperty]
        private ObservableCollection<string> scheduleNames;

        [ObservableProperty]
        private string? selectedScheduleName = "";

        [ObservableProperty]
        private bool isLabelEmptyVisible = false;

        public LoadScheduleViewModel()
        {
           //Some of the code is removed
        }

        public async Task RefreshThePage()
        {
            await LoadScheduleNames();
        }

        private async Task LoadScheduleNames()
        {
            this.ScheduleNames.Clear();

            try
            {
                //The method loads from the DB all of the saved schedules
                // through the services and the user can pick which one to delete or to load

                
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... in the LoadScheduleViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }
        }

        [RelayCommand]
        private async Task DeleteSelectedSchedule()
        {
             if (string.IsNullOrEmpty(this.SelectedScheduleName))
            {
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.PleaseSelectASchedule);
                this.SelectedScheduleName = null;
                return;
            }

            try
            {
 

                bool overwrite = await Shell.Current
                                              .DisplayAlert(
                                                  AppResources.Information,
                                                  AppResources.ThisWillDeleteTheScheduleDoContinue,
                                                  "OK",
                                                  "Cancel");
                if (!overwrite)
                    return;

               //The method deletes the chosen schedule from the DB through the services
               //and then the page is refresh, as the LoadScheduleNames method is called
                
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ........ in the LoadScheduleViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }
        }

        [RelayCommand]
        private async Task LoadSelectedSchedule()
        {
            if (string.IsNullOrEmpty(this.SelectedScheduleName))
            {
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.PleaseSelectASchedule);

                this.SelectedScheduleName = null;
                return;
            }

             try
            {
               //The method loads the chosen schedule from the DB through the services
               //and then the LoadFromDBToSchedule method is called

                await LoadFromDBToSchedule();
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... in the LoadScheduleViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }
        }

        private async Task LoadFromDBToSchedule()
        {
            this.Schedule.WorkSchedule.Clear();

           try
            {

                //This methods load the selected saved schedule and shifts from the DB
                // through the services and replace the one in the schedule.WorkSchedule
                // then goes back to the main page with the loaded schedule
               
                        
                        var loadingPopup = new LoadingPopup();
                        Shell.Current.ShowPopup(loadingPopup);
                        await Task.Delay(100);

                        await Shell.Current.GoToAsync("///MainPage");
                        loadingPopup.Close();
                    
                
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ........ in the LoadScheduleViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }
        }

        private async Task ShowPopupMessage(string title, string text)
        {
            await Shell.Current.DisplayAlert(title, text, "OK");
        }
    }
}
