namespace WorkChronicle.Services.Contracts
{
    public interface IDbShiftServices
    {
        Task<List<DbShift>> ReturnShiftsForScheduleFromDB(int scheduleId);

        Task<(bool, bool)> EditShiftFromDB(IShift selectedShift, IShift shift);

        Task<(bool, bool)> CompensateShiftFromDB(IShift selectedShift, IShift shift);

        Task<(bool, bool)> SickLeaveMarkShiftFromDB(IShift selectedShift, IShift shift);

        Task<(bool, bool)> VacationLeaveMarkShiftFromDB(IShift selectedShift, IShift shift);
    }
}
