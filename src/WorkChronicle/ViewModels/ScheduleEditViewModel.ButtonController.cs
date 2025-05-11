namespace WorkChronicle.ViewModels
{
    public partial class ScheduleEditViewModel
    {
        [RelayCommand]
        private async Task CompensateButton()
        {
            if (this.SelectedShift == null)
                return;

            if (await IsSelectedShiftRestType(AppResources.ThisIsARestDayAndItCantBeCompensated))
                return;

            if (await IsSelectedShiftSickDay(AppResources.ThisIsASickLeaveDayAndItCantBeCompensated))
                return;

            if (await IsSelectedShiftVacationDay(AppResources.ThisIsAPaidLeaveDayAndItCantBeCompensated))
                return;

            try
            {
                //Here the shift is turn to a Compensate or the user can Uncompensate the shift
               
            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in ......... in the ScheduleEditViewModel.cs");
                await ShowPopupMessage(AppResources.Error, AppResources.SomethingWentWrongPleaseTryAgain);
            }

        }

        [RelayCommand]
        private async Task SickLeaveButton()
        {
            if (this.SelectedShift == null)
                return;

            if (await IsSelectedShiftVacationDay
                                    (AppResources.ThisShiftMarkedOnPaidLeaveMustFirstConvertedWorking))
                return;

            if (await IsSelectedShiftCompensated
                                    (AppResources.ThisIsACompensatedSiftAndFirstMustBeConvertedToWork))
                return;

            try
            {
                //Here the shift is turn to a Sick leave or the user can change it back the original shift type.

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in SickLeaveButton in the ScheduleEditViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }

            
        }

        [RelayCommand]
        private async Task VacationDayButton()
        {
            if (this.SelectedShift == null)
                return;

            if (await IsSelectedShiftSickDay
                                    (AppResources.ThiShiftMarkedSickLeaveCannotMarkedPaidUnpaidLeave))
                return;

            if (await IsSelectedShiftCompensated
                                    (AppResources.ThisIsACompensatedSiftAndFirstMustBeConvertedToWork))
                return;

            try
            {
                //Here the shift is turn to a Paid or Unpaid leave or the user can change it back the original shift type.

            }
            catch (Exception ex)
            {
                await Logger.LogAsync(ex, "Error in VacationDayButton in the ScheduleEditViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }
        }
    }
}
