using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;
using BookLibraryApp.Books.Service;

namespace BookLibraryApp
{
    public partial class NewReader : Form
    {
        public NewReader(Form1 ParentRef)
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string FirstName = textBox_firstname.Text;
            string LastName = textBox_lastname.Text;
            string BookList = textBox_book.Text;
            string[] BookList_2 = BookList.Split(',');

            //List<Book> books = new List<Book>;
            BookService bookService = new BookService();
            List<Book> books = bookService.GetBooks();
            List<Book> books_search;

            Search search = new Search(books);

            for(int i = 0; i < BookList_2.Length; i++)
            {
                books_search = search.FindName(BookList_2[i]);
                //books_search.Add(search.FindName(BookList));

            }
            
            try
            {
                Reader book = new Reader();
                book.FirstName = FirstName;
                book.LastName = LastName;
                book.RentedBooks = books_search;
            }
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
            catch (Exception ex)
            {
                if (textBox_firstname.Text == null)
                    MessageBox.Show("Имя не может быть пустым");

                if (textBox_lastname.Text == null)
                    MessageBox.Show("Фамилия не может быть пустой");

                return;
            }
        }
    }
}
