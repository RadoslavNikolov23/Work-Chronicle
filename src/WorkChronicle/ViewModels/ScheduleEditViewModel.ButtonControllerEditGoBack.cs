namespace WorkChronicle.ViewModels
{
    public partial class ScheduleEditViewModel
    {
        [RelayCommand]
        private async Task EditShift()
        {
            if (this.SelectedShift == null)
                return;

            try
            {
                var popup = new ShiftEditPopup(this.SelectedShift!);
                var result = await Shell.Current.CurrentPage.ShowPopupAsync(popup);


                if (result is IShift editedShift)
                {
                    this.SelectedShift = editedShift;
                }
                else
                {
                    this.SelectedShift = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .............. in the ScheduleEditViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }

            try
            {
                
               //Here the user change chagne the selected shift from:
                // - 1) Working to rest day
                // - 2) From rest day to work day
                // - 3) Change the type of the work shift - Day to Night and Night to Day
                // - 4) Change the staring hour of the selected shift
                // - 5) Change the total hours of the selected shift

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in .......... in the ScheduleEditViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }

            await ShowPopupMessage(AppResources.Information, 
                                   AppResources.YourShiftHasBeenEdit);

            await GenerateTotalHours();
            this.SelectedShift = null;
            return;
        }

        [RelayCommand]
        private async Task GoBackButton()
        {
            var loadingPopup = new LoadingPopup();
            Shell.Current.ShowPopup(loadingPopup);
            await Task.Delay(100);

            await Shell.Current.GoToAsync("///MainPage");

            loadingPopup.Close();
        }
    }
}
