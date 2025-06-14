using Microsoft.Data.Sqlite;

namespace BookLibraryApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            var databaseService = new DatabaseService();

            try
            {
                databaseService.InitializeDatabase();
                Console.WriteLine("База данных успешно создана.");

                using (SqliteConnection connection = databaseService.GetConnection())
                {
                    connection.Open();

                    var insertCommand = connection.CreateCommand();

                    insertCommand.CommandText = "INSERT INTO Books (Id, Title, Author, Year, " +
                        "Genre, Status) VALUES (1, 'Название 1', 'Автор 1', 'Год 1', 'Жанр 1', " +
                        "'доступна')";

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine($"Добавлено записей: {rowsAffected}");

                    var selectCommand = connection.CreateCommand();

                    selectCommand.CommandText = "SELECT * FROM Books";

                    using (var book = selectCommand.ExecuteReader())
                    {
                        while (book.Read())
                        {
                            Console.WriteLine($"ID: {book["Id"]}, Название: {book["Title"]}, " +
                                $"Автор: {book["Author"]}, Год выпуска: {book["Year"]}, " +
                                $"Жанр: {book["Genre"]}, Статус: {book["Status"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}