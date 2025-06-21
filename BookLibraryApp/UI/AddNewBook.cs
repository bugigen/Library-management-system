using BookLibraryApp.Domain.DTO;
using BookLibraryApp.Logic.Service.BooksService;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibraryApp
{
    public partial class AddNewBook : Form
    {
        int idel;
        private readonly IBookService bookService;
        public AddNewBook(int id, Form1 ParentRef)
        {
            InitializeComponent();
            bookService = new BookService();
            idel = id;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            BookDto bookDto = null;
            try
            {
                bookDto = new BookDto
                    (
                        textBox_title.Text,
                        Convert.ToInt32(textBox_age.Text),
                        textBox_author.Text,
                        textBox_ganre.Text
                    );
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

            try
            {
                bookService.AddBook(bookDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            if (idel != 0)
            {
                Form1.SelfRef.closeAddNewBook();
            }
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {

        }
    }
}
