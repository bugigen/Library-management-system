using System.ComponentModel;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Logic.Service.BooksService;
using BookLibraryApp.Logic.Service.SearchService;
using BookLibraryApp.Logic.Service.ReaderService;
using static System.Reflection.Metadata.BlobBuilder;
using BookLibraryApp.Logic.Service.RentalService;

namespace BookLibraryApp
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static Form1 SelfRef { get; set; }
        private readonly IRentalService _rentalService;
        private readonly IReaderService _readerService;
        private readonly IBookService _bookService;
        private readonly ISearchService _searchService;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            _rentalService = new RentalService();
            _bookService = new BookService();
            _readerService = new ReaderService();
            _searchService = new SearchService();

            if (listView1.Columns.Count == 0) return;

            int totalWidth = listView1.ClientSize.Width;
            int columnCount = listView1.Columns.Count;

            for (int i = 0; i < columnCount; i++)
            {
                listView1.Columns[i].Width = totalWidth / columnCount;
            }
            SelfRef = this;

            byte[] iconBytes = Properties.Resources.free_icon_digital_library_7398682;

            using (var memoryStream = new MemoryStream(iconBytes))
            {
                try
                {
                    Icon icon = new Icon(memoryStream);
                    this.Icon = icon;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить иконку: " + ex.Message);
                }
            }
        }

        private void button_show_book_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            //listView1.Items.Clear();
            listView1_repit();
        }

        public void listView1_repit()
        {
            List<Book> books = _bookService.GetBooks();
            listView1.Items.Clear();
            comboBox3.Items.Clear();

            foreach (Book book in books)
            {
                comboBox3.Items.Add(book.Id);
                ListViewItem item = new ListViewItem();
                item.Text = book.Id.ToString();
                item.SubItems.Add(book.Author.ToString());
                item.SubItems.Add(book.Title.ToString());
                item.SubItems.Add(book.Year.ToString());
                item.SubItems.Add(book.Genre.ToString());
                item.SubItems.Add(book.Status.ToString());

                listView1.Items.Add(item);
            }
        }

        public void listView2_repit()
        {
            List<Reader> readlist = _readerService.GetAllReaders();

            listView2.Items.Clear();

            foreach (Reader book in readlist)
            {
                ListViewItem item = new ListViewItem();
                //item.SubItems.Add(book.Id.ToString());
                item.Text = book.Id.ToString();
                item.SubItems.Add(book.FirstName.ToString());
                item.SubItems.Add(book.LastName.ToString());
                //item.SubItems.Add(book.Year.ToString());

                listView2.Items.Add(item);
            }
        }

        private void button_new_book_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook(SelfRef);
            addNewBook.Show();
        }

        private void button_edit_book_Click(object sender, EventArgs e)
        {
            //ListViewItem selectedItem = listView1.SelectedItems[0];
            int id = Convert.ToInt32(comboBox3.SelectedItem.ToString());
            //int id = Convert.ToInt32(selectedItem.SubItems[0].Text);
            Book editbook = _bookService.GetBookById(id);
            EditBook editBook = new EditBook(editbook, SelfRef);
            editBook.Show();
            //listView2_repit();
        }

        private void button_new_reader_Click(object sender, EventArgs e)
        {
            NewReader newReader = new NewReader(SelfRef);
            newReader.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
            listView2_repit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintRents();
            this.tabControl1.SelectedIndex = 4;
            List<Reader> readlist = _readerService.GetAllReaders();

            List<Book> books = _bookService.GetBooks();

            comboBox1.Items.Clear();
            listView5.Items.Clear();

            foreach (Reader book in readlist)
            {
                comboBox2.Items.Add(book.Id);

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(book.Id.ToString());
                item.SubItems.Add(book.FirstName.ToString());
                item.SubItems.Add(book.LastName.ToString());
                listView5.Items.Add(item);
            }
            //comboBox1.SelectedIndex = 0;

            foreach (Book book in books)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(book.Id.ToString());
                item.SubItems.Add(book.Title.ToString());
                comboBox4.Items.Add(book.Id.ToString());

                listView3.Items.Add(item);
            }
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
            List<Book> books = _bookService.GetBooks();

            List<Book> books_out = new List<Book>();

            //Search search = new Search(books);

            string selecte = comboBox1.SelectedItem.ToString();
            switch (selecte)
            {
                case "Название":
                    books_out = _searchService.FindBooksByName(textBox1.Text);
                    //books_out = search.FindName
                    break;
                case "Автор":
                    books_out = _searchService.FindBooksByAuthor(textBox1.Text);
                    //books_out = search.FindAuthor(textBox1.Text);
                    break;
                case "Жанр":
                    books_out = _searchService.FindBooksByGenre(textBox1.Text);
                    //books_out = search.FindGenre(textBox1.Text);
                    break;

                default:
                    MessageBox.Show("Ты лох");
                    break;
            }

            listView3.Items.Clear();

            foreach (Book book in books_out)
            {
                ListViewItem item = new ListViewItem();
                //item.SubItems.Add(book.Id.ToString());
                item.Text = book.Id.ToString();
                item.SubItems.Add(book.Author.ToString());
                item.SubItems.Add(book.Title.ToString());
                item.SubItems.Add(book.Year.ToString());
                item.SubItems.Add(book.Genre.ToString());
                item.SubItems.Add(book.Status.ToString());

                listView3.Items.Add(item);
            }
        }

        private void button_true_Click(object sender, EventArgs e)
        {
            List<Book> books = _bookService.GetBooks();

            List<Book> books_out = new List<Book>();

            //Search search = new Search(books);
            books_out = _searchService.FindNotRentedBooks();

            listView3.Items.Clear();

            foreach (Book book in books_out)
            {
                ListViewItem item = new ListViewItem();
                //item.SubItems.Add(book.Id.ToString());
                item.Text = book.Id.ToString();
                item.SubItems.Add(book.Author.ToString());
                item.SubItems.Add(book.Title.ToString());
                item.SubItems.Add(book.Year.ToString());
                item.SubItems.Add(book.Genre.ToString());
                item.SubItems.Add(book.Status.ToString());

                listView3.Items.Add(item);
            }
        }

        private void button_false_Click(object sender, EventArgs e)
        {
            List<Book> books = _bookService.GetBooks();

            List<Book> books_out = new List<Book>();

            //Search search = new Search(books);
            books_out = _searchService.FindRentedBooks();

            listView3.Items.Clear();

            foreach (Book book in books_out)
            {
                ListViewItem item = new ListViewItem();
                //item.SubItems.Add(book.Id.ToString());
                item.Text = book.Id.ToString();
                item.SubItems.Add(book.Author.ToString());
                item.SubItems.Add(book.Title.ToString());
                item.SubItems.Add(book.Year.ToString());
                item.SubItems.Add(book.Genre.ToString());
                item.SubItems.Add(book.Status.ToString());

                listView3.Items.Add(item);
            }
        }

        private void button_delet_book_Click(object sender, EventArgs e)
        {
            //ListViewItem selectedItem = listView1.SelectedItems[0];
            //int id = Convert.ToInt32(selectedItem.SubItems[0].Text);
            int id = Convert.ToInt32(comboBox3.SelectedItem.ToString());
            _bookService.DeleteBook(id);
            listView1_repit();
        }

        private void button_give_book_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBox4.SelectedItem;
            int id_book = Convert.ToInt32(selectedItem);

            //ListViewItem selectedItem2 = listView5.SelectedItems[0];
            //int id_reader = Convert.ToInt32(selectedItem2.SubItems[0].Text);
            int id_reader = Convert.ToInt32(comboBox2.Text);

            var rent = _rentalService.RentBook(id_book, id_reader).Result;
            rent.Book = _bookService.GetBookById(rent.BookId);
            rent.Reader = _readerService.GetReaderById(rent.ReaderId);

            PrintRents();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBox4.SelectedItem;
            int id_book = Convert.ToInt32(selectedItem);

            //ListViewItem selectedItem2 = listView5.SelectedItems[0];
            //int id_reader = Convert.ToInt32(selectedItem2.SubItems[0].Text);
            int id_reader = Convert.ToInt32(comboBox2.Text);

            RentalService rentalService = new RentalService();
            var rent = rentalService.ReturnBook(id_book, id_reader).Result;

            PrintRents();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PrintRents()
        {
            listView4.Items.Clear();
            foreach (var e in _rentalService.GetAllRents())
            {
                ListViewItem item = new ListViewItem();
                var book = _bookService.GetBookById(e.BookId);
                var reader = _readerService.GetReaderById(e.ReaderId);
                item.SubItems.Add(e.BookId.ToString());
                item.SubItems.Add(book.Title);
                item.SubItems.Add(reader.FirstName + " " + reader.LastName);
                listView4.Items.Add(item);
            }
        }
    }
}
