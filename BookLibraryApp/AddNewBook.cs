using System;
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

            //BookDto book = new BookDto(idel, author, title, age, ganre, "free");


            if (idel != 0)
            {
                Form1.SelfRef.closeAddNewBook();
            }
        }
    }
}
