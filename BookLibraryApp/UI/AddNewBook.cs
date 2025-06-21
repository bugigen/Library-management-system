using Microsoft.Data.Sqlite;
using System.ComponentModel;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Logic.Service.BooksService;
using BookLibraryApp.Logic.Service.SearchService;
using BookLibraryApp.Domain.DTO;

namespace BookLibraryApp
{
    public partial class AddNewBook : Form
    {
        private readonly IBookService _bookService;
        public AddNewBook(Form1 ParentRef)
        {
            InitializeComponent();

            _bookService = new BookService();

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

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                BookDto book = new BookDto
                    (
                        textBox_title.Text,
                        Convert.ToInt32(textBox_age.Text),
                        textBox_author.Text,
                        textBox_ganre.Text
                    );
                _bookService.AddBook(book);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                if (textBox_title.Text == null)
                    MessageBox.Show("Название книги не может быть пустым");

                if (!int.TryParse(textBox_age.Text, out _))
                    MessageBox.Show("Для года издание должно быть прописано число");

                if (textBox_author.Text == null)
                    MessageBox.Show("Название автора не может быть пустым");

                if (textBox_ganre.Text == null)
                    MessageBox.Show("Название жанра не может быть пустым");

                return;
            }
            finally
            {
                Form1.SelfRef.listView1_repit();
                this.Close();
            }
        }
    }
}
