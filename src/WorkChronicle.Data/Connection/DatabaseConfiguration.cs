namespace WorkChronicle.Data.Connection
{
    public static class DatabaseConfiguration
    {
        //To protect the connection some of the code is removed
        public static string? TestOverridePath { get; set; }

        private const string DatabaseFilename = "........";

        public const SQLite.SQLiteOpenFlags Flags =................;

        public static string DatabasePath =>
           TestOverridePath ?? Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

    }

}