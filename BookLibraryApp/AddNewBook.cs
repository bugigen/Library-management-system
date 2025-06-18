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

namespace BookLibraryApp
{
    public partial class AddNewBook : Form
    {
        int idel;
        public AddNewBook(int id)
        {
            InitializeComponent();
            idel = id;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string author = textBox_author.Text;
            string title = textBox_title.Text;
            string age = textBox_age.Text;
            string ganre = textBox_ganre.Text;

            //BookDto book = new BookDto(idel, author, title, age, ganre, "free");
        }
    }
}
