using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;
using BookLibraryApp.Books.Service;

namespace BookLibraryApp
{
    public partial class EditBook : Form
    {
        public EditBook(Book book, Form1 ParentRef)
        {
            InitializeComponent();
            textBox_author.Text = book.Author;
            textBox_ganre.Text = book.Genre;
            textBox_title.Text = book.Name;
            textBox_age.Text = book.PublishingYear.ToString();
        }

        private void button_edit_Click(object sender, EventArgs e)
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
        }
    }
}
