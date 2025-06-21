using BookLibraryApp.Domain.DTO;
using BookLibraryApp.Domain.Models;

namespace BookLibraryApp.Logic.Service.BooksService
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetBookById(int id);
        Task<Book> AddBook(BookDto dto);
        Task<Book> UpdateBook(int id, BookDto dto);
        void DeleteBook(int id);
    }
}
