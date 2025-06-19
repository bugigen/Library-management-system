using Microsoft.Data.Sqlite;

namespace BookLibraryApp
{
    public class DatabaseService
    {
        private const string DatabaseFile = "libraryDatabase.db";

        public SqliteConnection Connection { get; set; }

        public DatabaseService()
        {
            bool isNewDatabase = File.Exists(DatabaseFile) == false;

            Connection = new SqliteConnection($"Data Source={DatabaseFile}");

            Connection.Open();

            using (var command = Connection.CreateCommand())
            {
                command.CommandText = "PRAGMA foreign_keys = ON;";
                command.ExecuteNonQuery();
            }

            if (isNewDatabase)
                CreateTables();
        }

        private void CreateTables()
        {
            using (var command = Connection.CreateCommand())
            {
                command.CommandText = """
                CREATE TABLE IF NOT EXISTS Books (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Author TEXT NOT NULL,
                    Year INTEGER NOT NULL,
                    Genre TEXT NOT NULL,
                    Status TEXT NOT NULL CHECK(Status IN ('доступна', 'взята'))
                )
                """;

                command.ExecuteNonQuery();
            }

            using (var command = Connection.CreateCommand())
            {
                command.CommandText = """
                CREATE TABLE Readers (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FirstName TEXT NOT NULL,
                    LastName TEXT NOT NULL
                )
                """;

                command.ExecuteNonQuery();
            }

            using (var command = Connection.CreateCommand())
            {
                command.CommandText = """
                CREATE TABLE RentedBooks (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    BookId INTEGER NOT NULL,
                    ReaderId INTEGER NOT NULL,
                    RentDate TEXT NOT NULL DEFAULT (datetime('now')),
                    FOREIGN KEY (BookId) REFERENCES Books(Id) ON DELETE CASCADE,
                    FOREIGN KEY (ReaderId) REFERENCES Readers(Id) ON DELETE CASCADE
                )
                """;
                command.ExecuteNonQuery();
            }
        }
    }
}
