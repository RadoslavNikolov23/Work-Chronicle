namespace WorkChronicle.Common.Providers
{
    public class Provider
    {
        public static KeyValuePair<int, string[]> GetMonthHoursTotal(DateTime startDate)
        {
            return startDate.Year switch
            {
                2026 => WorkHoursByYear.Year2026(startDate.Month),
                2025 => WorkHoursByYear.Year2025(startDate.Month),
                2024 => WorkHoursByYear.Year2024(startDate.Month),
                2023 => WorkHoursByYear.Year2023(startDate.Month),
                2022 => WorkHoursByYear.Year2022(startDate.Month),
                2021 => WorkHoursByYear.Year2021(startDate.Month),
                _ => new KeyValuePair<int, string[]>()
            };
        }

        public static string GetMonthName(int month)
        {
            return month switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => "Unknown",
            };
        }
    }
}
