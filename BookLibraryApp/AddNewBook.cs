using BookLibraryApp.Books.Dto;
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
        public AddNewBook(int id, Form1 ParentRef)
        {
            InitializeComponent();
            idel = id;
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
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            

            //BookService bookService = new BookService();
            //bookService.AddBook(book);

            using (var command = new SqliteCommand())
            {
                command.Connection = Program.DbService.Connection;
                command.CommandText = """
                    INSERT INTO Books (Title, Author, Year, Genre, Status) 
                    VALUES (@title, @author, @year, @genre, 'доступна')
                    """;

                command.Parameters.AddWithValue("@title", textBox_title.Text);
                command.Parameters.AddWithValue("@author", textBox_author.Text);
                command.Parameters.AddWithValue("@year", int.Parse(textBox_age.Text));
                command.Parameters.AddWithValue("@genre", textBox_ganre.Text);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Книга успешно добавлена.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить книгу.");
                }
            }

            //BookDto book = new BookDto(idel, author, title, age, ganre, "free");


            if (idel != 0)
            {
                Form1.SelfRef.closeAddNewBook();
            }
        }
    }
}
