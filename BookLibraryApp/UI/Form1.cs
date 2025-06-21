using System.ComponentModel;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Logic.Service.BooksService;
using BookLibraryApp.Logic.Service.SearchService;

namespace BookLibraryApp
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static Form1 SelfRef { get; set; }
        private readonly IBookService _bookService;

        public Form1()
        {
            InitializeComponent();
            _bookService = new BookService();
            comboBox1.SelectedIndex = 0;

            if (listView1.Columns.Count == 0) return;

            int totalWidth = listView1.ClientSize.Width;
            int columnCount = listView1.Columns.Count;

            for (int i = 0; i < columnCount; i++)
            {
                listView1.Columns[i].Width = totalWidth / columnCount;
            }
            SelfRef = this;
        }

        private void button_show_book_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            listView1.Items.Clear();
            List<Book> books = _bookService.GetBooks();
        }

        private void button_new_book_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook(1, SelfRef);
            addNewBook.Show();
        }

        private void button_edit_book_Click(object sender, EventArgs e)
        {
            EditBook editBook = new EditBook();
            editBook.Show();
        }

        private void button_new_reader_Click(object sender, EventArgs e)
        {
            NewReader newReader = new NewReader();
            newReader.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 3;
        }

        private void button_search_2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 3;
        }

        private void button_back_menu_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        public void closeAddNewBook()
        {
            try
            {
                AddNewBook fr = (AddNewBook)Application.OpenForms["AddNewBook"];
                fr.Close();
            }
            catch (NullReferenceException ne)
            {

            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            List<Book> books_out = new List<Book>();

            SearchService search = new SearchService();
            string selecte = comboBox1.SelectedItem.ToString();
            switch (selecte)
            {
                case "Название":
                    books_out = search.FindBooksByName(textBox1.Text);
                    break;
                case "Автор":
                    books_out = search.FindBooksByAuthor(textBox1.Text);
                    break;
                case "Жанр":
                    books_out = search.FindBooksByGenre(textBox1.Text);
                    break;

                default:
                    MessageBox.Show("Ты лох");
                    break;
            }
        }

        private void button_true_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            List<Book> books_out = new List<Book>();

            SearchService search = new SearchService();
            books_out = search.FindNotRentedBooks();
        }

        private void button_false_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            List<Book> books_out = new List<Book>();

            SearchService search = new SearchService();
            books_out = search.FindRentedBooks();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
