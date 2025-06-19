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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DbService = new DatabaseService();

            // ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            BookAppContext context = new BookAppContext();
            #region ������ ���������� ����� �����
            var bookDto = new BookDto("������ � ���� �������", 1831, "��������� ��������� ������", "������");
            IBookService bookService = new BookService(context);
            var book = bookService.AddBook(bookDto);
            #endregion
            //var databaseService = new DatabaseService();
            //RunDatabaseOperations(databaseService);
        }

        //private static void RunDatabaseOperations(DatabaseService databaseService)
        //{
        //    try
        //    {
        //        databaseService.InitializeDatabase();
        //        Console.WriteLine("���� ������ ������� �������.");

        //        databaseService.AddBook(1, "�������� 1", "����� 1", 1, "���� 1", "��������");
        //        databaseService.AddBook(2, "�������� 2", "����� 2", 2, "���� 2", "��������");
        //        databaseService.AddBook(3, "�������� 3", "����� 3", 3, "���� 3", "��������");

        //        Console.WriteLine("������ ���������.");
        //        Console.WriteLine("\n��� �����:");
        //        databaseService.ShowAllBooks();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"������: {ex.Message}");
        //    }
        //}
    }
}