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

            if (this.SelectedShift!.IsCompensated)
            {
                await ShowPopupMessage(AppResources.Information,
                                       AppResources.SelectedShiftIsCompensated);
            }
            else
            {
                await ShowPopupMessage(AppResources.Information,
                                       AppResources.SelectedShiftIsWorkingShiftAgain);
            }

            this.SelectedShift = null;
            await GenerateTotalHours();
            return;
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
                await Logger.LogAsync(ex, "Error in ............. in the ScheduleEditViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }

            if (this.SelectedShift!.IsSickDay)
            {
                await ShowPopupMessage(AppResources.Information,
                                       AppResources.SelectedShiftIsMarkedAsSickLeaveDay);
            }
            else
            {
                await ShowPopupMessage(AppResources.Information,
                                       AppResources.SelectedShiftIsWorkingShiftAgain);
            }

            this.SelectedShift = null;
            await GenerateTotalHours();
            return;
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
                await Logger.LogAsync(ex, "Error in ....................... in the ScheduleEditViewModel.cs");
                await ShowPopupMessage(AppResources.Error, 
                                       AppResources.SomethingWentWrongPleaseTryAgain);
            }

            if (this.SelectedShift!.IsVacationDay)
            {
                await ShowPopupMessage(AppResources.Information,
                                       AppResources.SelectedShiftIsMarkedAsPaidUnpaidLeave);
            }
            else
            {
                await ShowPopupMessage(AppResources.Information,
                                       AppResources.SelectedShiftIsWorkingShiftAgain);
            }

            this.SelectedShift = null;
            await GenerateTotalHours();
            return;
        }
    }
}
