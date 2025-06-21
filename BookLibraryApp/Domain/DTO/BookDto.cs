namespace BookLibraryApp.Domain.DTO
{
    public class BookDto
    {
        private string name;
        private int publishingYear;
        private string author;
        private string genre;

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
                if (value < -2600 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Невалидный год издания книги");
                }
                publishingYear = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Id не может быть меньше нуля");
                }
                author = value;
            }
        }

        public string Genre
        {
            get { return genre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Id не может быть меньше нуля");
                }
                genre = value;
            }
        }

        public BookDto(string name, int publishingYear, string author, string genre)
        {
            Name = name;
            PublishingYear = publishingYear;
            Author = author;
            Genre = genre;
        }
    }
}
