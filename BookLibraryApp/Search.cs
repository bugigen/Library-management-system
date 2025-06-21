using BookLibraryApp.Domain.Models;
using BookLibraryApp.Logic.Service.BooksService;
using BookLibraryApp.Logic.Service.SearchService;
using BookLibraryApp.Domain.DTO;

namespace BookLibraryApp
{
    internal class Search
    {
        private List<Book> book;

        public Search(List<Book> book_in)
        {
            book = book_in;
        }

        //public List<Book> FindName(string name)
        //{
        //    //return book.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        //}

        //public List<Book> FindAge(int age)
        //{
        //    return book.Where(p => p.PublishingYear == age).ToList();
        //}

        public List<Book> FindAuthor(string author)
        {
            return book.Where(p => p.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> FindGenre(string genre)
        {
            return book.Where(p => p.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //public List<Book> FindBusy()
        //{
        //    return book.Where(p => p.IsAlreadyTaken == false).ToList();
        //}

        //public List<Book> FindFree()
        //{
        //    return book.Where(p => p.IsAlreadyTaken == true).ToList();
        //}
    }
}
