using BookLibraryApp.Domain.DTO;
using BookLibraryApp.Domain.HelperInterfaces;
using BookLibraryApp.Domain.Models;

namespace BookLibraryApp.Domain.Mappers
{
    public class BookMapper : IMapper<Book, BookDto>
    {
        public Book ToDomain(BookDto dto)
        {
            var book = new Book();
            book.Author = dto.Author;
            book.Genre = dto.Genre;
            book.Year = dto.PublishingYear;
            book.Status = "доступна";
            book.Title = dto.Name;
            return book;
        }

        public BookDto ToDto(Book domain)
        {
            return new BookDto
                (
                    domain.Title,
                    domain.Year,
                    domain.Author,
                    domain.Genre
                );
        }
    }
}
