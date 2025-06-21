using BookLibraryApp.Domain.Models;
using BookLibraryApp.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryApp.Logic.Service.SearchService
{
    public class SearchService : ISearchService
    {

        public List<Book> FindBooksByName(string name)
        {
            using (var context = new LibraryAppContext())
            {
                return context.Books.Where(p => EF.Functions.Like(p.Title, $"%{name}%")).ToList();
            }
        }

        public List<Book> FindBooksByPublishingYear(int publishingYear)
        {
            using (var context = new LibraryAppContext())
            {
                return context.Books.Where(p => p.Year == publishingYear).ToList();
            }
        }

        public List<Book> FindBooksByAuthor(string author)
        {
            using (var context = new LibraryAppContext())
            {
                return context.Books.Where(p => EF.Functions.Like(p.Author, $"%{author}%")).ToList();
            }
        }

        public List<Book> FindBooksByGenre(string genre)
        {
            using (var context = new LibraryAppContext())
            {
                return context.Books.Where(p => EF.Functions.Like(p.Genre, $"%{genre}%")).ToList();
            }
        }

        public List<Book> FindRentedBooks()
        {
            using (var context = new LibraryAppContext())
            {
                return context.Books.Where(p => p.Status.Equals(Constants.RENTED)).ToList();
            }
        }

        public List<Book> FindNotRentedBooks()
        {
            using (var context = new LibraryAppContext())
            {
                return context.Books.Where(p => p.Status.Equals(Constants.NOT_RENTED)).ToList();
            }
        }
    }
}
