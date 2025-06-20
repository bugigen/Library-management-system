using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;

namespace BookLibraryApp.Books.Service
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetBookById(int id);
        Task<Book> AddBook(BookDto dto);
        Task<Book> UpdateBook(int id, BookDto dto);
        Task<Book> TakeBookToRent(int id);
        Task<Book> ReturnBookFromRent(int id);
        void DeleteBook(int id);
    }
}
