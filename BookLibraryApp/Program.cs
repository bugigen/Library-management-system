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
            RunDatabaseOperations(databaseService);
        }

        private static void RunDatabaseOperations(DatabaseService databaseService)
        {
            try
            {
                databaseService.InitializeDatabase();
                Console.WriteLine("База данных успешно создана.");

                databaseService.AddBook(1, "Название 1", "Автор 1", 1, "Жанр 1", "доступна");
                databaseService.AddBook(2, "Название 2", "Автор 2", 2, "Жанр 2", "доступна");
                databaseService.AddBook(3, "Название 3", "Автор 3", 3, "Жанр 3", "доступна");

                Console.WriteLine("Данные добавлены.");
                Console.WriteLine("\nВсе книги:");

                databaseService.ShowAllBooks();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}