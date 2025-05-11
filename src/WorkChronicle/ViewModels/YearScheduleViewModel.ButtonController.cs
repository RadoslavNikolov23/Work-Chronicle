namespace WorkChronicle.ViewModels
{
    public partial class YearScheduleViewModel
    {
        [RelayCommand]
        private async Task GenerateYearSchedule()
        {
            bool overwrite = await Shell.Current
                                        .DisplayAlert(AppResources.Information,
                                                    String.Format(AppResources
                                                    .CreatingYearScheduleWillOverrideDeleteSavedMonthSchedulesForYear, this.SelectedStartDate.Year),
                                                    "OK",
                                                    "Cancel");
            if (!overwrite)
                return;

            //The main button to generte a year schedule
            // - 1) First it checks if all the input is correct

            var creatingPopup = new CreatingPopup();
            Shell.Current.ShowPopup(creatingPopup);

            try
            {
                // - 2) Call the main engine class in the structure library to generated
                //the correct year schedule


                // -3) Starts to Save the Schedules to the DB

                 // -3) Starts to Save the Schedules to the DB


                creatingPopup.Close();
                await Task.Delay(20);

                var loadingPopup = new LoadingPopup();
                Shell.Current.ShowPopup(loadingPopup);
                await Task.Delay(100);

                // - 4) Goes back to the Main Page
                await Shell.Current.GoToAsync("///MainPage");
                loadingPopup.Close();
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .............. in the YearScheduleViewModel.cs");

                creatingPopup.Close();
                await Task.Delay(20);

                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }
        }
    }
}
