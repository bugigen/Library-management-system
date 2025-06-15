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

        public void AddBook(int id,
                            string title,
                            string author,
                            int year,
                            string genre,
                            string status)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = """
                    INSERT INTO Books (
                        Id, Title, Author, Year, Genre, Status
                    ) 
                    VALUES (
                        $id, $title, $author, $year, $genre, $status
                    );
                    """;

                command.Parameters.AddWithValue("$id", id);
                command.Parameters.AddWithValue("$title", title);
                command.Parameters.AddWithValue("$author", author);
                command.Parameters.AddWithValue("$year", year);
                command.Parameters.AddWithValue("$genre", genre);
                command.Parameters.AddWithValue("$status", status);

                command.ExecuteNonQuery();
            }
        }

        public List<Book> ShowAllBooks()
        {
            var books = new List<Book>();

            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Books";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Author = reader.GetString(2),
                            Year = reader.GetInt32(3),
                            Genre = reader.GetString(4),
                            Status = reader.GetString(5),
                        });
                    }
                }
            }

            return books;
        }
    }
}
