using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace BookLibraryApp
{
    internal class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string databasePath = "bookLibrary.db")
        {
            _connectionString = new SqliteConnectionStringBuilder
            {
                DataSource = databasePath,
                Mode = SqliteOpenMode.ReadWriteCreate
            }.ToString();
        }

        public void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = """
                    CREATE TABLE IF NOT EXISTS Books (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Author TEXT NOT NULL,
                        Year INTEGER NOT NULL,
                        Genre TEXT NOT NULL,
                        Status TEXT NOT NULL DEFAULT 'доступна'
                    );
                    """;

                command.ExecuteNonQuery();
            }
        }

        public SqliteConnection GetConnection() => new SqliteConnection( _connectionString );
    }
}
