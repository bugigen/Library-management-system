using BookLibraryApp.Domain.Models;

namespace BookLibraryApp.Logic.Service.SearchService
{
    public interface ISearchService
    {
        List<Book> FindBooksByName(string name);
        List<Book> FindBooksByPublishingYear(int publishingYear);
        List<Book> FindBooksByAuthor(string author);
        List<Book> FindBooksByGenre(string genre);
        List<Book> FindRentedBooks();
        List<Book> FindNotRentedBooks();
    }
}
