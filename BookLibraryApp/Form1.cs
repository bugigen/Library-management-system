using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;
using BookLibraryApp.Books.Service;

namespace BookLibraryApp
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static Form1 SelfRef { get; set; }
        public Form1()
        {
            InitializeComponent();
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

            //BookService.GetBooks();
            //var databaseService = new DatabaseService();
            //List<Book> books = new List<Book>();
            //books = databaseService.ShowAllBooks();

            //for (int i = 0; i < books.Count; i++)
            //{
            //    ListViewItem lvItem = new ListViewItem();
            //    lvItem.Text = books[i].Id.ToString();
            //    lvItem.SubItems.Add(books[i].Title.ToString());
            //    lvItem.SubItems.Add(books[i].Author.ToString());
            //    lvItem.SubItems.Add(books[i].Year.ToString());
            //    lvItem.SubItems.Add(books[i].Genre.ToString());
            //    lvItem.SubItems.Add(books[i].Status.ToString());
            //    listView1.Items.Add(lvItem);
            //}

            //AuthorDto author = new AuthorDto("Victor", 1999);
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
    }
}
