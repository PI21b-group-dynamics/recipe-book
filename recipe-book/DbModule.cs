using System.Data.SQLite;

namespace recipe_book
{
    internal static class DbModule
    {
        public const string DB_FILENAME = "Database.db";
        public static readonly SQLiteConnection Conn;

        static DbModule()
        {
            Conn = new SQLiteConnection($"Data Source = {DB_FILENAME}");
            Conn.Open();
            SQLiteCommand cmd = CreateCommand("""
                CREATE TABLE IF NOT EXISTS Users (
                    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    login TEXT NOT NULL UNIQUE,
                    email TEXT NOT NULL UNIQUE,
                    password TEXT NOT NULL
                );
                """
            );
            cmd.ExecuteNonQuery();
        }

        public static SQLiteCommand CreateCommand(string query, params SQLiteParameter[] parameters)
        {
            SQLiteCommand cmd = Conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddRange(parameters);
            return cmd;
        }
    }
}
