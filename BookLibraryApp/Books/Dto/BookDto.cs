using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Books.Dto
{
    public class BookDto
    {
        private string name;
        private int publishingYear;
        private int authorId;
        private int genreId;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Название книги не может быть пустым");
                }
                name = value;
            }
        }

        public int PublishingYear
        {
            get { return publishingYear; }
            set
            {
                if(value < -2600 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Невалидный год издания книги");
                }
                publishingYear = value;
            }
        }

        public int AuthorId
        {
            get { return authorId; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Id не может быть меньше нуля");
                }
                authorId = value;
            }
        }

        public int GenreId
        {
            get { return genreId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id не может быть меньше нуля");
                }
                genreId = value;
            }
        }
    }
}
