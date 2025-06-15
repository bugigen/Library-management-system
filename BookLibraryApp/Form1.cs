namespace BookLibraryApp
{
    public partial class Form1 : Form
    {
        private readonly DatabaseService _databaseService;

        public Form1()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                _databaseService.InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonLoadBooks(object sender, EventArgs e)
        {
            LoadBooksToList();
        }

        private void LoadBooksToList()
        {
            try
            {
                listViewBooks.Items.Clear();
                listViewBooks.Columns.Clear();

                listViewBooks.View = View.Details;
                listViewBooks.FullRowSelect = true;
                listViewBooks.Columns.Add("ID", 50);
                listViewBooks.Columns.Add("Title", 200);
                listViewBooks.Columns.Add("Author", 150);
                listViewBooks.Columns.Add("Year", 50);
                listViewBooks.Columns.Add("Genre", 100);
                listViewBooks.Columns.Add("Status", 100);

                var books = _databaseService.ShowAllBooks();

                foreach (var book in books)
                {
                    var item = new ListViewItem(book.Id.ToString());
                    item.SubItems.Add(book.Title);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.Year.ToString());
                    item.SubItems.Add(book.Genre);
                    item.SubItems.Add(book.Status);

                    listViewBooks.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки книг: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
