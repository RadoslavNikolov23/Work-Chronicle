﻿namespace WorkChronicle
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<AppShell>();
            builder.Services.AddSingleton<ISchedule<IShift>, Schedule>();
            RegisterDateBaseComponents(builder.Services);
            RegisterVM(builder.Services);
            RegisterPages(builder.Services);

            return builder.Build();
        }
        static void RegisterDateBaseComponents(IServiceCollection services)
        {
            services.AddSingleton<WorkScheduleDB>();
            services.AddSingleton<IWorkScheduleRepositoryDB,WorkScheduleRepositoryDB>();
            services.AddSingleton<IWorkShiftRepositoryDB,WorkShiftRepositoryDB>();
        }
        static void RegisterPages(IServiceCollection services)
        {
            services.AddTransient<MainPage>();
            services.AddTransient<SchedulePage>();
            services.AddTransient<PickerDatePage>();
            services.AddTransient<YearSchedulePage>();
            services.AddTransient<LoadSchedulePage>();
        }

        static void RegisterVM(IServiceCollection services)
        {
            services.AddTransient<MainViewModel>();
            services.AddTransient<ScheduleEditViewModel>();
            services.AddTransient<PickerDateViewModel>();
            services.AddTransient<YearScheduleViewModel>();
            services.AddTransient<LoadScheduleViewModel>();
        }
    }
}
