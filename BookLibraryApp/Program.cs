using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Service;
using BookLibraryApp.DataBase;

namespace BookLibraryApp
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
           // ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            BookAppContext context = new BookAppContext();
            IAuthorService authorService = new AuthorService(context);
            AuthorDto dto = new AuthorDto("Александр Сергеевич Пушкин", 1799);
            var e = authorService.AddNewAuthor(dto).Result;
            var authors = authorService.GetAllAuthors();
            Console.WriteLine(authors);
            //var databaseService = new DatabaseService();
            //RunDatabaseOperations(databaseService);
        }

        //private static void RunDatabaseOperations(DatabaseService databaseService)
        //{
        //    try
        //    {
        //        databaseService.InitializeDatabase();
        //        Console.WriteLine("База данных успешно создана.");

        //        databaseService.AddBook(1, "Название 1", "Автор 1", 1, "Жанр 1", "доступна");
        //        databaseService.AddBook(2, "Название 2", "Автор 2", 2, "Жанр 2", "доступна");
        //        databaseService.AddBook(3, "Название 3", "Автор 3", 3, "Жанр 3", "доступна");

        //        Console.WriteLine("Данные добавлены.");
        //        Console.WriteLine("\nВсе книги:");
        //        databaseService.ShowAllBooks();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Ошибка: {ex.Message}");
        //    }
        //}
    }
}