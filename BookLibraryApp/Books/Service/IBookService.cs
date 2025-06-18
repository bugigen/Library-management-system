using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;

namespace BookLibraryApp.Books.Service
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetBookById(int id);
        Book AddBook(BookDto dto);
        Book UpdateBook(BookDto dto);
        Book TakeBookToRent(int id);
        Book ReturnBookFromRent(int id);
        void DeleteBook(int id);
    }
}
