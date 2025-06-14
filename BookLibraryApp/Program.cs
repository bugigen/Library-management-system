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
                Console.WriteLine("���� ������ ������� �������.");

                using (SqliteConnection connection = databaseService.GetConnection())
                {
                    connection.Open();

                    var insertCommand = connection.CreateCommand();

                    insertCommand.CommandText = "INSERT INTO Books (Id, Title, Author, Year, " +
                        "Genre, Status) VALUES (1, '�������� 1', '����� 1', '��� 1', '���� 1', " +
                        "'��������')";

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine($"��������� �������: {rowsAffected}");

                    var selectCommand = connection.CreateCommand();

                    selectCommand.CommandText = "SELECT * FROM Books";

                    using (var book = selectCommand.ExecuteReader())
                    {
                        while (book.Read())
                        {
                            Console.WriteLine($"ID: {book["Id"]}, ��������: {book["Title"]}, " +
                                $"�����: {book["Author"]}, ��� �������: {book["Year"]}, " +
                                $"����: {book["Genre"]}, ������: {book["Status"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"������: {ex.Message}");
            }
        }
    }
}